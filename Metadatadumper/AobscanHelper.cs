using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;

namespace PCRAutoTimeline
{
    public class AobscanHelper
    {
        /// <summary>
        /// 搜索Byte数组
        /// </summary>
        /// <param name="a">源数组</param>
        /// <param name="alen">长度</param>
        /// <param name="b">被搜索的数组</param>
        /// <param name="blen">被搜数组的长度</param>
        /// <returns>失败返回-1</returns>
        private static long Memmem(byte[] a, long alen, byte[] b, int blen, Func<long, bool> matchValidator)
        {
            long i, j, diff = alen - blen;
            for (i = 0; i < diff; i += 4) /* 4 bytes alignment */
            {
                j = 0;
                while (j < blen)
                {
                    if (a[i + j] != b[j])
                        goto next;
                    ++j;
                }
                if (matchValidator(i))
                    return i;
                next: ;
            }
            return -1;
        }



        public delegate IEnumerable<(long, long)> CompDele(byte[] a, long alen, int b_low, int b_high, Func<long, bool> matchValidator);

        /// <summary>
        /// 失败返回-1
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="aob"></param>
        /// <returns></returns>
        public static (long, long) Aobscan(long handle, byte[] aob, Func<long, bool> matchValidator, long blockToStart = 0, Action<string> callback = null)
        {
            // returns
            IEnumerable<(long, long)> getMemblocks(long handle)
            {
                long i = blockToStart;
                while (i < long.MaxValue)
                {
                    int flag = NativeFunctions.VirtualQueryEx(handle, i, out NativeFunctions.MEMORY_BASIC_INFORMATION mbi, NativeFunctions.MEMORY_BASIC_INFORMATION_SIZE);
                    if (flag != NativeFunctions.MEMORY_BASIC_INFORMATION_SIZE)
                        break;
                    if (mbi.RegionSize <= 0)
                        break;
                    if (mbi.State == (int)NativeFunctions.AllocationType.Commit)
                    {
                        yield return (mbi.RegionSize, mbi.BaseAddress);
                    }
                    i = mbi.BaseAddress + mbi.RegionSize;
                }
            }

            (long, long) result = (-1, -1);
            getMemblocks(handle).AsParallel().WithDegreeOfParallelism(8).ForAll(blk =>
            {
                var (size, @base) = blk;
                byte[] va = new byte[size];
                if (result.Item1 > 0) return;
                NativeFunctions.ReadProcessMemory(handle, @base, va, size, 0);
                if (result.Item1 > 0) return;
                long r = Memmem(va, va.Length, aob, aob.Length, r => matchValidator(@base + r));
                if (r >= 0)
                    result = (@base + r, @base);
            });
            return result;
        }


        public static IEnumerable<(long, long)> Compscan(long handle, int aob_low, int aob_high, Func<long, bool> matchValidator, CompDele memComp, long blockToStart = 0, Action<string> callback = null)
        {
            long i = blockToStart;
            while (i < long.MaxValue)
            {
                int flag = NativeFunctions.VirtualQueryEx(handle, i, out NativeFunctions.MEMORY_BASIC_INFORMATION mbi, NativeFunctions.MEMORY_BASIC_INFORMATION_SIZE);
                if (flag != NativeFunctions.MEMORY_BASIC_INFORMATION_SIZE)
                    break;
                if (mbi.RegionSize <= 0)
                    break;
                if (mbi.State != (int)NativeFunctions.AllocationType.Commit)
                {
                    i = mbi.BaseAddress + mbi.RegionSize;
                    continue;
                }
                if (callback != null) callback($"scanning {mbi.BaseAddress:x}...");
                else Console.Write($"\rscanning {mbi.BaseAddress:x}...");
                byte[] va = new byte[mbi.RegionSize];
                NativeFunctions.ReadProcessMemory(handle, mbi.BaseAddress, va, mbi.RegionSize, 0);
                foreach (var res_list_data in memComp(va, mbi.RegionSize, aob_low, aob_high, r => matchValidator(mbi.BaseAddress + r)))
                    yield return (mbi.BaseAddress + res_list_data.Item1, res_list_data.Item2);
                i = mbi.BaseAddress + mbi.RegionSize;
            }
        }

    }
}

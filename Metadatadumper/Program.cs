using System;
using System.IO;
using PCRAutoTimeline;

namespace Metadatadumper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pid>");
            var proc = int.Parse(Console.ReadLine());

            var hwnd = NativeFunctions.OpenProcess(NativeFunctions.PROCESS_ALL_ACCESS, false, proc);
            AobscanHelper.Aobscan(hwnd, new byte[]
            {
                0xaf, 0x1b, 0xb1, 0xfa, 0x18
            }, addr =>
            {
                NativeFunctions.ReadProcessMemory(hwnd, addr + 0x100, out int offset);
                NativeFunctions.ReadProcessMemory(hwnd, addr + 0x104, out int size);
                var metasize = offset + size;
                var buffer = new byte[metasize];
                NativeFunctions.ReadProcessMemory(hwnd, addr, buffer, metasize, 0);
                File.WriteAllBytes("global-metadata.dat", buffer);
                return true;
            });
        }
    }
}

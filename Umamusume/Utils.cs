using MsgPack;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Umamusume.Model;

namespace Umamusume
{
    public static class Utils
    {
        public static int? CalcMoney(this UserItem[] items)
        {
            return items?.Where(item => item.item_id == 59)?.Sum(item => item.number);
        }

        public static byte[] Pack(JToken token)
        {
            Func<JToken, object> mapper = null;

            mapper = o =>
            {
                if (o is JArray arr) return arr.Select(mapper).ToArray();
                else if (o is JObject obj) return new Dictionary<string, object>(
                    obj.Properties().Select(prop => new KeyValuePair<string, object>(prop.Name, mapper(prop.Value)))
                );
                else return o.ToObject<object>();
            };

            object mapped = mapper(token);

            return new BoxingPacker().Pack(mapped);
        }
        public static JToken Unpack(byte[] content)
        {
            return JToken.FromObject(new BoxingPacker().Unpack(content));
        }
        public static byte[] Hex2bin(string content)
        {
            return Enumerable.Range(0, content.Length / 2).Select(i => byte.Parse(content[(2 * i)..(2 * i + 2)], NumberStyles.AllowHexSpecifier)).ToArray();
        }
        public static string Bin2Hex(byte[] content)
        {
            return string.Concat(content.Select(x => x.ToString("x2")));
        }

        public static byte[] MakeMd5(string content)
        {
            using MD5 md5 = MD5.Create();
            return md5.ComputeHash(Encoding.UTF8.GetBytes(content + "r!I@mt8e5i="));
        }

        [ThreadStatic]
        private static Random rand;

        public static byte[] GenRandomBytes(int n)
        {
            if (rand == null) rand = new Random();
            byte[] b = new byte[n];
            rand.NextBytes(b);
            return b;
        }

        private static readonly char[] part1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
        private static readonly char[] part2 = "abcdeghijklmnopqrstuvwxyz".ToArray();
        private static readonly char[] part3 = "0123456789".ToArray();

        public static T[] RandomChoices<T>(this T[] source, int n)
        {
            return Enumerable.Range(0, n).Select(_ => source[rand.Next(0, source.Length - 1)]).ToArray();
        }

        public static string GenRandomPassword()
        {
            if (rand == null) rand = new Random();
            return new string(RandomChoices(part1, 4)) +
                new string(RandomChoices(part2, 4)) +
                new string(RandomChoices(part3, 4));
        }

        public static Guid ParseHex(byte[] b)
        {
            return Guid.Parse(Bin2Hex(b));
        }
    }
}

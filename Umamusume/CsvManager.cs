using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Umamusume.Data;

namespace Umamusume
{
    public static class CsvManager
    {
        private static Dictionary<Type, object> cache = new Dictionary<Type, object>();
        public static T[] LoadData<T>()
        {
            if (!cache.ContainsKey(typeof(T)))
            {
                var filename = (typeof(T).GetCustomAttributes(typeof(CsvFileAttribute), false).Single() as CsvFileAttribute).filename;
                filename = Path.Combine("Data", filename + ".csv");
                using var cr = new CsvReader(new StreamReader(File.OpenRead(filename)), CultureInfo.CurrentCulture);
                cache.Add(typeof(T), cr.GetRecords<T>().ToArray());
            }

            return cache[typeof(T)] as T[];
        }
    }
}

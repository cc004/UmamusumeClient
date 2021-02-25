using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umamusume.Data
{
    public sealed class CsvFileAttribute : Attribute
    {
        public string filename;
        public CsvFileAttribute(string filename)
        {
            this.filename = filename;
        }
    }
}

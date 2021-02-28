using System;

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

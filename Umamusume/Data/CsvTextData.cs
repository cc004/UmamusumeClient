namespace Umamusume.Data
{
    [CsvFile("text_data")]
    public class CsvTextData
    {
        public int id { get; set; }
        public int category { get; set; }
        public int index { get; set; }
        public string text { get; set; }
    }
}

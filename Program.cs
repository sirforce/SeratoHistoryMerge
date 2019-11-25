using CsvHelper;
using System;
using System.IO;

namespace SeratoHistoryMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] myFiles = Directory.GetFiles(@"c:\\SeratoHistory\\", "*.csv");
            DateTime startingDate;
            DateTime endingDate;
            DateTime rowDate;
            
            foreach (string filename in myFiles)
            {
                using (var reader = new StreamReader(filename))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                    using (var historydata = new CsvReader(reader))
                    {
                        int rowCount = 0;

                        var records = historydata.GetRecords<dynamic>();


                    }

                }
            }
        }
    }
}

using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeratoHistoryMerge
{
    class History
    {
        public string name { get; set; }

        public string artist { get; set; }

        public string bpm { get; set; }


        [Name("start time")]
        public string starttime { get; set; }


        [Name("end time")]
        public string endtime { get; set; }

        public string playtime { get; set; }


        public string deck { get; set; }

        public string notes { get; set; }
       
        
        public string album { get; set; }

        public string filename { get; set; }

        public string location { get; set; }

        public string comment { get; set; }




    }


}

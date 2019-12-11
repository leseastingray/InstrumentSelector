using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace InstrumentSelector.Models
{
    public class Instrument
    {
        private static List<Instrument> instruments = new List<Instrument>();
        private static List<Comment> comments = new List<Comment>();

        // Primary Key ID
        public int InstrumentID { get; set; }

        public string Size { get; set; }
        // 0 = very low, 1 = low, 2 = middle, 3 = high 4 = very high
        public string Range { get; set; }
        public string RangeDescription { get; set; }
        // 0 = heavy, 1 = dark, 2 = mellow, 3 = reedy 4 = bright
        public string Tone { get; set; }
        public string ToneDescription { get; set; }
        public string Technical { get; set; }
        public string DescriptionText { get; set; }

        public List<Comment> Comments { get { return comments; } }
    }
}

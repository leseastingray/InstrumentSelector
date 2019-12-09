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

        public string Size { get; set; }
        public string Range { get; set; }
        public string Tone { get; set; }
        public string Technical { get; set; }
        public string DescriptionText { get; set; }

        public List<Comment> Comments { get { return comments; } }
    }
}

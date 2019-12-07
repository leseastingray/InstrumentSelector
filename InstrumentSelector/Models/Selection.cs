using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstrumentSelector.Models
{
    // This is the class to represent the user's selections
    public class Selection
    {
        private List<Selection> selections = new List<Selection>();

        // 0 = huge, 1 = large, 2 = medium, 3 = small 4 = very small
        public string PreferredSize { get; set; }
        // 0 = very low, 1 = low, 2 = middle, 3 = high 4 = very high
        public string PreferredRange { get; set; }
        // 0 = heavy, 1 = dark, 2 = mellow, 3 = reedy 4 = bright
        public string PreferredTone { get; set; }
        // 0 = easy, 1 = moderate, 2 = difficult, 3 = most challenging
        public string PreferredTechnical { get; set; }

        public Instrument PreferredInstrument { get; set; }
    }
}

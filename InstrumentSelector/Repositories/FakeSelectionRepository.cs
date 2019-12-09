using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class FakeSelectionRepository : ISelectionRepository
    {
        private static List<Selection> selections = new List<Selection>();
        private List<SelectionResult> results = new List<SelectionResult>();

        public List<Selection> Selections { get { return selections;  } }

        public List<SelectionResult> SelectionResults { get { return results; } }


        public void AddSelection(Selection selection)
        {
            selections.Add(selection);
        }

        public void AddSelectionResult(SelectionResult result)
        {
            results.Add(result);
        }

        public Selection GetSelectionByInstrument(Instrument instrument)
        {
            Selection selection = selections.Find(s => s.PreferredInstrument == instrument);
            return selection;
        }

        public Selection GetSelectionByInstrument(string instrument)
        {
            Selection selection = selections.Find(s => s.PreferredInstrument.ToString() == instrument);
            return selection;
        }

        public SelectionResult GetSelectionResultByInstrument(Instrument instrument)
        {
            SelectionResult result = results.Find(r => r.Instrument == instrument);
            return result;
        }

        public SelectionResult GetSelectionResultByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }
    }
}

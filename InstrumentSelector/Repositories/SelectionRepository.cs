using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class SelectionRepository : ISelectionRepository
    {
        private static List<Selection> selections = new List<Selection>();

        public List<Selection> Selections => selections;

        public List<SelectionResult> SelectionResults => throw new NotImplementedException();

        public void AddSelection(Selection selection)
        {
            selections.Add(selection);
        }

        public void AddSelectionResult(SelectionResult result)
        {
            throw new NotImplementedException();
        }

        public Selection GetSelectionByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }

        public SelectionResult GetSelectionResultByInstrument(string instrument)
        {
            throw new NotImplementedException();
        }
    }
}

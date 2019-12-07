using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class FakeSelectionRepository : ISelectionRepository
    {
        private List<Selection> selections = new List<Selection>();
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
    }
}

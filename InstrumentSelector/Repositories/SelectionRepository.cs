using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class SelectionRepository : ISelectionRepository
    {
        // Added for EF
        private AppDbContext context;

        private static List<Selection> selections = new List<Selection>();
        private List<SelectionResult> results = new List<SelectionResult>();

        // edited for EF
        public List<Selection> Selections { get { return context.Selections.ToList(); } }

        //public List<SelectionResult> SelectionResults { get { return results; } }

        // Added constructor for EF
        public SelectionRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        // edited all for EF
        public void AddSelection(Selection selection)
        {
            context.Selections.Add(selection);
            context.SaveChanges();
        }
        /*
        public void AddSelectionResult(SelectionResult result)
        {
            results.Add(result);
        }

        public Selection GetSelectionByInstrument(Instrument instrument)
        {
            Selection selection;
            selection = context.Selections.Find(s => s.PreferredInstrument == instrument);
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
        */
    }
}

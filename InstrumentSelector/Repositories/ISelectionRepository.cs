using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public interface ISelectionRepository
    {
        // For Selections
        List<Selection> Selections { get;  }
        void AddSelection(Selection selection);

        // For SelectionResults
        //List<SelectionResult> SelectionResults { get; }
        void AddSelectionResult(SelectionResult result);

        // Get Selection by Instrument Result
        Selection GetSelectionByInstrument(string instrument);
        // Get SelectionResult by Instrument Result
        SelectionResult GetSelectionResultByInstrument(string instrument);
    }
}

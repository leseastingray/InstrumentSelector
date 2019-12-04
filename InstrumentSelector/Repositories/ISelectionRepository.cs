using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public interface ISelectionRepository
    {
        List<Selection> Selections { get; }
        void AddSelection(Selection selection);
    }
}

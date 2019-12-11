using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public interface IInstrumentRepository
    {
        List<Instrument> Instruments { get; }
        void AddInstrument(Instrument instrument);
        void AddDefaultInstruments();

        List<Instrument> GetInstrumentsBySize(string size);
        List<Instrument> GetInstrumentsByRange(string range);
        List<Instrument> GetInstrumentsByTone(string tone);
        List<Instrument> GetInstrumentsByTechnical(string technical);
        //Instrument GetInstrumentByDescription(string description);
    }
}

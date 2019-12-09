using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class InstrumentRepository : IInstrumentRepository
    {

        public IQueryable<Instrument> Instruments => throw new NotImplementedException();
        public InstrumentRepository() { }

        public void AddInstrument(Instrument instrument)
        {
            throw new NotImplementedException();
        }

        public List<Instrument> GetInstrumentsBySize(string size)
        {
            throw new NotImplementedException();
        }

        public List<Instrument> GetInstrumentsByRange(string range)
        {
            throw new NotImplementedException();
        }

        public List<Instrument> GetInstrumentsByTone(string tone)
        {
            throw new NotImplementedException();
        }

        public List<Instrument> GetInstrumentsByTechnical(string technical)
        {
            throw new NotImplementedException();
        }

        public Instrument GetInstrumentByDescription(string description)
        {
            throw new NotImplementedException();
        }

        public void AddDefaultInstruments()
        {
            throw new NotImplementedException();
        }
    }
}

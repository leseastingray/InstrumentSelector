using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class FakeInstrumentRepository : IInstrumentRepository
    {
        private static List<Instrument> instruments = new List<Instrument>();
        public IQueryable<Instrument> Instruments { get { return instruments.AsQueryable<Instrument>(); } }

        public FakeInstrumentRepository()
        {
            AddDefaultInstruments();
        }

        public void AddInstrument(Instrument instrument)
        {
            instruments.Add(instrument);
        }

        public List<Instrument> GetInstrumentsByRange(string range)
        {
            List<Instrument> rangeInstruments = new List<Instrument>();
            foreach (Instrument instrument in instruments)
            {
                if (instrument.Range == range)
                {
                    rangeInstruments.Add(instrument);
                }
            }
            return rangeInstruments;
        }

        public List<Instrument> GetInstrumentsBySize(string size)
        {
            List<Instrument> sizeInstruments = new List<Instrument>();
            foreach (Instrument instrument in instruments)
            {
                if (instrument.Size == size)
                {
                    sizeInstruments.Add(instrument);
                }
            }
            return sizeInstruments;
        }

        public List<Instrument> GetInstrumentsByTechnical(string technical)
        {
            List<Instrument> technicalInstruments = new List<Instrument>();
            foreach (Instrument instrument in instruments)
            {
                if (instrument.Technical == technical)
                {
                    technicalInstruments.Add(instrument);
                }
            }
            return technicalInstruments;
        }

        public List<Instrument> GetInstrumentsByTone(string tone)
        {
            List<Instrument> toneInstruments = new List<Instrument>();
            foreach (Instrument instrument in instruments)
            {
                if (instrument.Tone == tone)
                {
                    toneInstruments.Add(instrument);
                }
            }
            return toneInstruments;
        }

        public Instrument GetInstrumentByDescription(string description)
        {
            Instrument instrument = instruments.Find(i => i.DescriptionText == description);
            return instrument;
        }

        // Default instruments
        public void AddDefaultInstruments()
        {
            Instrument flute = new Instrument()
            {
                DescriptionText = "Flute",
                Size = "4",
                Range = "4",
                Tone = "4",
                Technical = "3"
            };
            Instrument oboe = new Instrument()
            {
                DescriptionText = "Oboe",
                Size = "3",
                Range = "3",
                Tone = "3",
                Technical = "2"
            };
            Instrument clarinet = new Instrument()
            {
                DescriptionText = "Clarinet",
                Size = "3",
                Range = "3",
                Tone = "2",
                Technical = "3"
            };
            Instrument saxophone = new Instrument()
            {
                DescriptionText = "Saxophone",
                Size = "2",
                Range = "2",
                Tone = "2",
                Technical = "2"
            };
            Instrument bassoon = new Instrument()
            {
                DescriptionText = "Bassoon",
                Size = "1",
                Range = "1",
                Tone = "3",
                Technical = "1"
            };
            Instrument trumpet = new Instrument()
            {
                DescriptionText = "Trumpet",
                Size = "3",
                Range = "3",
                Tone = "4",
                Technical = "3"
            };
            Instrument horn = new Instrument()
            {
                DescriptionText = "French Horn",
                Size = "2",
                Range = "2",
                Tone = "2",
                Technical = "1"
            };
            Instrument trombone = new Instrument()
            {
                DescriptionText = "Trombone",
                Size = "1",
                Range = "1",
                Tone = "1",
                Technical = "1"
            };
            Instrument euphonium = new Instrument()
            {
                DescriptionText = "Euphonium",
                Size = "0",
                Range = "1",
                Tone = "2",
                Technical = "2"
            };
            Instrument tuba = new Instrument()
            {
                DescriptionText = "Tuba",
                Size = "0",
                Range = "0",
                Tone = "0",
                Technical = "0"
            };
            instruments.Add(flute);
            instruments.Add(oboe);
            instruments.Add(clarinet);
            instruments.Add(saxophone);
            instruments.Add(bassoon);
            instruments.Add(trumpet);
            instruments.Add(horn);
            instruments.Add(trombone);
            instruments.Add(euphonium);
            instruments.Add(tuba);
        }
    }
}
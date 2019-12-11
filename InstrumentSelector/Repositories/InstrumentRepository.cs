using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentSelector.Models;

namespace InstrumentSelector.Repositories
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private AppDbContext context;
        private static List<Instrument> instruments = new List<Instrument>();
        public List<Instrument> Instruments { get { return context.Instruments.ToList(); } }

        public InstrumentRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
            // call to add to repo (method interacts with context)
            AddDefaultInstruments();
        }

        public void AddInstrument(Instrument instrument)
        {
            context.Instruments.Add(instrument);
            context.SaveChanges();
        }

        public List<Instrument> GetInstrumentsByRange(string range)
        {
            List<Instrument> rangeInstruments = new List<Instrument>();
            foreach (Instrument instrument in context.Instruments)
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
            foreach (Instrument instrument in context.Instruments)
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
            foreach (Instrument instrument in context.Instruments)
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
            foreach (Instrument instrument in context.Instruments)
            {
                if (instrument.Tone == tone)
                {
                    toneInstruments.Add(instrument);
                }
            }
            return toneInstruments;
        }
        /*
        public Instrument GetInstrumentByDescription(string description)
        {
            Instrument instrument;
            foreach (Instrument instrument in context.Instruments)
            {
                if (instrument.DescriptionText.Equals(description))
                {
                    instrument
                }
            }
            return instrument;
        }
        */
        // Default instruments
        public void AddDefaultInstruments()
        {
            Instrument flute = new Instrument()
            {
                DescriptionText = "Flute",
                Size = "4",
                Range = "4",
                RangeDescription = "Very high",
                Tone = "4",
                ToneDescription = "Bright",
                Technical = "3"
            };
            Instrument oboe = new Instrument()
            {
                DescriptionText = "Oboe",
                Size = "3",
                Range = "3",
                RangeDescription = "High",
                Tone = "3",
                ToneDescription = "Reedy",
                Technical = "2"
            };
            Instrument clarinet = new Instrument()
            {
                DescriptionText = "Clarinet",
                Size = "3",
                Range = "3",
                RangeDescription = "High",
                Tone = "2",
                ToneDescription = "Mellow",
                Technical = "3"
            };
            Instrument saxophone = new Instrument()
            {
                DescriptionText = "Saxophone",
                Size = "2",
                Range = "2",
                RangeDescription = "Middle",
                Tone = "2",
                ToneDescription = "Mellow",
                Technical = "2"
            };
            Instrument bassoon = new Instrument()
            {
                DescriptionText = "Bassoon",
                Size = "1",
                Range = "1",
                RangeDescription = "Low",
                Tone = "3",
                ToneDescription = "Reedy",
                Technical = "1"
            };
            Instrument trumpet = new Instrument()
            {
                DescriptionText = "Trumpet",
                Size = "3",
                Range = "3",
                RangeDescription = "High",
                Tone = "4",
                ToneDescription = "Bright",
                Technical = "3"
            };
            Instrument horn = new Instrument()
            {
                DescriptionText = "French Horn",
                Size = "2",
                Range = "2",
                RangeDescription = "Middle",
                Tone = "2",
                ToneDescription = "Mellow",
                Technical = "1"
            };
            Instrument trombone = new Instrument()
            {
                DescriptionText = "Trombone",
                Size = "1",
                Range = "1",
                RangeDescription = "Low",
                Tone = "1",
                ToneDescription = "Dark",
                Technical = "1"
            };
            Instrument euphonium = new Instrument()
            {
                DescriptionText = "Euphonium",
                Size = "0",
                Range = "1",
                RangeDescription = "Low",
                Tone = "2",
                ToneDescription = "Heavy",
                Technical = "2"
            };
            Instrument tuba = new Instrument()
            {
                DescriptionText = "Tuba",
                Size = "0",
                Range = "0",
                RangeDescription = "Very low",
                Tone = "0",
                ToneDescription = "Heavy",
                Technical = "0"
            };
            context.Instruments.Add(flute);
            context.Instruments.Add(oboe);
            context.Instruments.Add(clarinet);
            context.Instruments.Add(saxophone);
            context.Instruments.Add(bassoon);
            context.Instruments.Add(trumpet);
            context.Instruments.Add(horn);
            context.Instruments.Add(trombone);
            context.Instruments.Add(euphonium);
            context.Instruments.Add(tuba);

            context.SaveChanges();
        }
    }
}

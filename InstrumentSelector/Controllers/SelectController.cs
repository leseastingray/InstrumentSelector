using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InstrumentSelector.Models;
using InstrumentSelector.Repositories;

namespace InstrumentSelector.Controllers
{
    public class SelectController : Controller
    {
        Selection selection;
        SelectionResult selectionResult;
        string resultText;

        private static List<Instrument> instruments = new List<Instrument>();
        private List<Instrument> sizeInstruments = new List<Instrument>();
        private List<Instrument> rangeInstruments = new List<Instrument>();
        private List<Instrument> toneInstruments = new List<Instrument>();
        private List<Instrument> technicalInstruments = new List<Instrument>();

        // Repository declaration
        ISelectionRepository repo;
        IInstrumentRepository instrumentRepo;

        public SelectController(ISelectionRepository r, IInstrumentRepository i)
        {
            repo = r;
            instrumentRepo = i;
        }

        [HttpGet]
        public ViewResult Selection()
        {
            return View();
        }

        // Selection form submission
        [HttpPost]
        public RedirectToActionResult Selection(Selection s)
        {
            repo.AddSelection(s);
            return RedirectToAction("SelectionResult");
        }
        // Selection result
        public ViewResult SelectionResult()
        {
            Selection s = repo.Selections.Last();
            List<Instrument> viewResults = new List<Instrument>();

            // get instruments matching or near matching size
            sizeInstruments = InstrumentSelectForSize(s);
            // get instruments matching or near matching range
            rangeInstruments = InstrumentSelectForRange(s);
            // get instruments matching or near matching tone
            toneInstruments = InstrumentSelectForTone(s);
            // get instruments matching or near matching technical
            technicalInstruments = InstrumentSelectForTechnical(s);

            // Add all instruments to viewResults instruments list
            foreach (Instrument i in sizeInstruments)
            {
                if (!viewResults.Contains(i))
                {
                    viewResults.Add(i);
                }
            }
            foreach (Instrument i in rangeInstruments)
            {
                if (!viewResults.Contains(i))
                {
                    viewResults.Add(i);
                }
            }
            foreach (Instrument i in toneInstruments)
            {
                if (!viewResults.Contains(i))
                {
                    viewResults.Add(i);
                }
            }
            foreach (Instrument i in technicalInstruments)
            {
                if (!viewResults.Contains(i))
                {
                    viewResults.Add(i);
                }
            }

            List<Instrument> dedup = new List<Instrument>();
            foreach (Instrument i in viewResults)
            {
                bool isItThere = false;
                foreach (Instrument j in dedup)
                {
                    if (i.DescriptionText.Equals(j.DescriptionText))
                    {
                        isItThere = true;
                        break;
                    }
                }
                if (!isItThere)
                {
                    dedup.Add(i);
                }
                isItThere = false;
            }
            return View(viewResults);
        }
        
        public string ResultText(List<Instrument> instrumentResults)
        {
            foreach (Instrument i in instruments)
            {
                resultText = i.DescriptionText + "\n";
            }
            return resultText;
        }
        
        // Section Methods
        public List<Instrument> InstrumentSelectForSize(Selection s)
        {
            String caseSize = s.PreferredSize;
            foreach (Instrument i in instrumentRepo.GetInstrumentsBySize(caseSize))
            {
                bool add = true;
                foreach (Instrument j in sizeInstruments)
                {
                    if (i.DescriptionText.Equals(j.DescriptionText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    sizeInstruments.Add(i);
                }
            }
            /* // Switch
            switch (caseSize)
            {
                case "0":
                    sizeInstrument1 = instrumentRepo.GetInstrumentsBySize("0");
                    break;
                case "1":
                    sizeInstrument1 = instrumentRepo.GetInstrumentsBySize("1");
                    break;
                case "2":
                    sizeInstrument1 = instrumentRepo.GetInstrumentsBySize("2");
                    break;
                case "3":
                    sizeInstrument1 = instrumentRepo.GetInstrumentsBySize("3");
                    break;
                case "4":
                    sizeInstrument1 = instrumentRepo.GetInstrumentsBySize("4");
                    break;
            }

            foreach (Instrument instrument in sizeInstrument1)
            {
                bool isItThere = false;
                foreach (Instrument j in sizeInstruments)
                {

                }
                if (!sizeInstruments.Contains(instrument))
                {
                    sizeInstruments.Add(instrument);
                }
     
            }*/
            return sizeInstruments;
        }

        public List<Instrument> InstrumentSelectForRange(Selection s)
        {
            string caseRange = s.PreferredRange;
            foreach(Instrument i in instrumentRepo.GetInstrumentsByRange(caseRange))
            {
                bool add = true;
                foreach (Instrument j in rangeInstruments)
                {
                    if (i.DescriptionText.Equals(j.DescriptionText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    rangeInstruments.Add(i);
                }
            }


            /* // Switch
            switch (caseRange)
            {
                case "0":
                    rangeInstrument1 = instrumentRepo.GetInstrumentsByRange("0");
                    break;
                case "1":
                    rangeInstrument1 = instrumentRepo.GetInstrumentsByRange("1");
                    break;
                case "2":
                    rangeInstrument1 = instrumentRepo.GetInstrumentsByRange("2");
                    break;
                case "3":
                    rangeInstrument1 = instrumentRepo.GetInstrumentsByRange("3");
                    break;
                case "4":
                    rangeInstrument1 = instrumentRepo.GetInstrumentsByRange("4");
                    break;
            }
            foreach (Instrument instrument in rangeInstrument1)
            {
                if (!rangeInstruments.Contains(instrument))
                {
                    rangeInstruments.Add(instrument);
                }
            } */
            return rangeInstruments;
        }

        public List<Instrument> InstrumentSelectForTone(Selection s)
        {
            String caseTone = s.PreferredTone;
            foreach (Instrument i in instrumentRepo.GetInstrumentsByTone(caseTone))
            {
                bool add = true;
                foreach (Instrument j in toneInstruments)
                {
                    if (i.DescriptionText.Equals(j.DescriptionText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    toneInstruments.Add(i);
                }
            }

            /*
            List<Instrument> toneInstrument1 = new List<Instrument>();
            // Switch
            switch (caseTone)
            {
                case "0":
                    toneInstrument1 = instrumentRepo.GetInstrumentsByTone("0");
                    break;
                case "1":
                    toneInstrument1 = instrumentRepo.GetInstrumentsByTone("1");
                    break;
                case "2":
                    toneInstrument1 = instrumentRepo.GetInstrumentsByTone("2");
                    break;
                case "3":
                    toneInstrument1 = instrumentRepo.GetInstrumentsByTone("3");
                    break;
                case "4":
                    toneInstrument1 = instrumentRepo.GetInstrumentsByTone("4");
                    break;
            }
            foreach (Instrument instrument in toneInstrument1)
            {
                if (!toneInstruments.Contains(instrument))
                {
                    toneInstruments.Add(instrument);
                }
            }*/
            return toneInstruments;
        }

        public List<Instrument> InstrumentSelectForTechnical(Selection s)
        {
            string caseTechnical = s.PreferredTechnical;
            foreach (Instrument i in instrumentRepo.GetInstrumentsByTechnical(caseTechnical))
            {
                bool add = true;
                foreach (Instrument j in technicalInstruments)
                {
                    if (i.DescriptionText.Equals(j.DescriptionText))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    technicalInstruments.Add(i);
                }
            }

            /*
            List<Instrument> technicalInstrument1 = new List<Instrument>();
            // Switch
            switch (caseTechnical)
            {
                case "0":
                    technicalInstrument1 = instrumentRepo.GetInstrumentsByTechnical("0");
                    break;
                case "1":
                    technicalInstrument1 = instrumentRepo.GetInstrumentsByTechnical("1");
                    break;
                case "2":
                    technicalInstrument1 = instrumentRepo.GetInstrumentsByTechnical("2");
                    break;
                case "3":
                    technicalInstrument1 = instrumentRepo.GetInstrumentsByTechnical("3");
                    break;
            }
            foreach (Instrument instrument in technicalInstrument1)
            {
                if (!technicalInstruments.Contains(instrument))
                {
                    technicalInstruments.Add(instrument);
                }
            } */
            return technicalInstruments;
        }
    }
}
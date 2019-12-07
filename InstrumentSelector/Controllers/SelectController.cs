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
        // Repository declaration
        ISelectionRepository repo;

        public SelectController(ISelectionRepository r)
        {
            repo = r;
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
            // repo.AddSelection(s);
            selection = s;
            return RedirectToAction("SelectionResult");
        }
        // Selection result
        public ViewResult SelectionResult()
        {
            resultText = ResultText(selection);
            return View(resultText);
        }
        private String ResultText(Selection s)
        {
            string size = s.PreferredSize;
            string range = s.PreferredRange;
            string tone = s.PreferredTone;
            string technical = s.PreferredTechnical;
            resultText = size + ", " + range + ", " + tone + ", " + technical;
            return resultText;
        }
    }
}
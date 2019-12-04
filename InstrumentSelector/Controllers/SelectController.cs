using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentSelector.Controllers
{
    public class SelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
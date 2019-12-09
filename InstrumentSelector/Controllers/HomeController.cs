using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InstrumentSelector.Models;
using InstrumentSelector.Repositories;

namespace InstrumentSelector.Controllers
{
    public class HomeController : Controller
    {
        // declaration of repo (works for both children)
        ICommentRepository repo;
        public HomeController(ICommentRepository r)
        {
            repo = r;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Instrument()
        {
            return View();
        }

        public ViewResult WoodwindInstrument()
        {
            return View();
        }
        public ViewResult BrassInstrument()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Comment()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Comment(Comment comment)
        {
            // stores contact messages
            comment.CommentTime = DateTime.Now;
            repo.AddComment(comment);
            return View();
        }
        // TODO : fetch comments
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

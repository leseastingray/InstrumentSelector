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

        //private static List<Comment> comments = new List<Comment>();
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
        [HttpGet]
        // TODO : fetch comments
        public ViewResult GetComments()
        {
            List<Comment>comments = repo.Comments;
            comments.Sort((c1, c2) => DateTime.Compare(c1.CommentTime, c2.CommentTime));
            return View(comments);
        }
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

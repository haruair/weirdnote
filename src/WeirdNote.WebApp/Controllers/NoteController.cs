using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WeirdNote.WebApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WeirdNote.WebApp.Controllers
{
    [Route("note")]
    public class NoteController : Controller
    {

        private NoteContext _context;

        public NoteController(NoteContext context) {
          _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return this.RedirectToAction("List");
        }

        [Route("list")]
        public IActionResult List()
        {
            return View(_context.Notes.ToList());
        }

        [Route("post")]
        [ActionName("NewPost")]
        public IActionResult Post()
        {
            return View("post");
        }

        [HttpPost]
        [Route("post")]
        [ActionName("SubmitPost")]
        public IActionResult Post(Note note)
        {
          if (ModelState.IsValid)
          {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return this.RedirectToAction("List");
          }

          return View(note);
        }

    }
}

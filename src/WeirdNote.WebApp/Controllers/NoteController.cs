using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WeirdNote.WebApp.Controllers
{
    [Route("note")]
    public class NoteController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("list")]
        public IActionResult List()
        {
            return View();
        }

        [Route("post")]
        public IActionResult Post()
        {
            return View();
        }

    }
}

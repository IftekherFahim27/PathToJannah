using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class NamesofAllahController : Controller
    {
        // GET: NamesofAllah
        PTJEntities db = new PTJEntities();
        public ActionResult Index()
        {
            List<Allah_name> An = db.Allah_name.ToList();
            return View(An);
        }
    }
}
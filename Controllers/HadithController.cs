using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class HadithController : Controller
    {
        // GET: Hadith
        PTJEntities database = new PTJEntities();
        public ActionResult Index()
        {
            List<Hadith> hadith = database.Hadiths.ToList();
            return View(hadith);
        }
    }
}
using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class SurahController : Controller
    {
        // GET: Surah
        PTJEntities db = new PTJEntities();
        public ActionResult Index()
        {
            List<Surah> surah = db.Surahs.ToList();
            return View(surah);
        }
    }
}
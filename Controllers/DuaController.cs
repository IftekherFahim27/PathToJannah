using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class DuaController : Controller
    {
        // GET: Dua
        PTJEntities database = new PTJEntities();
        public ActionResult Index()
        {
            List<Dua> dua = database.Duas.ToList();
            return View(dua);
        }
    }
}
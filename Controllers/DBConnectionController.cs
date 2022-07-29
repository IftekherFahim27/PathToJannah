using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class DBConnectionController : Controller
    {
        // GET: DBConnection
        PTJEntities db = new PTJEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}
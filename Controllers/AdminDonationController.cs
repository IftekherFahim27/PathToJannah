using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class AdminDonationController : Controller
    {
        // GET: AdminDonation
        PTJEntities db = new PTJEntities();
        public ActionResult Index()
        {
            List<Donation> donation = db.Donations.ToList();
            return View(donation);
        }
    }
}
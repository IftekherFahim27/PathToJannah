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

        [HttpGet]
        public ActionResult Index()
        {

            List<Donation> donation = db.Donations.Where(temp => temp.state == null).ToList();
            return View(donation);
        }

        [HttpPost]
        public ActionResult Index(Donation don)
        {

            don = db.Donations.Where(temp => temp.state ==null).FirstOrDefault();


            don.state = "Approved";

            db.SaveChanges();

            List<Donation> donation = db.Donations.Where(temp =>temp.state ==null).ToList();
            return View(donation);
           
        }

    }
   
}
using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class USerPendingDonationController : Controller
    {
        // GET: USerPendingDonation
        int us;
        [HttpGet]
        public ActionResult Index(PathToJannah.Models.Donation don)
        {
            using (PTJEntities db = new PTJEntities())
            {
                us = don.U_ID = (int)Session["U_ID"];
                List<Donation> donation = db.Donations.Where((x) => x.U_ID == us).ToList();
                return View(donation);
            }
               




          
        }


        
    }
}
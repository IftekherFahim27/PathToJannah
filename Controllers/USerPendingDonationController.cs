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
        public ActionResult Index()
        {

            Donation don = new Donation();
            us=don.U_ID = (int)Session["U_ID"];
            return View();
        }


        [HttpPost]
        public ActionResult Donation_info(PathToJannah.Models.Donation don)
        {
            using (PTJEntities db = new PTJEntities())
            {


                
               
                   // List<Donation> donation = db.Donations.ToList();
                    List<Donation> donation = db.Donations.Where((x) => x.U_ID ==us).ToList();
                    //var sql = "select T_ID,t_time,Amount from Donation where U_ID= {don.U_ID} ";
                   // List<Donation> donation = db.Donations.SqlQuery(sql).ToList();
                    return View(donation);
                




            }

        }
    }
}
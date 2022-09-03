using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class DonationController : Controller
    {
        // GET: Donation

        [HttpGet]
        public ActionResult Index()
        {
            

            Donation don=new Donation();
            don.U_ID =(int)Session["U_ID"];

            ViewBag.ID=don.U_ID;

            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Donation don)
        {
            using (PTJEntities dbModel = new PTJEntities())
            {
                if (dbModel.Donations.Any(x => x.T_ID == don.T_ID))
                {
                    ViewBag.TDuplicateMessage = "Transaction number already Exist";
                    return View("Index", don);
                }

              

                dbModel.Donations.Add(don);
                dbModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Donation  is PENDING....";
            
            return View("Index", new Donation());
        }

    }
}
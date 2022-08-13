using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class AdminLoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Admin_Authorize(PathToJannah.Models.Admin ad)
        {
            using (PTJEntities dba = new PTJEntities())
            {
                var adminDetails = dba.Admins.Where(x => x.email == ad.email && x.pass == ad.pass).FirstOrDefault();

                if (adminDetails == null)
                {
                    ad.LoginErrorMessage = "Wrong Email or Password";
                    return View("Index","AdminLogin");

                }
                else
                {
                    
                    
                        Session["Email"] = ad.email;
                        return RedirectToAction("Index", "DBConnection");
                    
                }
            }


            
        }

        public ActionResult LogOut()
        {
            string name = (string)Session["Username"];
            string mail = (string)Session["Email"];
            string mob = (string)Session["Mobile"];
            Session.Abandon();
            return RedirectToAction("Index", "AdminLogin");
        }
    }
}
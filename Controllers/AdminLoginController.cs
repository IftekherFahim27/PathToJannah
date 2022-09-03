using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
                    return View("Index",ad);

                }
                else
                {

                        
                        Session["Email"] = ad.email.ToString();
                        return RedirectToAction("Index", "DBConnection");
                    
                }
            }


            
        }

        public ActionResult LogOut()
        {
            //string name = (string)Session["Username"];
            string mail = (string)Session["Email"];
            // string mob = (string)Session["Mobile"];
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Session.Abandon();
            return RedirectToAction("Index", "AdminLogin");
        }
    }
}
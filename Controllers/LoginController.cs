using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(PathToJannah.Models.User usermodel)
        {
            using (PTJEntities db = new PTJEntities())
            {
                var userDetails = db.Users.Where(x => x.Email == usermodel.Email && x.Pass == usermodel.Pass).FirstOrDefault();
                if (userDetails == null)
                {
                    usermodel.LoginErrorMessage = "Wrong UserName or Password";
                    return View("Index", usermodel);

                }
                else
                {
                    Session["U_ID"] = userDetails.U_ID;
                    Session["Username"] = userDetails.Name;
                    Session["Email"] = userDetails.Email;
                    Session["Mobile"] = userDetails.Mobile;
                    return RedirectToAction("Index", "UserHome");
                }
            }

        }  
        
        

        public ActionResult LogOut()
        {
            string name =(string) Session["Username"];
            string mail =(string) Session["Email"];
            string mob =(string) Session["Mobile"];
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

    }
}
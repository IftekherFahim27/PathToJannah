using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PathToJannah.Models;

namespace PathToJannah.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            User userModel=new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddorEdit(User userModel)
        {
            using ( PTJEntities dbModel = new PTJEntities())
            {
                if (dbModel.Users.Any(x=> x.Mobile == userModel.Mobile))
                {
                    ViewBag.MDuplicateMessage = "Mobile Number Already Exist";
                    return View("AddorEdit",userModel);
                }

                if (dbModel.Users.Any(x => x.Email == userModel.Email))
                {
                    ViewBag.EDuplicateMessage = "Email is Already Exist";
                    return View("AddorEdit", userModel);
                }

                dbModel.Users.Add(userModel);
                dbModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration is Successful";
            return View("AddorEdit", new User());
        }
    }
}
using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class UserHomeController : Controller
    {
        // GET: UserHome
        [HttpGet]
        public ActionResult Index()
       {
            User us = new User();
            us.U_ID = (int)Session["U_ID"];

            ViewBag.ID = us.U_ID;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Blog bl)
        {
            
            using (PTJEntities dbModel = new PTJEntities())
            {
               /* if (dbModel.Blogs.Any(x => x.Post== bl.Post))
                {
                    ViewBag.TDuplicateMessage = "Post  is already Exist";
                    return View("Index", bl);
                }*/



                dbModel.Blogs.Add(bl);
                dbModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Post approved Successfully";

            return View("Index", new Blog());
        }
    }
}
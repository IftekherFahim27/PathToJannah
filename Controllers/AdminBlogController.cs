using PathToJannah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PathToJannah.Controllers
{
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        PTJEntities db = new PTJEntities();
        public ActionResult Index()
        {
            List<Blog> blog = db.Blogs.ToList();
            return View(blog);
        }
    }
}
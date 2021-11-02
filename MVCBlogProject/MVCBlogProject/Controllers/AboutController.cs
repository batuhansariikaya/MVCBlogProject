using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.Models;
namespace MVCBlogProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();

        public ActionResult Index()
        {
            var about = context.Abouts.ToList();
            return View(about);
        }
        public ActionResult AboutEdit()
        {
            var about = context.Abouts.ToList();
            return View(about);
        }

        public ActionResult GetAbout(int id)
        {
            var getabout = context.Abouts.Find(id);
            return View("GetAbout", getabout);
        }

        public ActionResult AboutUpdate(About about)
        {
            var update = context.Abouts.Find(about.AboutID);
            update.AboutID = about.AboutID;
            update.ImageURL = about.ImageURL; ;
            update.AboutStatus = about.AboutStatus;
            
            update.AboutDescription = about.AboutDescription;
            context.SaveChanges();
            return RedirectToAction("AboutEdit");

        }

    }
}
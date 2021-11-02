using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.Models;
namespace MVCBlogProject.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        // GET: Statistics
        [Authorize]
        public ActionResult Index()
        {
            var totalcategory = context.Categories.Count();
            ViewBag.totalcategorycount = totalcategory; 

            var totalblog = context.Blogs.Count();
            ViewBag.totalblogcount = totalblog; 

            var mosttitles = context.Blogs.Max(x => x.Category.CategoryID);
            ViewBag.categorynamewiththemosttitle = mosttitles; 

            var categoryStatusTrue = context.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.activecategories = categoryStatusTrue; 

            var categoryStatusFalse = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.pasifcategories = categoryStatusFalse; 

            var blogStatusTrue = context.Blogs.Count(x => x.BlogStatus == true);
            ViewBag.activeblogs = blogStatusTrue ;

            var blogStatusFalse = context.Blogs.Count(x => x.BlogStatus == false);
            ViewBag.pasifblogs = blogStatusFalse;

            var totalcomment = context.Comments.Count();
            ViewBag.totalcommentcount = totalcomment;

            var totalmessage = context.Contacts.Count();
            ViewBag.totalmessagecount = totalmessage;

            var mostblogs = context.Comments.Max(x => x.Blog.BlogID);
            ViewBag.blogsheading = mostblogs;

            return View();
        }
    }
}
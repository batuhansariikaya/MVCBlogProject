using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.Models;
using PagedList;
using PagedList.Mvc;
namespace MVCBlogProject.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context context = new Context();
        MultipleClass multiple = new MultipleClass();
        public ActionResult Index(string search)
        {
            //var value = from d in context.Blogs select d;
            multiple.value1 = context.Blogs.OrderByDescending(x => x.BlogID).ToList();
            multiple.value3 = context.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            multiple.value5 = context.Categories.ToList();
            return View(multiple);
        }
       
        public ActionResult BlogDetails(int id)
        {
            multiple.value1 = context.Blogs.Where(x => x.BlogID == id).ToList();
            multiple.value2 = context.Comments.Where(x => x.BlogID == id).ToList();
            return View(multiple);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }
        public ActionResult Page404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}
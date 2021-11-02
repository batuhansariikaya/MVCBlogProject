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
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        
        [Authorize]
        public ActionResult Index(int page=1)
        {
            var totalblog = context.Blogs.Count();
            ViewBag.totalblogcount = totalblog;
            var values = context.Blogs.ToList().ToPagedList(page,7);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();                         
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("/Index");
        }
        public ActionResult BlogDelete(int id)
        {
            var delete = context.Blogs.Find(id);
            context.Blogs.Remove(delete);
            //delete.BlogStatus = false;
            context.SaveChanges();
            return RedirectToAction("/Index");
        }
        public ActionResult GetBlog(int id)
        {
            List<SelectListItem> category = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v2 = category;
            var getblog = context.Blogs.Find(id);
            return View("GetBlog",getblog);
        }
        public ActionResult BlogUpdate(Blog blog)
        {
            var update = context.Blogs.Find(blog.BlogID);
            update.BlogHeading = blog.BlogHeading;
            update.BlogDescription = blog.BlogDescription;
            update.Date = blog.Date;
            update.BlogImage = blog.BlogImage;
            update.CategoryID = blog.CategoryID;
            update.BlogStatus = blog.BlogStatus;
            context.SaveChanges();
            return RedirectToAction("/Index");

        }
        [Authorize]
        public ActionResult CommentList(int page=1) 
        {
            var values = context.Comments.ToList().ToPagedList(page,7);
            return View(values);
        }
        public ActionResult CommentDelete(int id)
        {
            var delete = context.Comments.Find(id);
            context.Comments.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult CommentUpdate()
        {
            return View();
        }
    }
 }
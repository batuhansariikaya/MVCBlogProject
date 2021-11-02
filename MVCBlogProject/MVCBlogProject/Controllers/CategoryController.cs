using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.Models;
namespace MVCBlogProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context context = new Context();
        MultipleClass multiple = new MultipleClass();
        [Authorize]
        public ActionResult Index()
        {
            //List<SelectListItem> data = new List<SelectListItem>();
            //data.Add(new SelectListItem
            //{
            //    Text = "Aktif",
            //    Value = "true"
            //});
            //data.Add(new SelectListItem
            //{
            //    Text = "Pasif",
            //    Value="false"
            //});
            //ViewData["data"] = data;


            var content = context.Categories.ToList();
            return View(content);
        }
        [HttpGet]
        public ActionResult NewCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CategoryDelete(int id)
        {
            var delete = context.Categories.Find(id);
            context.Categories.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCategory(int id)
        {
            var getcategory = context.Categories.Find(id);
            return View("GetCategory", getcategory);
        }
        public ActionResult CategoryUpdate(Category category)
        {
            var update = context.Categories.Find(category.CategoryID);
            update.CategoryName = category.CategoryName;
            update.CategoryStatus = category.CategoryStatus;
            update.CategoryID = category.CategoryID;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
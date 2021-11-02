using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogProject.Models;

namespace MVCBlogProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context context = new Context();
        [HttpGet]
       
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult Message()
        {
            var contact = context.Contacts.ToList();
            return View(contact);
        }
    }
}
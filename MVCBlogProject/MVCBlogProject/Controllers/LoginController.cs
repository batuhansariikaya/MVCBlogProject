using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVCBlogProject.Models;
namespace MVCBlogProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();   
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Admin admin)
        {
            var admininfo = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.UserName, false);
                Session["UserName"] = admininfo.UserName.ToString();
                return RedirectToAction("/Index","Admin");
            }
            else
            {
                
                return View();
            }
          
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("SignIn","Login");
        }
    }
}
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcPROJEKampp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        WriterLoginManager wm = new WriterLoginManager(new EFWriterDAL());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var AdminUserInfo = c.Admins.FirstOrDefault(x=> x.AdminUserName==p.AdminUserName && x.AdminPassword==p.AdminPassword);
            if (AdminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(AdminUserInfo.AdminUserName, false);
                Session["AdminUserName"]=AdminUserInfo.AdminUserName;
                return RedirectToAction("Index","AdminCategory");


            }

            else
            {
                return RedirectToAction("Index");

            }

         
        
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer p)
        {
            //Context c = new Context();
            //var WriterUserInfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            //if (WriterUserInfo != null)

            var WriterUserInfo = wm.GetWriter(p.WriterMail, p.WriterPassword);
            if (WriterUserInfo != null) 
            {
                FormsAuthentication.SetAuthCookie(WriterUserInfo.WriterMail, false);
                Session["WriterMail"] = WriterUserInfo.WriterMail;
                return RedirectToAction("MyContent", "WriterPanelContent");

            }

        
                
            else
            {
                return RedirectToAction("WriterLogin");

            }
        }

        public ActionResult LogOut()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Headings", "Default");

        }

    }
}
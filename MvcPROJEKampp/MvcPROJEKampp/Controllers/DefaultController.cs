using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPROJEKampp.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        HeadingManager hm= new HeadingManager(new EFHedaingDAL());
        ContentManager cm = new ContentManager(new EFContentDAL());

        public ActionResult Headings()
        {
            var HeadingList = hm.GetList();
            return View(HeadingList);
        }
    

        public PartialViewResult Index(int id=0)
        {
            var contentlist = cm.GetListByHeadingID(id);
            return PartialView(contentlist);
        }
    }
}
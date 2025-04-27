using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPROJEKampp.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery

        ImageFileManager Ifm = new ImageFileManager(new EFImageDAL());
        public ActionResult Index()
        {
            var files = Ifm.List();
            return View(files);
        }
    }
}
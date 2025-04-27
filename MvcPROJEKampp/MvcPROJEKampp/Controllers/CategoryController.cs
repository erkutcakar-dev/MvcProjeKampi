using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidatior;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcPROJEKampp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult GetCategoryList()
        {
         var CategoryValues = cm.GetList();
            return View(CategoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)

        {          
            CategoryValidator categoryValidator = new CategoryValidator();
                              
            return RedirectToAction("GetCategoryList");

        }




}

}

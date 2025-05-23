﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MvcPROJEKampp.Controllers
{
    public class WriterPanelController : Controller
    {

        HeadingManager hm = new HeadingManager(new EFHedaingDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        WriterManager wm= new WriterManager(new  EFWriterDAL());
        Context c = new Context();
        int id;
        [HttpGet]
        public ActionResult WriterProfile(int id = 0)
        {
            string p = (string)Session["WriterMail"];
            id = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
            var writervalue = wm.GetByID(id);
            return View(writervalue);
        }

        [HttpPost]
        public ActionResult WriterProfile(Writer p)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriterUpdate(p);
                return RedirectToAction("AllHeading", "WriterPanel");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        public ActionResult MyHeading(string p)

        {
            
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x=> x.WriterMail==p).Select(y=> y.WriterID).FirstOrDefault();
            var values = hm.GetListByWriter(writeridinfo);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {

            

            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }).ToList();

            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            string WriterMailInfo = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterImage == WriterMailInfo).Select(y => y.WriterID).FirstOrDefault();

            p.HeadingDate = DateTime.Parse(DateTime.Now.ToLongDateString());

            p.WriterID = writeridinfo;
            p.HeadingStatus=true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
            
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {

            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            var HeadingValue = hm.GetByID(id);
            return View(HeadingValue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("MyHeading");

        }

        public ActionResult DeleteHeading(int id)
        {
            var headingvalues = hm.GetByID(id);
            if (headingvalues.HeadingStatus == true)
            {
                headingvalues.HeadingStatus = false;
                hm.HeadingDelete(headingvalues);
            }
            else
            {
                headingvalues.HeadingStatus = true;
                hm.HeadingDelete(headingvalues);
            }
            return RedirectToAction("MyHeading");

        }

        public ActionResult AllHeading(int p=1)
        { 
            
            var headings = hm.GetList().ToPagedList(p,4);
            return View(headings); 
        }




    }

  
}



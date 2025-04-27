using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;


namespace MvcPROJEKampp.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDAL());
        MessageValidator MessageValidator = new MessageValidator();

        public ActionResult Inbox()

        {

            string p = (string)Session["WriterMail"];           
            var messagelistin = mm.GetListInbox(p);           
            return View(messagelistin);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
            

        }
        public ActionResult SendBox()
        {
            string p = (string)Session["WriterMail"];
            var messagelistsend = mm.GetListSendBox(p);
            return View(messagelistsend);
        }

        public ActionResult GetInBoxMessage(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendBoxMessage(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult result = MessageValidator.Validate(p);
            if (result.IsValid)
            {

                p.SenderMail = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }



    }


}


 //< customErrors mode = "On" >

 //         < error statusCode = "404" redirect = "/ErrorPage/Page404" ></ error >

 //     </ customErrors >

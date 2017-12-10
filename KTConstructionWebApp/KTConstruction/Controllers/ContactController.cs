using KTConstruction.Model.Data;
using KTConstruction.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTConstruction.Controllers
{
    public class ContactController : Controller
    {
        private IMailModel _mailModel;

        public ContactController()
        {
            this._mailModel = new MailModel();
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost, ValidateInput(true)]
        public ActionResult SendMail()
        {
            NameValueCollection nvc = Request.Form;
            string emailFrom = nvc["emailFrom"];
            string emailContent = nvc["emailContent"];
            bool status = this._mailModel.SendMail(emailFrom, emailContent);
            return Json(new
            {
                status = status
            }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Index", "Contact");
        }
    }
}
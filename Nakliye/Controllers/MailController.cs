using Nakliye.BLL;
using Nakliye.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Nakliye.Controllers
{
    public class MailController : Controller
    {
        MailBLL mailBLL = new MailBLL();
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Ad: " + model.FirstName);
                body.AppendLine("Soyad: " + model.LastName);
                body.AppendLine("Firma Adı: " + model.FirmaAdi);
                body.AppendLine("E-Mail Adresi: " + model.Email);
                body.AppendLine("Konu: " + model.Subject);
                body.AppendLine("Mesaj: " + model.Message);
                mailBLL.MailSender(body.ToString());
                ViewBag.Success = true;
            }
            return View();
        }


    }
}
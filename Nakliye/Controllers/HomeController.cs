using Nakliye.BLL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nakliye.Controllers
{
    public class HomeController : Controller
    {
        NakliyeciBLL nakliyeciBLL = new NakliyeciBLL();

        public ActionResult Index()
        {
            List<Nakliyeciler> nakliyeciler = nakliyeciBLL.GetNakliyecilers();
            return View(nakliyeciler);
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        //public ActionResult GirisYap()
        //{
        //    return View();
        //}

        //public ActionResult KayıtOl()
        //{       
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult KayıtOl(Musteriler musteri)
        //{
        //    MusteriBLL musteribll = new MusteriBLL();
        //    musteribll.AddCustomers(musteri);
        //    return RedirectToAction("Index");
        //}

    }
}
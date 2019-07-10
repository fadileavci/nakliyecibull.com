using Nakliye.BLL;
using Nakliye.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nakliye.Controllers
{
    public class NakliyeciController : Controller
    {
        // GET: Nakliye
        NakliyeciBLL nakliyecilerbll = new NakliyeciBLL();

        #region nakliyecileri listele ve nakliyeci ekle metodları
        public ActionResult Getir()
        {
            List<Nakliyeciler> nakliyeciler = nakliyecilerbll.GetNakliyecilers();
            return View(nakliyeciler);
        }
        #endregion
        public ActionResult NakliyeciDetay(int id)
        {
            Nakliyeciler nakliyeci= nakliyecilerbll.GetNakliyeci(id);

            return View(nakliyeci);
        }

    }
}
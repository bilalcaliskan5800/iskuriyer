using iskuriyer.BusinessLayer;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iskuriyer.Controllers
{
    public class BusinessManController : Controller
    {
        BusinessManagerBLL bm = new BusinessManagerBLL();
        
        [HttpPost]
        public ActionResult InsertBussines(Sirket sirket)
        {
            Sirket sir = new Sirket();
            sir.EPosta = sirket.EPosta;
            sir.Il = sirket.Il;
            sir.Ilce = sirket.Ilce;
            sir.KullaniciAdi = sirket.KullaniciAdi;
            sir.Sifre = sirket.Sifre;
            sir.SirketAdi = sirket.SirketAdi;
            sir.Telefon = sirket.Telefon;
            sir.YetkiliAdiSoyadi = sirket.YetkiliAdiSoyadi;
            bm.InsertBusiness(sir);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult LoginBussines(Sirket sirket)
        {
            Sirket sir = bm.GetSirket(sirket.KullaniciAdi);
            if (sir.Sifre==sirket.Sifre)
            {
                Session["SirketLogin"] = sir;

            }

            return RedirectToAction("Index","Home");
        }
    }
}
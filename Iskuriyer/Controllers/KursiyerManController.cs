using iskuriyer.BusinessLayer;
using iskuriyer.Entity;
using Iskuriyer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iskuriyer.Controllers
{
    public class KursiyerManController : Controller
    {
        KursiyerManagerBLL km = new KursiyerManagerBLL();
        KursiyerIletisimManagerBLL kim = new KursiyerIletisimManagerBLL();
        // GET: KursiyerMan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertKursiyer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertKursiyer(Kursiyer kursiyer,Kursiyer_Iletisim kursiyer_Iletisim)
        {
            Kursiyer kur = new Kursiyer();
            Kursiyer_Iletisim ki = new Kursiyer_Iletisim();
            kur.Adi = kursiyer.Adi;
            kur.Soyadi = kursiyer.Soyadi;
            kur.Sifre = kursiyer.Sifre;
            kur.DogumTarihi = kursiyer.DogumTarihi;
            ki.TelefonNo = kursiyer_Iletisim.TelefonNo;
            ki.EPosta = kursiyer_Iletisim.EPosta;
            km.InsertKursiyer(kur);
            int id=kur.ID;
            ki.KursiyerID = id;
            kim.KursiyerIletisimInsert(ki);
            
            return RedirectToAction("Index", "Home");
        }


        public ActionResult KursiyerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KursiyerLogin(Kursiyer kursiyer)
        {

            Kursiyer kur = km.GetKursiyer(kursiyer.Adi);
            if (kur.Sifre==kursiyer.Sifre)
            {
                Session["KursiyerLogin"]=kur;


            }
            return RedirectToAction("Index","Home");
        }



    }
}
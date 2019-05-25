using iskuriyer.BusinessLayer;
using iskuriyer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iskuriyer.Controllers
{
    public class HomeController : Controller
    {
        IllerManager illerManager = new IllerManager();
        public ActionResult Index()
        {
            List<Iller> Iller = illerManager.GetIller();
            Session["Iller"] = Iller;
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult LogOut()
        {

            if (Session["KursiyerLogin"]!=null)
            {
                Session["KursiyerLogin"] = null;

            }
            else if (Session["SirketLogin"]!=null)
            {
                Session["SirketLogin"] = null;

            }
            return RedirectToAction("Index");
        }
    }
}
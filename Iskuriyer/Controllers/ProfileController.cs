using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iskuriyer.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult UserDash()
        {
            return View();
        }

        public ActionResult BusinessProfile()
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }
    }
}
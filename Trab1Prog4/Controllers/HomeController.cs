using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trab1Prog4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
    }
}
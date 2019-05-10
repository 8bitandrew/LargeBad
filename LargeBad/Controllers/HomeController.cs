using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LargeBad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to The Large Bad!";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            ViewData["Message"] = "Just as soon as I get SSL and a secure DB.";

            return View();
        }

        public ActionResult Login()
        {
            ViewData["Message"] = "Also, just as soon as I get SSL and a secure DB.";

            return View();
        }

        public ActionResult Downloads()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }
    }
}
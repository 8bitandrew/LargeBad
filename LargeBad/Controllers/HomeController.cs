using LargeBad.Models;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public ActionResult Login(string returnUrl)
        {
            HttpContext.GetOwinContext().Authentication.Challenge(new AuthenticationProperties
            {
                RedirectUri = returnUrl ?? Url.Action("Index", "Home")
            },
            "Auth0");
            return new HttpUnauthorizedResult();
        }

        [Authorize]
        public void Logout()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            HttpContext.GetOwinContext().Authentication.SignOut("Auth0");
        }

        [Authorize]
        public ActionResult Claims()
        {
            return View();
        }

        [Authorize]
        public ActionResult UserProfile()
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;

            return View(new UserProfileViewModel()
            {
                Name = claimsIdentity?.FindFirst(c => c.Type == claimsIdentity.NameClaimType)?.Value,
                EmailAddress = claimsIdentity?.FindFirst(c => c.Type == ClaimTypes.Email)?.Value,
                ProfileImage = claimsIdentity?.FindFirst(c => c.Type == "picture")?.Value,
                Username = claimsIdentity?.FindFirst(c => c.Type == "username")?.Value
            });
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
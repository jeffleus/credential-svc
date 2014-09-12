using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CredentialSVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            CredentialSVC.Models.Credentials.CredentialContext ctx = new Models.Credentials.CredentialContext();
            ViewBag.Events = ctx.Events;

            return View();
        }
    }
}

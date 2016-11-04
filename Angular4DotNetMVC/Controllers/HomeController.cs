using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string naam = "Pierre";

            return View("Index","",naam);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
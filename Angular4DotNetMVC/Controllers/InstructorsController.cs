using Angular4DotNetMVC.Models.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular4DotNetMVC.Controllers
{
    public class InstructorsController : Controller
    {
        // GET: Instructors
        public ActionResult Index()
        {
            return View("Index", "", RegistrationVmBuilder.GetSerializedInstructorVms());
        }

        public ActionResult Print()
        {
            var banaan = "banaan";
            var s = banaan.Equals("banaan") ? "banaan " + banaan : "geen banaan";
            return View("Print",s);
        }

    }
}
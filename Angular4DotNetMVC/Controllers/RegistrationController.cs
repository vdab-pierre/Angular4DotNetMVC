using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMVC.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        //wijziging in branch withajax?
        public ActionResult Index()
        {
            return View(RegistrationVmBuilder.BuidRegistrationVm());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMVC.Controllers
{
    public class InstructorsController : Controller
    {
        // GET: Instructors
        public ActionResult Index()
        {
            return Json(RegistrationVmBuilder.GetInstructorVms(), JsonRequestBehavior.AllowGet);
        }
    }
}
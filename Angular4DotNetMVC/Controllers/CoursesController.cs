using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMVC.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return Json(RegistrationVmBuilder.GetCourseVms(),JsonRequestBehavior.AllowGet);
        }
    }
}
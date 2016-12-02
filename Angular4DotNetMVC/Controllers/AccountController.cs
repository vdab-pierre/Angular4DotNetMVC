using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMVC.Models.Student;

namespace Angular4DotNetMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Save(StudentVm student)
        {
            //registration in db etc?
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}
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
            //do whatever you should do with the student to save it

            return new HttpStatusCodeResult(HttpStatusCode.GatewayTimeout);
        }
    }
}
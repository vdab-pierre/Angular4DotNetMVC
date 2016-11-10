using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Angular4DotNetMVC.Models.Courses;
using Angular4DotNetMVC.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "", RegistrationVmBuilder.GetSerializedCourseVms());
        }
    }
}

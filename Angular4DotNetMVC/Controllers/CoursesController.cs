using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Angular4DotNetMVC.Models;

namespace Angular4DotNetMVC.Controllers
{
    public class CoursesController : Controller
    {
        private static RegistrationVm _registrationVms = new RegistrationVm {
            Courses = new List<Course>
            {
                new Course { Number= "CREA101",Name= "Careofmagicalcreatures",Instructor= "RubeusHagrid"},
                new Course { Number= "DARK502",Name= "DefenceagainstdarkArts",Instructor= "SeverusSnape"},
                new Course { Number= "TRAN201",Name= "Transfiguration",Instructor= "MinervaMcGonagall"}
            },
            Instructors=new List<Instructor>
            {
                new Instructor() {Voornaam="Rubeus",Familienaam="Hagrid" },
                new Instructor() {Voornaam="Severus",Familienaam="Snape" },
                new Instructor() {Voornaam="Minerva",Familienaam="McGonagall" }
            }
        };

        // GET: Courses
        public ActionResult Index()
        {
            return View("Index", "", _registrationVms);
        }

        

        private string GetSerializedCourseVms()
        { 
            var settings = new JsonSerializerSettings {ContractResolver= new CamelCasePropertyNamesContractResolver()};
            return JsonConvert.SerializeObject(_registrationVms, Formatting.None, settings);
        }
    }  
}
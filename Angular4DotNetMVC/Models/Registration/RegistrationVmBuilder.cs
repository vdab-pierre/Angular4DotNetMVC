using Angular4DotNetMVC.Models.Courses;
using Angular4DotNetMVC.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular4DotNetMVC.Models.Registration
{
    public static class RegistrationVmBuilder
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        public static string GetSerializedCourseVms()
        {
            var courses = new[]
                {
                    new CourseVm {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                    new CourseVm { Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                    new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"},
                };
            
            return JsonConvert.SerializeObject(courses, Formatting.None, _settings);
        }
        public static string GetSerializedInstructorVms()
        {
            var instructors = new []
                {
                    new InstructorVm {Name="Rubeus Hagrid",Email="hagrid@hogwarts.com",RoomNumber=1001 },
                    new InstructorVm {Name="Severus Snape",Email="severus@hogwarts.com",RoomNumber=105 },
                    new InstructorVm {Name="Minerva McGonnal",Email="minerva@hogwarts.com",RoomNumber=102}
                };
            
            return JsonConvert.SerializeObject(instructors, Formatting.None, _settings);
        }
        
    }
}
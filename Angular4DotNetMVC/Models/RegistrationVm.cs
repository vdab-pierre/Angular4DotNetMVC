using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular4DotNetMVC.Models
{
    public class RegistrationVm
    {

        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Instructor> Instructors { get; set; }

    }
}
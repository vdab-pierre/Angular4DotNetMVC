using Angular4DotNetMVC.Models.Courses;
using Angular4DotNetMVC.Models.Instructors;

namespace Angular4DotNetMVC.Models.Registration
{
    public static class RegistrationVmBuilder
    {
        
        public static CourseVm[] GetCourseVms()
        {
            var courses = new[]
                {
                    new CourseVm {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                    new CourseVm { Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                    new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"},
                };
            
            return courses;
        }
        public static InstructorVm[] GetInstructorVms()
        {
            var instructors = new []
                {
                    new InstructorVm {Name="Rubeus Hagrid",Email="hagrid@hogwarts.com",RoomNumber=1001 },
                    new InstructorVm {Name="Severus Snape",Email="severus@hogwarts.com",RoomNumber=105 },
                    new InstructorVm {Name="Minerva McGonnal",Email="minerva@hogwarts.com",RoomNumber=102}
                };
            
            return instructors;
        }
    }
}
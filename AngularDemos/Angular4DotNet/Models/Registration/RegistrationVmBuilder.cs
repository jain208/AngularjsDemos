﻿using Angular4DotNet.Models.Courses;
using Angular4DotNet.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular4DotNet.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CourseVm[] GetCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number= "1", Name = "C#", Instructor= "Scott Allen"},
                new CourseVm {Number= "2", Name = "Angularjs", Instructor= "Joe Eames"},
                new CourseVm {Number= "3", Name = "Javascript", Instructor= "Elijah Manor"}
            };
            return courses;
        }

        public InstructorVm[] GetInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "Scott Allen", Email="ScottAllen@gmail.com", RoomNumber="101"},
                new InstructorVm {Name = "Joe Eames", Email= "JoeEames@gmail.com", RoomNumber="102"},
                new InstructorVm {Name = "Elijah Manor", Email= "ElijahManor@gmail.com", RoomNumber="103"}
            };
            return instructors;
        }
    }
}
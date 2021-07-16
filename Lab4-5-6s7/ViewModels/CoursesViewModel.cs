using Lab4_5_6s7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_5_6s7.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}
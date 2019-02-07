using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehrendLearningSystem.Models
{
    public class Course
    {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }

        public List<Module> modules { get; set; }

    }
}
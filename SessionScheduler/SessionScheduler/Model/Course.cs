using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionScheduler.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string CoachName { get; set; }
    }
}

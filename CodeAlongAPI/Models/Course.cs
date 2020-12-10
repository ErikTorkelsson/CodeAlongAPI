using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlongAPI.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string level { get; set; }

        public int? TeacherID { get; set; }

        public Teacher Teacher { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}

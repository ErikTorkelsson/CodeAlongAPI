﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlongAPI.Models
{
    public class StudentCourse
    {
        public int StudentID { get; set; }

        public int CourseID { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}

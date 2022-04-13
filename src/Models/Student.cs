
using System;
using System.Collections.Generic;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
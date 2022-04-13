
using System.Collections.Generic;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students{ get; set; }
    }
}
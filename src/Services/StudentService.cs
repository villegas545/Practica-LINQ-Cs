using EFAndLinqPractice_SchoolAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
            return student;
        }

        public Student GetById(int id)
        {
         return _dbContext.Students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            return _dbContext.Students.Where(s => s.Courses.Any(c => c.Id == courseId));
        }

        public void DeleteById(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(s => s.Id == id);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();
        }
    }
}
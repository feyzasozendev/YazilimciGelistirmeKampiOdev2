using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {
            courses = new List<Course>
            {
                new Course { CourseId = 1, CourseName = "C# + Angular", Description = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)",CategoryId=1, InstructorId=1},
                new Course { CourseId = 2, CourseName = "Javascript", Description = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId=1, InstructorId=1},
                new Course { CourseId = 3, CourseName = "Java + React", Description = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId=1, InstructorId=1},
                new Course { CourseId = 4, CourseName = ".Net", Description = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId=1, InstructorId=1}
            };
        }


        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course productToDelete = courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courses.Remove(productToDelete);
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            Course courseToUpdate = courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.Description = course.Description;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
        }
    }
}

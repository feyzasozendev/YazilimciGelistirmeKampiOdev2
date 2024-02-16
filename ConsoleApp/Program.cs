using Business.Concrete;
using DataAccess.Concrete;

CourseManager coursesManager = new CourseManager(new EfCourseDal());
foreach(var course in coursesManager.GetAll())
{
    Console.WriteLine(course.CourseName);
}

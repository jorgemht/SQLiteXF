
namespace SQLite.Services.Courses
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Student;

    public class CoursesService : ICoursesService
    {
        public Task<List<Course>> GetAllCourses()
        {
            throw new System.NotImplementedException();
        }

        public Task<Course> GetCourseById(int courseId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Course> LookForCourse(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}
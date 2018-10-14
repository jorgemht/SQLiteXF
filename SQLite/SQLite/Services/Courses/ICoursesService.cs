namespace SQLite.Services.Courses
{
    using Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICoursesService
    {
        Task<Course> GetCourseById(int courseId);
        Task<List<Course>> GetAllCourses();
        Task<Course> LookForCourse(string query);
    }
}

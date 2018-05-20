namespace SQLite.Services.Student
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICourse
    {
        Task<Course> GetCourseById(int courseId);
        Task<List<Course>> GetAllCourses();
        Task<Course> LookForCourse(string query);
    }
}

namespace SQLite.Services.Student
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public interface IStudent
    {
        Task<Student> GetStudentById(int studentId);
        Task<List<Student>> GetAllStudents();
        Task<Student> LookForStudent(string query);
    }
}

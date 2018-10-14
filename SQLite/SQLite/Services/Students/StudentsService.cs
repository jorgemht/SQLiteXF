namespace SQLite.Services.Student
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public class StudentsService : IStudentsService
    {
        public Task<List<Student>> GetAllStudents()
        {
            throw new System.NotImplementedException();
        }

        public Task<Student> GetStudentById(int studentId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Student> LookForStudent(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}
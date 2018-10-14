namespace SQLite.Services.Student
{
    using Exceptions;
    using System;
    using Request;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public class StudentsService : IStudentsService
    {
        readonly IRequestService _requestService;

        public StudentsService(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public Task<IEnumerable<Student>> GetAllStudents()
        {
            var builder = new UriBuilder(AppSettings.defaulStudentsFileUrl);
            builder.AppendToPath("cities");

            var uri = builder.ToString();

            return _requestService.GetAsync<IEnumerable<Student>>(uri);
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
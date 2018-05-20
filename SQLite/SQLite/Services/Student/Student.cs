namespace SQLite.Services.Student
{
    using System.Collections.Generic;
    using Helper;
    using System.Threading.Tasks;

    public class Student : ApiService, IStudent
    {
        public Student()
        {
            accessToken = Settings.AccessToken;
            accessTokenType = Constants.accessTokenType;
            UrlApi = Constants.apiUrl;
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            var result = await Get<Student>(Constants.v1 + "/Students/"+ studentId);

            return (Student)result.Result;
        }

        public async Task<Student> LookForStudent(string name)
        { 
            var result = await Get<Student>(Constants.v1 + "/Students/"+ name);

            return (Student)result.Result;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var result = await GetList<Student>(Constants.v1 + "/Students");

            return (List<Student>)result.Result;
        }
    }
}
namespace SQLite.Services.Student
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Helper;

    public class Course : ApiService, ICourse
    {
        public Course()
        {
            accessToken = Settings.AccessToken;
            accessTokenType = Constants.accessTokenType;
            UrlApi = Constants.apiUrl;
        }

        public async Task<Course> GetCourseById(int courseId)
        {
            var result = await Get<Course>(Constants.v1 + "/Students/"+courseId);

            return (Course)result.Result;
        }

        public async Task<Course> LookForCourse(string name)
        {
            var result = await Get<Course>(Constants.v1 + "/Students/"+name);

            return (Course)result.Result;
        }

        public async Task<List<Course>> GetAllCourses()
        {
            var result = await GetList<Course>(Constants.v1 + "/Students");

            return (List<Course>)result.Result;
        }
    }
}
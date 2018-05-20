namespace SQLite.Services
{
    using Model;
    using System.Threading.Tasks;

    public interface IHttpService
    {
        Task<Response> Get<T>(string query);
        Task<Response> GetList<T>(string query);
        Task<Response> Post<T>(string query, T model);
        Task<Response> Post<T, TR>(string query, T model);
        Task<Response> PostsList<T>(string query, T model);
        Task<Response> PostsList<T, TR>(string query, T model);
    }
}

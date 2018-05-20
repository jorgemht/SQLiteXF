using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLite.Storage
{
    public interface IDataStorage
    {
        #region Methods async
        Task DeleteAsync<T>(T model) where T : class, IKeyObject, new();
        Task SaveValueAsync<T>(T model, bool overrideIfExists) where T : class, IKeyObject, new();
        Task<List<T>> GetAllItemsAsync<T>() where T : class, IKeyObject, new();
        Task<T> GetItemAsync<T>(string id) where T : class, IKeyObject, new();
        Task SaveAllAsync<T>(IEnumerable<T> values, bool overrideIfExists = true) where T : class, IKeyObject, new();
        #endregion

    }
}

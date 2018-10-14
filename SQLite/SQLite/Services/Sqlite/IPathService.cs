namespace SQLite.Services.Sqlite
{
    public interface IPathService
    {
        SQLiteAsyncConnection GetAsyncConnection();
        SQLiteConnection GetConnection();
    }
}

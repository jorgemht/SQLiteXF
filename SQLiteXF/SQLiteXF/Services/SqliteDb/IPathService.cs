namespace SQLiteXF.Services.SqliteDb
{
    using SQLite;

    public interface IPathService
    {
        SQLiteAsyncConnection GetAsyncConnection();
    }
}

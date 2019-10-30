namespace SQLiteXF.Database
{
    using SQLite;
    public interface IPathService
    {
        SQLiteAsyncConnection GetConnection();
    }
}

namespace SQLite.Storage
{
    public interface ISqlite 
    {
        SQLiteAsyncConnection GetAsyncConnection();
        SQLiteConnection GetConnection();
    }
}

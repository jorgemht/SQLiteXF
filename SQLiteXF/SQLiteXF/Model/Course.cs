namespace SQLiteXF.Model
{
    using SQLite;
    using SQLiteXF.Services.SqliteDb;

    public class Course : IKeyObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}

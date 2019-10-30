namespace SQLiteXF.Model
{
    using SQLite;
    using SQLiteXF.Services.SqliteDb;

    public class Student : IKeyObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public int StudentRequestId { get; set; }

        public string Name { get; set; }
        
        public string Age { get; set; }
    }
}

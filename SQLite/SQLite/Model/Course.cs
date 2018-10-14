namespace SQLite.Model
{
    using Services.Sqlite;

    public class Course : ObservableObject, IKeyObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}

namespace SQLite.Model
{
    using Storage;

    public class Course : ObservableObject, IKeyObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}

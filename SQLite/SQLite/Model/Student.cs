 namespace SQLite.Model
{
    using Storage;

    public class Student : ObservableObject, IKeyObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public int StudentRequestId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}

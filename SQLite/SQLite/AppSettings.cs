namespace SQLite
{
    public class AppSettings
    {
        public static string defaultSubjectsEndpoint;
        public static string defaultTeachersEndpoint;
        public static string defaulStudentsFileUrl;

        public AppSettings()
        {
            defaultSubjectsEndpoint = "YOUR_END_POINT";
            defaultTeachersEndpoint = "YOUR_END_POINT";
            defaulStudentsFileUrl = "YOUR_END_POINT";
        }

        public static string DatabaseName = "Sql.db3";
    }
}
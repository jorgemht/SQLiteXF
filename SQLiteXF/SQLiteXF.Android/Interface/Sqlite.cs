using SQLiteXF.Droid.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(Sqlite))]
namespace SQLiteXF.Droid.Interface
{
    using SQLite;
    using System;
    using System.IO;

    public class Sqlite
    {
        private SQLiteAsyncConnection GetConnection() => 
            new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppSettings.NameDataBase));
    }
}
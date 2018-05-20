using System;
using System.IO;
using SQLite.iOS.Interface;
using SQLite.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteIos))]
namespace SQLite.iOS.Interface
{
    public class SqliteIos : ISqlite
    {
        public SQLiteAsyncConnection GetAsyncConnection() => new SQLiteAsyncConnection(GetPath());

        public SQLiteConnection GetConnection() => new SQLiteConnection(GetPath());

        private string GetPath()
        {
            var sqliteFilename = "SQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); //  Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            return path;
        }
    }
}
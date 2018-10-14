﻿using SQLite.Droid.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteAndroid))]
namespace SQLite.Droid.Interface
{
    using Services.Sqlite;
    using System;
    using System.IO;

    public class SqliteAndroid : IPathService
    {
        public SQLiteAsyncConnection GetAsyncConnection() => new SQLiteAsyncConnection(GetPath());

        public SQLiteConnection GetConnection() => new SQLiteConnection(GetPath());

        private string GetPath()
        {
            var sqliteFilename = "SQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            return path;
        }
    }
}
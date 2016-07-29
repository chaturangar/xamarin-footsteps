using System;
using System.Collections.Generic;
using System.Text;
using ScFootsteps.Meetup.ExampleSix.Base.CrossDependencies;
using System.IO;
using SQLite;

namespace ScFootsteps.Meetup.ExampleSix.iOS.Base.CrossDependencies
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ExampleSixSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}

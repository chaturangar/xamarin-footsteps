using ScFootsteps.Meetup.ExampleFour.CrossDependencies;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using ScFootsteps.Meetup.ExampleFour.iOS.CrossDependencies;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace ScFootsteps.Meetup.ExampleFour.iOS.CrossDependencies
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ExampleFourSQLite.db3";
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

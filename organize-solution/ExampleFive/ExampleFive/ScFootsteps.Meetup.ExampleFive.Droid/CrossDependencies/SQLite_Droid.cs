using SQLite;
using System.IO;
using ScFootsteps.Meetup.ExampleFive.CrossDependencies;

namespace ScFootsteps.Meetup.ExampleFive.Droid.CrossDependencies
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ExampleFiveSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}
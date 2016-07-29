using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ScFootsteps.Meetup.ExampleFour.CrossDependencies;
using SQLite;
using System.IO;
using Xamarin.Forms;
using ScFootsteps.Meetup.ExampleFour.Droid.CrossDependencies;

[assembly: Dependency(typeof(SQLite_Droid))]
namespace ScFootsteps.Meetup.ExampleFour.Droid.CrossDependencies
{
    public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ExampleFourSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}
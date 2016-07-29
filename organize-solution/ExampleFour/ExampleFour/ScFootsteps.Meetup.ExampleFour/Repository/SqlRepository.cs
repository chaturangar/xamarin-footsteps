using ScFootsteps.Meetup.ExampleFour.CrossDependencies;
using ScFootsteps.Meetup.ExampleFour.Entities;
using SQLite;
using Xamarin.Forms;
using System.Linq;

namespace ScFootsteps.Meetup.ExampleFour.Repository
{
    public class SqlRepository : IDataRepository
    {
        private static SQLiteConnection _sqliteConnection;

        public SqlRepository()
        {
            _sqliteConnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqliteConnection.CreateTable<Properties>();
        }

        public void AddUpdateProperty(string key, double value)
        {
            var row = _sqliteConnection.Table<Properties>().FirstOrDefault(p => p.Name == key);
            
            if (row == null)
            {
                var prop = new Properties { Name = key, Value = value };
                _sqliteConnection.Insert(prop);
            }
            else
            {
                row.Value = value;
                _sqliteConnection.Update(row);
            }
        }

        public double GetPropertyByKey(string key)
        {
            var row = _sqliteConnection.Table<Properties>().FirstOrDefault(p => p.Name == key);

            if(row != null)
            {
                return row.Value;
            }

            return 0;
        }
    }
}

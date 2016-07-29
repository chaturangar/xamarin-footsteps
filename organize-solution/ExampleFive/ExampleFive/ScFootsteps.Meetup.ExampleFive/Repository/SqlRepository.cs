using ScFootsteps.Meetup.ExampleFive.CrossDependencies;
using ScFootsteps.Meetup.ExampleFive.Entities;
using SQLite;
using System.Linq;

namespace ScFootsteps.Meetup.ExampleFive.Repository
{
    public class SqlRepository : IDataRepository
    {
        private static SQLiteConnection _sqliteConnection;

        public SqlRepository(ISQLite database)
        {
            _sqliteConnection = database.GetConnection();
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

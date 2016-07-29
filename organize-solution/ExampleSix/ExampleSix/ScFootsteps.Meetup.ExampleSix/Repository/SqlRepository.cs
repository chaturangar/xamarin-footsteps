using ScFootsteps.Meetup.ExampleSix.Base.CrossDependencies;
using ScFootsteps.Meetup.ExampleSix.Domains;
using ScFootsteps.Meetup.ExampleSix.Repository.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScFootsteps.Meetup.ExampleSix.Repository
{
    public class SqlRepository : IDataRepository
    {
        private static SQLiteConnection _sqliteConnection;

        public SqlRepository(ISQLite database)
        {
            _sqliteConnection = database.GetConnection();
            _sqliteConnection.CreateTable<PropertiesTable>();
        }

        public void AddUpdateProperty(Property property)
        {
            if(property == null)
            {
                return;
            }

            var row = _sqliteConnection.Table<PropertiesTable>().FirstOrDefault(p => p.Name == property.Name);

            if (row == null)
            {
                var prop = new PropertiesTable { Name = property.Name, Value = property.Value };
                _sqliteConnection.Insert(prop);
            }
            else
            {
                row.Value = property.Value;
                _sqliteConnection.Update(row);
            }
        }

        public Property GetPropertyByKey(string key)
        {
            var row = _sqliteConnection.Table<PropertiesTable>().FirstOrDefault(p => p.Name == key);
            
            if (row != null)
            {
                var model = new Property();

                model.Name = key;
                model.Value = row.Value;

                return model;
            }

            return null;
        }
    }
}

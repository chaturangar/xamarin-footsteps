using SQLite;

namespace ScFootsteps.Meetup.ExampleSix.Repository.Entities
{
    class PropertiesTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}

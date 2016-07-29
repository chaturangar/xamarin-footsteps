using SQLite;

namespace ScFootsteps.Meetup.ExampleFour.Entities
{
    public class Properties
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}

using SQLite;

namespace ScFootsteps.Meetup.ExampleFour.CrossDependencies
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

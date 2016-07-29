using SQLite;

namespace ScFootsteps.Meetup.ExampleFive.CrossDependencies
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

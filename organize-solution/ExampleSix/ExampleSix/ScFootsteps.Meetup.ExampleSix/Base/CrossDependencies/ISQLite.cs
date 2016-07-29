using SQLite;

namespace ScFootsteps.Meetup.ExampleSix.Base.CrossDependencies
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

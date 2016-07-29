namespace ScFootsteps.Meetup.ExampleFive.Repository
{
    public interface IDataRepository
    {
        double GetPropertyByKey(string key);
        void AddUpdateProperty(string key, double value);
    }
}

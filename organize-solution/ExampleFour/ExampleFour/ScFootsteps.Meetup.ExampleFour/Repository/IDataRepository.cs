namespace ScFootsteps.Meetup.ExampleFour.Repository
{
    public interface IDataRepository
    {
        double GetPropertyByKey(string key);
        void AddUpdateProperty(string key, double value);
    }
}

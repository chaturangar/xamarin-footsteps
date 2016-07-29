namespace ScFootsteps.Meetup.ExampleThree.Repository
{
    public interface IMemoryRepository
    {
        double GetPropertyByKey(string key);
        void AddUpdateProperty(string key, double value);
    }
}

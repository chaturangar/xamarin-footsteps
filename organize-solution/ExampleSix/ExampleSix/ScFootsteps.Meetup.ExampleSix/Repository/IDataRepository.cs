using ScFootsteps.Meetup.ExampleSix.Domains;

namespace ScFootsteps.Meetup.ExampleSix.Repository
{
    public interface IDataRepository
    {
        Property GetPropertyByKey(string key);
        void AddUpdateProperty(Property property);
    }
}

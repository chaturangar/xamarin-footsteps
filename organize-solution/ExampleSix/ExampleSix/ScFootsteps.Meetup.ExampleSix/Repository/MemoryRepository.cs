using ScFootsteps.Meetup.ExampleSix.Domains;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleSix.Repository
{
    public class MemoryRepository : IDataRepository
    {
        public Property GetPropertyByKey(string key)
        {
            double value = 0;

            if (string.IsNullOrEmpty(key))
            {
                return new Property();
            }

            if (Application.Current.Properties.ContainsKey(key))
            {
                double.TryParse(Application.Current.Properties[key].ToString(), out value);
            }

            return new Property { Name = key, Value = value };
        }

        public void AddUpdateProperty(Property property)
        {
            if(property == null || string.IsNullOrEmpty(property.Name))
            {
                return;
            }

            Application.Current.Properties[property.Name] = property.Value;
        }
    }
}

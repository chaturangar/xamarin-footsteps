﻿using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleFive.Repository
{
    public class MemoryRepository : IDataRepository
    {
        public double GetPropertyByKey(string key)
        {
            double value = 0;

            if(string.IsNullOrEmpty(key))
            {
                return value;
            }

            if (Application.Current.Properties.ContainsKey(key))
            {
                double.TryParse(Application.Current.Properties[key].ToString(), out value);
            }

            return value;
        }

        public void AddUpdateProperty(string key, double value)
        {
            Application.Current.Properties[key] = value;
        }
    }
}

using System;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleOne.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void OnCalculationClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScFootsteps.Meetup.ExampleOne.Pages.CalculationPage());
        }
    }
}

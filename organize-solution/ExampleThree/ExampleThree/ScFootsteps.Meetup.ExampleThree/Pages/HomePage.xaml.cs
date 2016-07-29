using System;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleThree.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void OnCalculationClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CalculationPage());
        }
    }
}

using ScFootsteps.Meetup.ExampleTwo.Services;
using System;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleTwo.Pages
{
    public partial class CalculationPage : ContentPage
    {
        private readonly ICalculationService _calculationService;

        public CalculationPage()
        {
            InitializeComponent();

            _calculationService = new CalculationService();

            this.Result.Text = _calculationService.GetFinalResult().ToString();
        }

        public void OnCalculateClicked(object sender, EventArgs e)
        {
            this.Result.Text = _calculationService.Multiplication(this.OperandOne.Text, this.OperandTwo.Text).ToString();
        }
    }
}

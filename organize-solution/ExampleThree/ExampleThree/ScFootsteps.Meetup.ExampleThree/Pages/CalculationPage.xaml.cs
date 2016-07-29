using ScFootsteps.Meetup.ExampleThree.Services;
using System;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleThree.Pages
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

using ScFootsteps.Meetup.ExampleSix.Services;
using System;
using Autofac;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleSix.Pages
{
    public partial class CalculationPage : ContentPage
    {
        private readonly ICalculationService _calculationService;

        public CalculationPage() : this(App.Container.Resolve<ICalculationService>())
        {
        }

        public CalculationPage(ICalculationService calculationService)
        {
            InitializeComponent();

            _calculationService = calculationService;

            this.Result.Text = _calculationService.GetFinalResult().ToString();
        }

        public void OnCalculateClicked(object sender, EventArgs e)
        {
            this.Result.Text = _calculationService.Multiplication(this.OperandOne.Text, this.OperandTwo.Text).ToString();
        }
    }
}

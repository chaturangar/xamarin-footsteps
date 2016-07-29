using ScFootsteps.Meetup.ExampleFive.Services;
using System;
using Xamarin.Forms;
using Autofac;

namespace ScFootsteps.Meetup.ExampleFive.Pages
{
    public partial class CalculationPage : ContentPage
    {
        private readonly ICalculationService _calculationService;

        /*public CalculationPage()
        {
            InitializeComponent();

            _calculationService = new CalculationService();

            this.Result.Text = _calculationService.GetFinalResult().ToString();
        }*/

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

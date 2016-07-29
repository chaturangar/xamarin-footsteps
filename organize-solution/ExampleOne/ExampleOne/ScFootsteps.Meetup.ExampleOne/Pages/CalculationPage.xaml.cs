using System;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleOne.Pages
{
    public partial class CalculationPage : ContentPage
    {
        public CalculationPage()
        {
            InitializeComponent();

            this.Result.Text = FinalResult;
        }

        public void OnCalculateClicked(object sender, EventArgs e)
        {
            double valueOne;
            double valueTwo;

            /// Logic
            if(double.TryParse(this.OperandOne.Text, out valueOne) && double.TryParse(this.OperandTwo.Text, out valueTwo))
            {
                var finalResult = valueOne * valueTwo;
                FinalResult = finalResult.ToString();
                this.Result.Text = FinalResult;
            }
        }

        /// <summary>
        /// Data Repository
        /// </summary>
        private string FinalResult {
            get
            {
                if (Application.Current.Properties.ContainsKey("result"))
                {
                    return Application.Current.Properties["result"].ToString();
                }

                return string.Empty;
            }
            set
            {
                if (!Application.Current.Properties.ContainsKey("result"))
                {
                    Application.Current.Properties.Add("result", value);
                } else
                {
                    Application.Current.Properties["result"] = value;
                }
            }
        }
    }
}

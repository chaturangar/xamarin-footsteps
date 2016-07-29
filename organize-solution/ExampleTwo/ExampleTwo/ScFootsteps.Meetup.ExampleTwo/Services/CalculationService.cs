using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleTwo.Services
{
    public class CalculationService : ICalculationService
    {
        public double GetFinalResult()
        {
            double value = 0;

            if (Application.Current.Properties.ContainsKey("result"))
            {
                double.TryParse(Application.Current.Properties["result"].ToString(), out value);
            }

            return value;
        }

        public double Multiplication(string operandOne, string operandTwo)
        {
            double valueOne;
            double valueTwo;

            double.TryParse(operandOne, out valueOne);
            double.TryParse(operandTwo, out valueTwo);

            return Multiplication(valueOne, valueTwo);
        }

        public double Multiplication(double operandOne, double operandTwo)
        {
            var result = operandOne * operandTwo;

            Application.Current.Properties["result"] = result.ToString();

            return result;
        }
    }
}

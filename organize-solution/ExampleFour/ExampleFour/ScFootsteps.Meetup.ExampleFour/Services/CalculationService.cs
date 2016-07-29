using ScFootsteps.Meetup.ExampleFour.Repository;

namespace ScFootsteps.Meetup.ExampleFour.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly IDataRepository _dataRepository;

        public CalculationService()
        {
            _dataRepository = new SqlRepository();
        }

        public double GetFinalResult()
        {
            return _dataRepository.GetPropertyByKey("result");
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

            _dataRepository.AddUpdateProperty("result", result);

            return result;
        }
    }
}

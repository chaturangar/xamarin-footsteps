using ScFootsteps.Meetup.ExampleSix.Domains;
using ScFootsteps.Meetup.ExampleSix.Repository;

namespace ScFootsteps.Meetup.ExampleSix.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly IDataRepository _dataRepository;

        public CalculationService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public double GetFinalResult()
        {
            var property = _dataRepository.GetPropertyByKey("result");

            if(property == null)
            {
                return 0;
            }

            return property.Value;
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
            var property = new Property { Name = "result", Value = result };

            _dataRepository.AddUpdateProperty(property);

            return result;
        }
    }
}

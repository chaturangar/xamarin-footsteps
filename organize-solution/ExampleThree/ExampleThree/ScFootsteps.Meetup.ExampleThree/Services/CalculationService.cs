using ScFootsteps.Meetup.ExampleThree.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleThree.Services
{
    public class CalculationService : ICalculationService
    {
        private readonly IMemoryRepository _memoryRepository;

        public CalculationService()
        {
            _memoryRepository = new MemoryRepository();
        }

        public double GetFinalResult()
        {
            return _memoryRepository.GetPropertyByKey("result");
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

            _memoryRepository.AddUpdateProperty("result", result);

            return result;
        }
    }
}

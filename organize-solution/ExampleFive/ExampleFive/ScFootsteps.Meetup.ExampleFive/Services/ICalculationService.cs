namespace ScFootsteps.Meetup.ExampleFive.Services
{
    public interface ICalculationService
    {
        double GetFinalResult();
        double Multiplication(string operandOne, string operandTwo);
        double Multiplication(double operandOne, double operandTwo);
    }
}

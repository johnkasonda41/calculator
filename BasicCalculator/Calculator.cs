using operations;

namespace BasicCalculator
{
    public interface ICalculator
    {
        public int Add(int a, int b);
        public double Add(double a, double b);

        public int Divide(int a, int b);
        public double Divide(double a, double b);

    }
    public class Calculator : ICalculator
    {
        public dynamic result;

        public int Add(int a, int b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public double Add(double a, double b)
        {
            result = Addition.Sum(a, b);
            return result;
        }
        public int Divide(int a, int b)
        {
            result = Division.Divide(a, b);
            return result;
        }

        public double Divide(double a, double b)
        {
            result = Division.Divide(a, b);
            return result;
        }
    }
}
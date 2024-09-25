namespace Lab2
{
    public class HyperbolicCosineCalculator
    {
        public double CalculateCh(double x, int iterations)
        {
            double sum = 1;
            double factorial = 1;
            double power = 1;
            for (int i = 1; i <= iterations; i++)
            {
                power *= x * x;
                factorial *= (2 * i - 1) * (2 * i);
                sum += power / factorial;
            }
            return sum;
        }
    }
}

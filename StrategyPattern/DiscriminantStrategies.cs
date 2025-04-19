namespace DesignPatterns.StrategyPattern
{
    internal class OridinaryDiscriminant : IDiscriminant
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

    internal class RealDiscriminant : IDiscriminant
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
                return double.NaN; // No real roots
            else
                return discriminant;
        }
    }
}

namespace DesignPatterns.StrategyPattern
{
    internal class EquationSolver
    {
        private readonly IDiscriminant _discriminant;
        public EquationSolver(IDiscriminant discriminant)
        {
            _discriminant = discriminant;
        }
        public List<double> SolveQuadratic(double a, double b, double c)
        {
            List<double> ans = new List<double>(2);
            double discriminant = _discriminant.CalculateDiscriminant(a, b, c);
            double x1 = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
            ans.Add(x1);
            ans.Add(x2);
            return ans;
        }
    }
}

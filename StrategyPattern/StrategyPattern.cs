namespace DesignPatterns.StrategyPattern
{
    public class StrategyPattern
    {
        public void RunPattern()
        {
            Console.WriteLine("Strategy pattern:");
            Console.WriteLine("Enter a:");
            double a = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter b:");
            double b = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter c:");
            double c = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Choose discriminant strategy: 1 - Ordinary, 2 - Real");
            int strategy = int.Parse(Console.ReadLine() ?? string.Empty);

            EquationSolver eq;
            if (strategy == 1)
            {
                eq = new EquationSolver(new OridinaryDiscriminant());
            }
            else if (strategy == 2)
            {
                eq = new EquationSolver(new RealDiscriminant());
            }
            else
            {
                Console.WriteLine("Invalid strategy");
                return;
            }

            List<double> result = eq.SolveQuadratic(a, b, c);
            Console.WriteLine($"Roots are: {result[0]} and {result[1]}");
        }
    }
}

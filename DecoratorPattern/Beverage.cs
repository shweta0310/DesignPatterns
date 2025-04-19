namespace DesignPatterns.DecoratorPattern
{
    internal abstract class Beverage
    {
        public string Description { get; set; } = "Unknown Beverage";
        public string GetDescription()
        {
            return Description;
        }
        abstract public double Cost();
    }

    internal class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    internal class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return 2.99;
        }
    }
}

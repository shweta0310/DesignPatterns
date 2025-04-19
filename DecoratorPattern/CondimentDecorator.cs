namespace DesignPatterns.DecoratorPattern
{
    internal abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        // Used new keyword to hide the base class method
        abstract public new string GetDescription();
    }

    internal class MochaDecorator : CondimentDecorator
    {
        public MochaDecorator(Beverage beverage) : base(beverage)
        {
            Description = "Mocha";
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + Description;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }

    internal class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(Beverage beverage) : base(beverage)
        {
            Description = "Milk";
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + Description;
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }
    }
}

namespace DesignPatterns.DecoratorPattern
{
    internal class DecoratorPattern
    {
        public static void RunPattern()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
            Beverage beverage2 = new Decaf();

            beverage = new MochaDecorator(beverage);
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            beverage2 = new MochaDecorator(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");
            beverage2 = new MilkDecorator(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");
        }
    }
}

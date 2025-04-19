namespace DesignPatterns.AbstractFactoryPattern
{
    internal class AbstractFactoryPattern
    {
        public static void RunPattern()
        {
            Console.WriteLine("Abstract Factory Pattern");
            Console.WriteLine("Which city are you in?\n 1. New York\n 2. Chicago\n Provide relevant number.\n");
            string city = Console.ReadLine();
            IPizzaIngredientsFactory pizzaIngredientsFactory = city switch
            {
                "1" => new NewYorkPizzaIngredientsFactory(),
                "2" => new ChicagoPizzaIngredientsFactory(),
                _ => throw new ArgumentException("Invalid city")
            };
            Pizza pizza = city switch
            {
                "1" => new NewYorkStylePizza(pizzaIngredientsFactory),
                "2" => new ChicagoStylePizza(pizzaIngredientsFactory),
                _ => throw new ArgumentException("Invalid city")
            };
            pizza.Prepare();
        }
    }
}

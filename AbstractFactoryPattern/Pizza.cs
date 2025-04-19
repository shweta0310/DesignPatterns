using DesignPatterns.AbstractFactoryPattern.Ingredients;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ICheese Cheese { get; set; }
        public List<IVeggie> Veggies { get; set; }
        public abstract void Create();
        public void Prepare()
        {
            Create();

            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing dough: {Dough.Name}");
            Console.WriteLine($"Adding cheese: {Cheese.Name}");
            Console.WriteLine("Adding veggies:");
            foreach (var veggie in Veggies)
            {
                Console.WriteLine($"  {veggie.Name}");
            }
        }
    }

    internal class NewYorkStylePizza : Pizza
    {
        private IPizzaIngredientsFactory _pizzaIngredientsFactory;
        public NewYorkStylePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        public override void Create()
        {
            Name = "New York Style Pizza";
            Console.WriteLine($"Creating {Name}");
            Dough = _pizzaIngredientsFactory.CreateDough();
            Cheese = _pizzaIngredientsFactory.CreateCheese();
            Veggies = _pizzaIngredientsFactory.CreateVeggies();
        }
    }

    internal class ChicagoStylePizza : Pizza
    {
        private IPizzaIngredientsFactory _pizzaIngredientsFactory;
        public ChicagoStylePizza(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            _pizzaIngredientsFactory = pizzaIngredientsFactory;
        }
        public override void Create()
        {
            Name = "Chicago Style Pizza";
            Console.WriteLine($"Creating {Name}");
            Dough = _pizzaIngredientsFactory.CreateDough();
            Cheese = _pizzaIngredientsFactory.CreateCheese();
            Veggies = _pizzaIngredientsFactory.CreateVeggies();
        }
    }
}

using DesignPatterns.AbstractFactoryPattern.Ingredients;

namespace DesignPatterns.AbstractFactoryPattern
{
    internal interface IPizzaIngredientsFactory
    {
        public IDough CreateDough();
        public ICheese CreateCheese();
        public List<IVeggie> CreateVeggies();
    }

    internal class NewYorkPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>
            {
                new Garlic(),
                new Onion(),
                new Mushroom()
            };
        }
    }

    internal class ChicagoPizzaIngredientsFactory : IPizzaIngredientsFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }
        public ICheese CreateCheese()
        {
            return new GoatCheese();
        }
        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie>
            {
                new Onion(),
            };
        }
    }
}

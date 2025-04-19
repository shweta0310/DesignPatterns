namespace DesignPatterns.AbstractFactoryPattern.Ingredients
{
    internal interface IDough
    {
        string Name { get; }
    }

    public class ThinCrustDough : IDough
    {
        public string Name => "Thin Crust Dough";
    }

    public class ThickCrustDough : IDough
    {
        public string Name => "Thick Crust Dough";
    }
}

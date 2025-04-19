internal interface ICheese
{
    string Name { get; }
}

public class MozzarellaCheese : ICheese
{
    public string Name => "Mozzarella Cheese";
}

public class GoatCheese : ICheese
{
    public string Name => "Goat Cheese";
}
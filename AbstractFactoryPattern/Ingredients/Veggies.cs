internal interface IVeggie
{
    string Name { get; }
}

public class Garlic : IVeggie
{
    public string Name => "Garlic";
}

public class Onion : IVeggie
{
    public string Name => "Onion";
}

public class Mushroom : IVeggie
{
    public string Name => "Mushroom";
}
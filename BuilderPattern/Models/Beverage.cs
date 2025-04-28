namespace DesignPatterns.BuilderPattern.Models
{
    internal class Beverage
    {
        public string BeverageName { get; set; } = null!;
        public int Quantity { get; set; } = 0;
        public BeverageSize Size { get; set; }
        public float BasePrice { get; set; } = 0;
        public BeverageTemperature Temperature { get; set; }
        public ContainerType ContainerType { get; set; }
        public string? CustomizationsList { get; set; }
        public string? SpecialInstructions { get; set; }
    }

    internal enum BeverageSize
    {
        Small,
        Medium,
        Large,
    }

    internal enum BeverageTemperature
    {
        Hot,
        Cold,
        RoomTemperature
    }

    internal enum ContainerType
    {
        GlassCup,
        PaperCup,
        PlasticCup
    }
}

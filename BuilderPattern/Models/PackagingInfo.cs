namespace DesignPatterns.BuilderPattern.Models
{
    internal class PackagingInfo
    {
        public PackagingType PackagingType { get; set; }
        public bool UtensilsRequired { get; set; } = false;
        public int CountOfNapkins { get; set; } = 0;
        public string? PackagingInstructions { get; set; }
    }
    internal enum PackagingType
    {
        DineIn,
        Takeout,
        Delivery
    }
}

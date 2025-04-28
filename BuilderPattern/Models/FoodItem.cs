namespace DesignPatterns.BuilderPattern.Models
{
    internal class FoodItem
    {
        public string ItemName { get; set; } = null!;
        public int Quantity { get; set; } = 0;
        public float BasePrice { get; set; } = 0;
        public FoodCategory Category { get; set; }
        public string? CustomizationsList { get; set; }
        public string? SpecialInstructions { get; set; }
    }
    internal enum FoodCategory
    {
        Appetizer,
        MainCourse,
        Dessert
    }
}

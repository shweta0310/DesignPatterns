namespace DesignPatterns.StatePattern.Models
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InventoryLevel { get; set; } = 1;

        public Product(string id, string name, double price, int inventoryLevel = 1)
        {
            Id = id;
            Name = name;
            Price = price;
            InventoryLevel = inventoryLevel;
        }
    }
}

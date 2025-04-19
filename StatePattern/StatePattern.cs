using DesignPatterns.StatePattern.Models;

namespace DesignPatterns.StatePattern
{
    internal class StatePattern
    {
        public static void RunPattern()
        {
            Console.WriteLine("State Pattern Example");
            Console.WriteLine("---------------------");
            // Create a vending machine
            var vendingMachine = new VendingMachine();
            // Add products to the vending machine
            var product1 = new Product("A123", "Soda", 1.50, 4);
            var product2 = new Product("B567", "Chips", 1.00, 2);
            var product3 = new Product("C890", "Candy", 0.75, 5);
            vendingMachine.AddProduct(product1);
            vendingMachine.AddProduct(product2);
            vendingMachine.AddProduct(product3);

            // Insert money and select a product
            vendingMachine.InsertMoney(2.00);
            vendingMachine.SelectProduct(product1, 2.00);
            // Dispense the product
            vendingMachine.DispenseProduct();
            // Enter service mode
            vendingMachine.EnterServiceMode();

            // Restock a product
            var product4 = new Product("A123", "Soda", 1.50, 10);
            vendingMachine.RestockProduct(product4);
            // Exit service mode
            vendingMachine.ExitServiceMode();
            // Cancel the transaction
            vendingMachine.InsertMoney(5.00);
            vendingMachine.CancelTransaction();
        }
    }
}

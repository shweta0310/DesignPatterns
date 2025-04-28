using DesignPatterns.BuilderPattern.Builders;
using DesignPatterns.BuilderPattern.Models;

namespace DesignPatterns.BuilderPattern
{
    internal class BuilderPattern
    {
        public static void RunPattern()
        {
            var builder = new OrderBuilder();
            var orderManagementSystem = new OrderManagementSystem(builder);

            string customerName = "John Doe";
            string contactNumber = "987654321";
            string deliveryAddress = "123, Street 1, London, UK";
            List<FoodItem> foodItems = new List<FoodItem>()
            {
                new FoodItem()
                {
                    ItemName = "Pasta",
                    Quantity = 1,
                    BasePrice = 350F,
                    CustomizationsList ="Extra cheese"
                },
                new FoodItem()
                {
                    ItemName = "Garlic bread",
                    Quantity = 2,
                    BasePrice = 200F,
                    SpecialInstructions ="Add jalepeno dip"
                }
            };
            List<Beverage> beverages = new List<Beverage>()
            {
                new Beverage()
                {
                    BeverageName = "Coke",
                    Quantity = 1,
                    Size = BeverageSize.Medium,
                    BasePrice = 50F,
                    Temperature = BeverageTemperature.Cold,
                    ContainerType = ContainerType.PaperCup
                }
            };

            var dineInOrder = orderManagementSystem.BuildDineInOrder(customerName, contactNumber, foodItems, beverages, PaymentMethod.CreditCard);
            dineInOrder.DisplayOrder();

            var deliveryOrder = orderManagementSystem.BuildDeliveryOrder(customerName, contactNumber, foodItems, beverages, PaymentMethod.OnlinePayment, deliveryAddress);
            deliveryOrder.DisplayOrder();

        }
    }
}

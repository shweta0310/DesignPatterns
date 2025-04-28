using DesignPatterns.BuilderPattern.Builders;
using DesignPatterns.BuilderPattern.Models;

namespace DesignPatterns.BuilderPattern
{
    internal class OrderManagementSystem
    {
        private IOrderBuilder _builder;
        public OrderManagementSystem(IOrderBuilder orderBuilder)
        {
            _builder = orderBuilder;
        }

        public Order BuildDineInOrder(string customerName, string contactNumber, List<FoodItem> foodItems, List<Beverage> beverages, PaymentMethod paymentMethod, float tip = 0)
        {
            _builder.SetOrderInfo(customerName, contactNumber);
            for (int i = 0; i < foodItems.Count; i++)
            {
                _builder.AddFoodItem(foodItems[i]);
            }
            for (int i = 0; i < beverages.Count; i++)
            {
                _builder.AddBeverage(beverages[i]);
            }
            _builder.SetPackagingInfo(new PackagingInfo
            {
                PackagingType = PackagingType.DineIn,
                UtensilsRequired = true,
                CountOfNapkins = 1,
                PackagingInstructions = null
            });
            _builder.SetPaymentInfo(paymentMethod, tip, 0);
            return _builder.Build();
        }

        public Order BuildDeliveryOrder(string customerName, string contactNumber, List<FoodItem> foodItems, List<Beverage> beverages, PaymentMethod paymentMethod, string deliveryAddress)
        {
            _builder.SetOrderInfo(customerName, contactNumber);
            for (int i = 0; i < foodItems.Count; i++)
            {
                _builder.AddFoodItem(foodItems[i]);
            }
            for (int i = 0; i < beverages.Count; i++)
            {
                _builder.AddBeverage(beverages[i]);
            }
            _builder.SetPackagingInfo(new PackagingInfo
            {
                PackagingType = PackagingType.Delivery,
                UtensilsRequired = false,
                CountOfNapkins = 3,
                PackagingInstructions = "Package for delivery"
            });
            _builder.SetPaymentInfo(paymentMethod, 0, 0);
            _builder.SetDeliveryInfo(new DeliveryInfo
            {
                Address = deliveryAddress,
                RequestedDeliveryTime = DateTime.Now,
                EstimatedDeliveryTime = DateTime.Now.AddMinutes(30),
                DeliveryInstructions = "Leave at door"
            });
            return _builder.Build();
        }
    }
}

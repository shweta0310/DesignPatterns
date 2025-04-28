using DesignPatterns.BuilderPattern.Models;

namespace DesignPatterns.BuilderPattern.Builders
{
    internal interface IOrderBuilder
    {
        public void SetOrderInfo(string customerName, string contactNumber);
        public void AddFoodItem(FoodItem foodItem);
        public void AddBeverage(Beverage beverage);
        public void SetPackagingInfo(PackagingInfo? packagingInfo);
        public void SetPaymentInfo(PaymentMethod paymentMethod, float tipAmount, float discount);
        public void SetDeliveryInfo(DeliveryInfo? deliveryInfo);
        public Order Build();
    }
}

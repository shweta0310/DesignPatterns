using DesignPatterns.BuilderPattern.Models;

namespace DesignPatterns.BuilderPattern.Builders
{
    internal class OrderBuilder : IOrderBuilder
    {
        private Order _order;
        private float _taxRate = 0.8F;
        public OrderBuilder()
        {
            _order = new Order()
            {
                OrderInfo = new OrderInfo
                {
                    OrderId = GenerateOrderId(),
                    Timestamp = DateTime.UtcNow,
                    Status = OrderStatus.Received
                },
                FoodItems = new List<FoodItem>(),
                Beverages = new List<Beverage>()
            };
        }

        public string GenerateOrderId()
        {
            return "ORD-" + DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss") + "-" + Guid.NewGuid().ToString().Substring(0, 10);
        }

        public string GenerateTrackingId()
        {
            return "TRK-" + DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss") + "-" + Guid.NewGuid().ToString().Substring(0, 10);
        }

        public void SetOrderInfo(string customerName, string contactNumber)
        {
            _order.OrderInfo.CustomerName = customerName;
            _order.OrderInfo.ContactNumber = contactNumber;
        }

        public void AddFoodItem(FoodItem foodItem)
        {
            _order.FoodItems?.Add(foodItem);
        }

        public void AddBeverage(Beverage beverage)
        {
            _order.Beverages?.Add(beverage);
        }

        public void SetPaymentInfo(PaymentMethod paymentMethod, float tipAmount = 0, float discount = 0)
        {
            var subTotal = _order.CalculateSubTotal();
            var taxTotal = subTotal * _taxRate;
            var totalAmount = taxTotal + tipAmount - discount;
            _order.Payment = new PaymentInfo
            {
                PaymentMethod = paymentMethod,
                TipAmount = tipAmount,
                Discount = discount,
                TotalAmount = totalAmount,
                TaxAmount = taxTotal,
                PaymentStatus = PaymentStatus.Unpaid
            };
        }

        public void SetPackagingInfo(PackagingInfo? packagingInfo)
        {
            _order.Packaging = packagingInfo;
        }

        public void SetDeliveryInfo(DeliveryInfo? deliveryInfo)
        {
            _order.Delivery = deliveryInfo;
            _order.Delivery.TrackingId = GenerateTrackingId();
        }

        public Order Build()
        {
            return _order;
        }
    }
}

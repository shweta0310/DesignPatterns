namespace DesignPatterns.BuilderPattern.Models
{
    internal class Order
    {
        public OrderInfo OrderInfo { get; set; } = null!;
        public List<FoodItem>? FoodItems { get; set; }
        public List<Beverage>? Beverages { get; set; }
        public PackagingInfo? Packaging { get; set; } = null!;
        public PaymentInfo Payment { get; set; } = null!;
        public DeliveryInfo? Delivery { get; set; }

        public float CalculateSubTotal()
        {
            float total = 0;
            for (int i = 0; i < FoodItems?.Count; i++)
            {
                var item = FoodItems.ElementAt(i);
                total += (item.BasePrice * item.Quantity);
            }
            for (int i = 0; i < Beverages?.Count; i++)
            {
                var item = Beverages.ElementAt(i);
                total += (item.BasePrice * item.Quantity);
            }
            return total;
        }

        public void DisplayOrder()
        {
            Console.WriteLine("### ORDER INFORMATION ###");
            Console.WriteLine($"1. OrderId: {OrderInfo.OrderId}" +
                $"\n2. Customer name: {OrderInfo.CustomerName}" +
                $"\n3. Contact number: {OrderInfo.ContactNumber}" +
                $"\n4. Timestamp: {OrderInfo.Timestamp.ToString()}" +
                $"\n5. Status: {OrderInfo.Status}");

            Console.WriteLine("### FOOD ITEMS ###");
            for (int i = 0; i < FoodItems?.Count; i++)
            {
                Console.WriteLine($"Food Item {i + 1}:\n " +
                    $"1. ItemName: {FoodItems[i].ItemName}" +
                    $"\n2. Quantity: {FoodItems[i].Quantity.ToString()}" +
                    $"\n3. Base price: {FoodItems[i].BasePrice.ToString()}" +
                    $"\n4. Category: {FoodItems[i].Category.ToString()}" +
                    $"\n5. CustomizationsList: {FoodItems[i].CustomizationsList}" +
                    $"\n6. SpecialInstructions: {FoodItems[i].SpecialInstructions}");
            }

            Console.WriteLine("### BEVERAGES ###");
            for (int i = 0; i < Beverages?.Count; i++)
            {
                Console.WriteLine($"Beverage Item {i + 1}:\n" +
                    $"1. ItemName: {Beverages[i].BeverageName}" +
                    $"\n2. Quantity: {Beverages[i].Quantity.ToString()}" +
                    $"\n3. Size: {Beverages[i].Size.ToString()})" +
                    $"\n4. Base price: {Beverages[i].BasePrice.ToString()}" +
                    $"\n5. Temperature: {Beverages[i].Temperature}" +
                    $"\n6. ContainerType: {Beverages[i].ContainerType}" +
                    $"\n7. CustomizationsList: {Beverages[i].CustomizationsList}" +
                    $"\n8. SpecialInstructions: {Beverages[i].SpecialInstructions}");
            }

            Console.WriteLine("### PAYMENT INFORMATION ###");
            Console.WriteLine($"1.Payment method: {Payment.PaymentMethod}\n" +
                    $"2. Total amount: {Payment.TotalAmount}\n" +
                    $"3. Tax amount: {Payment.TaxAmount}\n" +
                    $"4. Tip amount: {Payment.TipAmount}\n" +
                    $"5. Discount: {Payment.Discount}\n" +
                    $"6. Payment status: {Payment.PaymentStatus}");

            if (Packaging != null)
            {
                Console.WriteLine("### PACKAGING INFORMATION ###");
                Console.WriteLine($"1. Packaging type: {Packaging?.PackagingType}\n" +
                    $"2. Utensils required: {((bool)Packaging?.UtensilsRequired ? "Yes" : "No")}\n" +
                    $"3. Count of napkins: {Packaging.CountOfNapkins}\n" +
                    $"4. Packaging Instructions: {(Packaging?.PackagingInstructions != null ? Packaging?.PackagingInstructions : "None")}");
            }

            if (Delivery != null)
            {
                Console.WriteLine("### DELIVERY INFORMATION ###");
                Console.WriteLine($"1.Tracking Id: {Delivery.TrackingId}\n" +
                        $"2. Address: {Delivery.Address}\n" +
                        $"3. Requested Delivery Time: {Delivery.RequestedDeliveryTime}\n" +
                        $"4. Estimated Delivery Time: {Delivery.EstimatedDeliveryTime}\n" +
                        $"5. Delivery Person: {Delivery.DeliveryPerson}\n" +
                        $"6. Delivery Instructions: {Delivery.DeliveryInstructions}");
            }
            Console.WriteLine("=====================\n \n");
        }
    }
}

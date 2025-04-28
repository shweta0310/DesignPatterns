namespace DesignPatterns.BuilderPattern.Models
{
    internal class OrderInfo
    {
        public string OrderId { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public OrderStatus Status { get; set; }
    }

    internal enum OrderStatus
    {
        Received,
        InProgress,
        Ready,
        Delivered,
        Cancelled
    }
}

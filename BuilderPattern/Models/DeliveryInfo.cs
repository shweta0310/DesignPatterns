namespace DesignPatterns.BuilderPattern.Models
{
    internal class DeliveryInfo
    {
        public string TrackingId { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime RequestedDeliveryTime { get; set; }
        public DateTime EstimatedDeliveryTime { get; set; }
        public string DeliveryPerson { get; set; } = null!;
        public string? DeliveryInstructions { get; set; }
    }
}

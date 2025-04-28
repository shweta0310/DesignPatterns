namespace DesignPatterns.BuilderPattern.Models
{
    internal class PaymentInfo
    {
        public PaymentMethod PaymentMethod { get; set; }
        public float TotalAmount { get; set; }
        public float TaxAmount { get; set; }
        public float TipAmount { get; set; }
        public float Discount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
    internal enum PaymentMethod
    {
        Cash,
        DebitCard,
        CreditCard,
        OnlinePayment
    }
    internal enum PaymentStatus
    {
        Paid,
        Unpaid,
        PartiallyPaid
    }
}

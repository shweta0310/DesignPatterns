namespace DesignPatterns.StatePattern.Models
{
    internal class Transaction
    {
        public required string Id { get; set; }
        public required Product Product { get; set; }
        public DateTime Date { get; set; }
    }
}

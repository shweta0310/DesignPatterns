namespace DesignPatterns.ObserverPattern
{
    internal interface IInvestor
    {
        void Notify(double stockPrice);
    }

    public class Investor : IInvestor
    {
        public string? Name { get; set; }
        public Investor(string name)
        {
            Name = name;
        }
        public void Notify(double stockPrice)
        {
            Console.WriteLine($"Investor {Name} is notified of stock price change: {stockPrice}");
        }
    }
}

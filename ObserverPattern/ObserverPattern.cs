namespace DesignPatterns.ObserverPattern
{
    public class ObserverPattern
    {

        internal Stock _stock = new Stock();

        public ObserverPattern()
        {
            _stock.Price = 0.0;
        }

        public void RunPattern()
        {
            Console.WriteLine("Observer pattern:");
            Console.WriteLine("Enter stock price:");
            double price = double.Parse(Console.ReadLine() ?? string.Empty);
            _stock.Price = price;

            Console.WriteLine("Enter 1st investor name:");
            string? name = Console.ReadLine();
            var investor1 = new Investor(name);
            _stock.RegisterInvestor(investor1);

            Console.WriteLine("Enter 2nd investor name:");
            name = Console.ReadLine();
            var investor2 = new Investor(name);
            _stock.RegisterInvestor(investor2);

            Console.WriteLine("Enter new stock price:");
            double newPrice = double.Parse(Console.ReadLine() ?? string.Empty);
            _stock.Price = newPrice;

            _stock.RemoveInvestor(investor1);

            Console.WriteLine("Enter new stock price:");
            newPrice = double.Parse(Console.ReadLine() ?? string.Empty);
            _stock.Price = newPrice;
        }
    }
}

namespace DesignPatterns.ObserverPattern
{
    internal interface IStock
    {
        void RegisterInvestor(IInvestor investor);
        void RemoveInvestor(IInvestor investor);
        void NotifyInvestors();
    }

    internal class Stock : IStock
    {
        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value != _price)
                {
                    _price = value;
                    NotifyInvestors();
                }
            }
        }
        public List<IInvestor> Investors { get; set; } = new List<IInvestor>();
        public void RegisterInvestor(IInvestor investor)
        {
            Investors.Add(investor);
        }
        public void RemoveInvestor(IInvestor investor)
        {
            Investors.Remove(investor);
        }
        public void NotifyInvestors()
        {
            foreach (var investor in Investors)
            {
                investor.Notify(_price);
            }
        }
    }
}

namespace DesignPatterns.SingletonPattern
{
    internal class ChocolateBoiler
    {
        private static ChocolateBoiler? _instance;
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }
        private ChocolateBoiler()
        {
            Boiled = false;
            Empty = true;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_instance == null)
            {
                Console.WriteLine("New instance created");
                _instance = new ChocolateBoiler();
            }
            else
            {
                Console.WriteLine("Existing instance returned");
            }
            return _instance;

        }
    }
}

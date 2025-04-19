namespace DesignPatterns.SingletonPattern
{
    internal class SingletonPattern
    {
        public static void RunPattern()
        {
            var boiler = ChocolateBoiler.GetInstance();
            var boiler2 = ChocolateBoiler.GetInstance();
        }
    }
}

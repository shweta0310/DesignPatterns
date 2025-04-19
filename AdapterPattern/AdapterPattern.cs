namespace DesignPatterns.AdapterPattern
{
    internal class AdapterPattern
    {
        public static void RunPattern()
        {
            Square square = new Square(10);
            SquareToRectangleAdapter adapter = new SquareToRectangleAdapter(square);
            Console.WriteLine($"Area of square: {adapter.Area()}");
        }
    }
}

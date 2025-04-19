namespace DesignPatterns.AdapterPattern
{
    internal class Square
    {
        public int Width { get; }
        public Square(int width)
        {
            Width = width;
        }
    }

    internal class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square _square;
        public SquareToRectangleAdapter(Square square)
        {
            _square = square;
        }

        public int Width => _square.Width;
        public int Length => _square.Width;
        public int Area()
        {
            return Width * Length;
        }
    }
}

namespace DesignPatterns.AdapterPattern
{
    internal interface IRectangle
    {
        public int Width { get; }
        public int Length { get; }

        public int Area();
    }

    internal class Rectangle : IRectangle
    {
        public int Width { get; }
        public int Length { get; }
        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }
        public int Area()
        {
            return Width * Length;
        }
    }
}

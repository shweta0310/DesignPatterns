namespace DesignPatterns.CompositePattern
{
    internal class File : FileSystemComponent
    {
        private int Size { get; set; }
        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public override void Display(int indentationLevel)
        {
            Console.WriteLine(new string('\t', indentationLevel) + $"File: {Name} Size: {Size}");
        }

        public override int GetSize()
        {
            return Size;
        }
        public virtual void Open()
        {
            Console.WriteLine($"Opening file: {Name}");
        }
        public virtual void Edit()
        {
            Console.WriteLine($"Editing file: {Name}");
        }
        public virtual void Save()
        {
            Console.WriteLine($"Saving file: {Name}");
        }
    }
}

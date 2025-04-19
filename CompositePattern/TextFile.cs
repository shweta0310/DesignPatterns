namespace DesignPatterns.CompositePattern
{
    internal class TextFile : File
    {
        public string Content { get; set; }
        public TextFile(string name, int size, string content) : base(name, size)
        {
            Content = content;
        }

        public override void Open()
        {
            Console.WriteLine($"Opening text file: {Name}");
            Console.WriteLine($"Content: {Content}");
        }
        public override void Edit()
        {
            Console.WriteLine($"Editing text file: {Name}");
        }
        public override void Save()
        {
            Console.WriteLine($"Saving text file: {Name}");
            // Simulate saving the content to a file
            Console.WriteLine($"Text file {Name} saved with content: {Content}");
        }
    }
}

namespace DesignPatterns.CompositePattern
{
    internal class FileSystem
    {
        public Directory RootDirectory { get; set; }
        public FileSystem(Directory directory)
        {
            RootDirectory = directory;
        }
        public void Display()
        {
            RootDirectory.Display(0);
        }
        public void Size()
        {
            Console.WriteLine($"\n\nTotal Size: {RootDirectory.GetSize()} bytes");
        }
        public void Search(string targetName)
        {
            var result = RootDirectory.SearchByName(targetName);
            if (result != null)
            {
                Console.WriteLine($"Found: {result.Name}");
            }
            else
            {
                Console.WriteLine($"Not Found: {targetName}");
            }
        }
    }
}

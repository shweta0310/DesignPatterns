namespace DesignPatterns.CompositePattern
{
    internal class CompositePattern
    {
        public static void RunPattern()
        {
            File file1 = new File("File1.txt", 100);
            File file2 = new File("File2.txt", 200);
            File file3 = new File("File3.txt", 300);
            File file4 = new File("File4.txt", 400);
            Directory directory1 = new Directory("Directory1");
            Directory directory2 = new Directory("Directory2");
            Directory directory3 = new Directory("Directory3");

            directory1.Add(file1);
            directory1.Add(file2);
            directory2.Add(file3);
            directory1.Add(directory2);
            directory3.Add(file4);

            Directory rootDirectory = new Directory("RootDirectory");
            rootDirectory.Add(directory1);
            rootDirectory.Add(directory3);

            FileSystem fileSystem = new FileSystem(rootDirectory);
            fileSystem.Display();
            fileSystem.Size();
            fileSystem.Search("File1.txt");
        }
    }
}

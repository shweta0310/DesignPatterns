using DesignPatterns.IteratorPattern.Interfaces;

namespace DesignPatterns.IteratorPattern
{
    internal class Library
    {
        private readonly List<ILibraryCollection> _collections;
        public Library(List<ILibraryCollection> collections)
        {
            _collections = collections;
        }

        public void ViewCollection(ILibraryIterator iterator)
        {
            while (iterator.HasNext())
            {
                var next = iterator.Next();
                Console.WriteLine(next.ToString());
            }
        }

        public void ViewAllCollections()
        {
            foreach (ILibraryCollection collection in _collections)
            {
                Console.WriteLine($"Viewing collection: {collection.GetType().Name}");
                var iterator = collection.CreateIterator();
                ViewCollection(iterator);
            }
        }
    }
}

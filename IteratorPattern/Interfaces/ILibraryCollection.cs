namespace DesignPatterns.IteratorPattern.Interfaces
{
    internal interface ILibraryCollection
    {
        ILibraryIterator CreateIterator();
        void AddItems(ILibraryItem item);
        void RemoveItems(ILibraryItem item);
    }
}

namespace DesignPatterns.IteratorPattern.Interfaces
{
    internal interface ILibraryIterator
    {
        ILibraryItem Next();
        bool HasNext();
    }
}

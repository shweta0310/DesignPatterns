using DesignPatterns.IteratorPattern.Interfaces;
using DesignPatterns.IteratorPattern.Iterators;
using DesignPatterns.IteratorPattern.LibraryItems;

namespace DesignPatterns.IteratorPattern.Collections
{
    internal class BookCollection : ILibraryCollection
    {
        private readonly List<Book> _books;
        public BookCollection()
        {
            _books = new List<Book>();
        }

        public ILibraryIterator CreateIterator()
        {
            return new BookIterator(_books);
        }

        public ILibraryIterator CreateAuthorIterator()
        {
            return new BookAuthorIterator(_books);
        }
        public ILibraryIterator CreateYearIterator()
        {
            return new BookYearIterator(_books);
        }
        public void AddItems(ILibraryItem item)
        {
            _books.Add(item as Book);
        }

        public void RemoveItems(ILibraryItem item)
        {
            _books.Remove(item as Book);
        }
    }
}

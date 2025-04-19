using DesignPatterns.IteratorPattern.Interfaces;
using DesignPatterns.IteratorPattern.LibraryItems;

namespace DesignPatterns.IteratorPattern.Iterators
{
    internal class BookIterator : ILibraryIterator
    {
        private readonly List<Book> _books;
        private int _position = 0;
        public BookIterator(List<Book> books)
        {
            _books = books.OrderBy(b => b.Title).ToList();
        }

        public bool HasNext()
        {
            if (_position >= _books.Count || _books[_position] == null)
                return false;
            return true;
        }

        public ILibraryItem Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more books in the collection.");
            }
            return _books[_position++];
        }
    }
}

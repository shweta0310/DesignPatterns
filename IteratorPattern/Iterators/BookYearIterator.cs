using DesignPatterns.IteratorPattern.Interfaces;
using DesignPatterns.IteratorPattern.LibraryItems;

namespace DesignPatterns.IteratorPattern.Iterators
{
    internal class BookYearIterator : ILibraryIterator
    {
        private readonly List<Book> _books;
        private int _position = 0;
        public BookYearIterator(List<Book> books)
        {
            _books = books.OrderBy(b => b.PublicationYear).ToList();
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

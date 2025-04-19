using DesignPatterns.IteratorPattern.Collections;
using DesignPatterns.IteratorPattern.Interfaces;
using DesignPatterns.IteratorPattern.LibraryItems;

namespace DesignPatterns.IteratorPattern
{
    internal class IteratorPattern
    {
        public static void RunPattern()
        {
            var bookCollection = new BookCollection();
            var book1 = new Book("The Great Gatsby", "2000", "F. Scott Fitzgerald", "Thriller", "00112");
            var book2 = new Book("To Kill a Mockingbird", "2005", "Harper Lee", "Drama", "00113");
            var book3 = new Book("1984", "2010", "George Orwell", "Dystopian", "00114");
            bookCollection.AddItems(book1);
            bookCollection.AddItems(book2);
            bookCollection.AddItems(book3);

            var bookIterator = bookCollection.CreateIterator();
            var bookAuthorIterator = bookCollection.CreateAuthorIterator();
            var bookYearIterator = bookCollection.CreateYearIterator();

            var library = new Library(new List<ILibraryCollection> { bookCollection });
            Console.WriteLine("Viewing books by title:");
            library.ViewCollection(bookIterator);

            Console.WriteLine("Viewing books by author:");
            library.ViewCollection(bookAuthorIterator);

            Console.WriteLine("Viewing books by year:");
            library.ViewCollection(bookYearIterator);

        }
    }
}

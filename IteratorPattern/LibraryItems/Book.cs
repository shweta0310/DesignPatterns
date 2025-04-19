using DesignPatterns.IteratorPattern.Interfaces;

namespace DesignPatterns.IteratorPattern.LibraryItems
{
    internal class Book : ILibraryItem
    {
        public string Title { get; set; }
        public string PublicationYear { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string publicationYear, string author, string genre, string iSBN)
        {
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
            Genre = genre;
            ISBN = iSBN;
        }

        public override string ToString()
        {
            return $"[Book] Title: {Title}, Publication Year: {PublicationYear}, Author: {Author}, Genre: {Genre}, ISBN: {ISBN}";
        }
    }
}

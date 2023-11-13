using System;
using _02_library_catalog.Models;

namespace _02_library_catalog
{
    class Program
    {
        public static void Main(string[] args)
        {
            Library library = new("Test Library", "Test, Test Area");
            Book firstBook = new("First Book", "First Author", "0451524934", new DateOnly(2000, 10, 10));
            Book secondBook = new("Second Book", "Second Author", "0743273567", new DateOnly(2001, 10, 10));

            MediaItem firstMediaItem = new("First Media Item", "First Media Item Type", 10);
            MediaItem secondMediaItem = new("Second Media Item", "Second Media Item Type", 20);

            library.AddBook(firstBook);
            library.AddBook(secondBook);

            library.AddMediaItem(firstMediaItem);
            library.AddMediaItem(secondMediaItem);

            library.PrintCatalog();
        }
    }
}
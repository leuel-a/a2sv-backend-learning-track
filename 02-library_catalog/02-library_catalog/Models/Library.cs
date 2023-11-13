namespace _02_library_catalog.Models;

public class Library : Base
{
    private string Name { get; set; }
    public string Address { get; set; }
    private readonly List<Book> _books = new List<Book>();
    private readonly List<MediaItem>_mediaItems = new List<MediaItem>();

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public bool AddBook(Book? newBook)
    {
        if (newBook == null) return false;
        _books.Add(newBook);
        return true;
    }

    public bool RemoveBook(Book? toRemoveBook)
    {
        return toRemoveBook != null && _books.Remove(toRemoveBook);
    }

    public bool AddMediaItem(MediaItem? newMediaItem)
    {
        if (newMediaItem == null) return false;
        _mediaItems.Add(newMediaItem);
        return true;
    }

    public bool RemoveMediaItem(MediaItem? toRemoveMediaItem)
    {
        return toRemoveMediaItem != null && _mediaItems.Remove(toRemoveMediaItem);
    }

    public void PrintCatalog()
    {
        Console.WriteLine($"{Name} Library Catalog: ");
        Console.WriteLine($"Books: ");
        foreach (var book in _books)
        {
            Console.WriteLine(book.ToString());
        }
        Console.WriteLine("");
        
        Console.WriteLine($"Media Items: ");
        foreach (var mediaItem in _mediaItems)
        {
            Console.WriteLine(mediaItem.ToString());
        }
    }
}
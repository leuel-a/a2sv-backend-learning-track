namespace _02_library_catalog.Models;

public class Book : Base
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
    public DateOnly PublicationYear { get; set; }
    
    public Book(string title, string author, string isbn, DateOnly publicationDate)
    {
        Isbn = isbn;
        Title = title;
        Author = author;
        PublicationYear = publicationDate;
    }

    public override string ToString()
    {
        return $"{this.Title} -- {this.Author} -- {this.PublicationYear}";
    }
}
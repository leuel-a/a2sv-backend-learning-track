namespace _02_library_catalog.Models;

public class Base
{
    public string Id { get; private set; }
    public string CreatedAt { get; private set; }

    protected Base()
    {
        Id = Guid.NewGuid().ToString();
        CreatedAt = DateTime.Today.ToShortDateString();
    }
}
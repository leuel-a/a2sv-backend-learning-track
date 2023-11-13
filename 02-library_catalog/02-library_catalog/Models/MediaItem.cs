namespace _02_library_catalog.Models;

public class MediaItem
{
    public string Title { get; set; }
    public string MediaType { get; set; }
    public int Duration { get; set; }

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        MediaType = mediaType;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"{this.Title} -- {this.MediaType} -- {this.Duration}";
    }
}
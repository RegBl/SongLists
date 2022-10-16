namespace SongLists;

public class SongList
{
    public List<Song> Songs { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateTimeCreated { get; set; }
}
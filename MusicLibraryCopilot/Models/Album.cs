namespace MusicLibraryCopilot.Models;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int ArtistId { get; set; }
    public int GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int? TotalTracks { get; set; }
    public string? RecordLabel { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual Artist? Artist { get; set; }
    public virtual Genre? Genre { get; set; }
    public virtual ICollection<Song> Songs { get; set; } = [];
}

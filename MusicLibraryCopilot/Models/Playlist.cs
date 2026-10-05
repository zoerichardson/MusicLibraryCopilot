namespace MusicLibraryCopilot.Models;

public class Playlist
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int UserId { get; set; }
    public bool IsPublic { get; set; } = false;
    public string? CoverImageUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual User? User { get; set; }
    public virtual ICollection<Song> Songs { get; set; } = [];
}

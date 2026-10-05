namespace MusicLibraryCopilot.Models;

public class Artist
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Biography { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Country { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual ICollection<Album> Albums { get; set; } = [];
    public virtual ICollection<Song> Songs { get; set; } = [];
}

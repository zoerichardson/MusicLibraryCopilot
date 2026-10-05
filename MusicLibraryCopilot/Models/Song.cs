namespace MusicLibraryCopilot.Models;

public class Song
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Lyrics { get; set; }
    public int ArtistId { get; set; }
    public int AlbumId { get; set; }
    public int? TrackNumber { get; set; }
    public int DurationInSeconds { get; set; }
    public string? AudioUrl { get; set; }
    public int PlayCount { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public virtual Artist? Artist { get; set; }
    public virtual Album? Album { get; set; }
    public virtual ICollection<Playlist> Playlists { get; set; } = [];
    public virtual ICollection<UserFavorite> UserFavorites { get; set; } = [];
}

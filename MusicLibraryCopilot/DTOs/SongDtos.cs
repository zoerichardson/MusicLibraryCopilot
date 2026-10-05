namespace MusicLibraryCopilot.DTOs;

public class CreateSongDto
{
    public required string Title { get; set; }
    public string? Lyrics { get; set; }
    public int ArtistId { get; set; }
    public int AlbumId { get; set; }
    public int? TrackNumber { get; set; }
    public int DurationInSeconds { get; set; }
    public string? AudioUrl { get; set; }
}

public class UpdateSongDto
{
    public string? Title { get; set; }
    public string? Lyrics { get; set; }
    public int? TrackNumber { get; set; }
    public int? DurationInSeconds { get; set; }
    public string? AudioUrl { get; set; }
}

public class SongDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Lyrics { get; set; }
    public int ArtistId { get; set; }
    public int AlbumId { get; set; }
    public int? TrackNumber { get; set; }
    public int DurationInSeconds { get; set; }
    public string? AudioUrl { get; set; }
    public int PlayCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

namespace MusicLibraryCopilot.DTOs;

public class CreateAlbumDto
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int ArtistId { get; set; }
    public int GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int? TotalTracks { get; set; }
    public string? RecordLabel { get; set; }
}

public class UpdateAlbumDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int? GenreId { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public int? TotalTracks { get; set; }
    public string? RecordLabel { get; set; }
}

public class AlbumDto
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
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

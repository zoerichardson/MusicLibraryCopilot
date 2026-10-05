namespace MusicLibraryCopilot.DTOs;

public class CreatePlaylistDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public bool IsPublic { get; set; } = false;
}

public class UpdatePlaylistDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public bool? IsPublic { get; set; }
}

public class PlaylistDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int UserId { get; set; }
    public bool IsPublic { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class PlaylistWithSongsDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? CoverImageUrl { get; set; }
    public int UserId { get; set; }
    public bool IsPublic { get; set; }
    public List<SongDto> Songs { get; set; } = [];
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

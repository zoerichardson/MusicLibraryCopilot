namespace MusicLibraryCopilot.DTOs;

public class CreateArtistDto
{
    public required string Name { get; set; }
    public string? Biography { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Country { get; set; }
}

public class UpdateArtistDto
{
    public string? Name { get; set; }
    public string? Biography { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Country { get; set; }
}

public class ArtistDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Biography { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Country { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

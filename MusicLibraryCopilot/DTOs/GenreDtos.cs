namespace MusicLibraryCopilot.DTOs;

public class CreateGenreDto
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}

public class UpdateGenreDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}

public class GenreDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

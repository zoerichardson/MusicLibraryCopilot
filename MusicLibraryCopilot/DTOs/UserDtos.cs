namespace MusicLibraryCopilot.DTOs;

public class CreateUserDto
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public string? DisplayName { get; set; }
    public string? Bio { get; set; }
}

public class UpdateUserDto
{
    public string? DisplayName { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? Bio { get; set; }
}

public class UserDto
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public string? DisplayName { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? Bio { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

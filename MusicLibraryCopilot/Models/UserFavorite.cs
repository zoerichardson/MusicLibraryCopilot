namespace MusicLibraryCopilot.Models;

public class UserFavorite
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int SongId { get; set; }
    public DateTime FavoritedAt { get; set; } = DateTime.UtcNow;

    public virtual User? User { get; set; }
    public virtual Song? Song { get; set; }
}

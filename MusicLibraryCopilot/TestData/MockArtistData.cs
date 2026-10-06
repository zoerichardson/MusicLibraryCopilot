using MusicLibraryCopilot.Models;

namespace MusicLibraryCopilot.TestData;

public static class MockArtistData
{
    public static List<Artist> GetMockArtists()
    {
        return new List<Artist>
        {
            new Artist
            {
                Id = 1,
                Name = "The Beatles",
                Biography = "The Beatles were an English rock band formed in Liverpool in 1960.",
                ImageUrl = "https://via.placeholder.com/150?text=The+Beatles",
                BirthDate = new DateTime(1960, 1, 1),
                Country = "United Kingdom",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Artist
            {
                Id = 2,
                Name = "David Bowie",
                Biography = "David Robert Jones was an English rock musician and actor famous for his frequent reinventions.",
                ImageUrl = "https://via.placeholder.com/150?text=David+Bowie",
                BirthDate = new DateTime(1947, 1, 8),
                Country = "United Kingdom",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Artist
            {
                Id = 3,
                Name = "Queen",
                Biography = "Queen is a British rock band formed in London in 1970.",
                ImageUrl = "https://via.placeholder.com/150?text=Queen",
                BirthDate = new DateTime(1970, 1, 1),
                Country = "United Kingdom",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Artist
            {
                Id = 4,
                Name = "Pink Floyd",
                Biography = "Pink Floyd were an English rock band that achieved international acclaim.",
                ImageUrl = "https://via.placeholder.com/150?text=Pink+Floyd",
                BirthDate = new DateTime(1965, 1, 1),
                Country = "United Kingdom",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Artist
            {
                Id = 5,
                Name = "Adele",
                Biography = "Adele is an English singer-songwriter known for her powerful vocals and emotional ballads.",
                ImageUrl = "https://via.placeholder.com/150?text=Adele",
                BirthDate = new DateTime(1988, 5, 5),
                Country = "United Kingdom",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };
    }

    public static Artist GetMockArtist(int id = 1)
    {
        return GetMockArtists().FirstOrDefault(a => a.Id == id) 
            ?? throw new InvalidOperationException($"Mock artist with id {id} not found");
    }
}

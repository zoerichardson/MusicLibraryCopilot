using Microsoft.AspNetCore.Mvc;
using MusicLibraryCopilot.DTOs;
using MusicLibraryCopilot.Models;

namespace MusicLibraryCopilot.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArtistsController : ControllerBase
{
    private static readonly List<Artist> Artists = [];

    [HttpGet]
    public ActionResult<IEnumerable<ArtistDto>> GetAllArtists()
    {
        var artistDtos = Artists.Select(a => new ArtistDto
        {
            Id = a.Id,
            Name = a.Name,
            Biography = a.Biography,
            ImageUrl = a.ImageUrl,
            BirthDate = a.BirthDate,
            Country = a.Country,
            CreatedAt = a.CreatedAt,
            UpdatedAt = a.UpdatedAt
        }).ToList();

        return Ok(artistDtos);
    }

    [HttpGet("{id}")]
    public ActionResult<ArtistDto> GetArtistById(int id)
    {
        var artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
            return NotFound();

        return Ok(new ArtistDto
        {
            Id = artist.Id,
            Name = artist.Name,
            Biography = artist.Biography,
            ImageUrl = artist.ImageUrl,
            BirthDate = artist.BirthDate,
            Country = artist.Country,
            CreatedAt = artist.CreatedAt,
            UpdatedAt = artist.UpdatedAt
        });
    }

    [HttpPost]
    public ActionResult<ArtistDto> CreateArtist([FromBody] CreateArtistDto dto)
    {
        var artist = new Artist
        {
            Id = Artists.Count > 0 ? Artists.Max(a => a.Id) + 1 : 1,
            Name = dto.Name,
            Biography = dto.Biography,
            ImageUrl = dto.ImageUrl,
            BirthDate = dto.BirthDate,
            Country = dto.Country,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        Artists.Add(artist);

        return CreatedAtAction(nameof(GetArtistById), new { id = artist.Id }, new ArtistDto
        {
            Id = artist.Id,
            Name = artist.Name,
            Biography = artist.Biography,
            ImageUrl = artist.ImageUrl,
            BirthDate = artist.BirthDate,
            Country = artist.Country,
            CreatedAt = artist.CreatedAt,
            UpdatedAt = artist.UpdatedAt
        });
    }

    [HttpPut("{id}")]
    public ActionResult<ArtistDto> UpdateArtist(int id, [FromBody] UpdateArtistDto dto)
    {
        var artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
            return NotFound();

        if (!string.IsNullOrEmpty(dto.Name))
            artist.Name = dto.Name;
        if (dto.Biography != null)
            artist.Biography = dto.Biography;
        if (dto.ImageUrl != null)
            artist.ImageUrl = dto.ImageUrl;
        if (dto.BirthDate.HasValue)
            artist.BirthDate = dto.BirthDate;
        if (dto.Country != null)
            artist.Country = dto.Country;
        artist.UpdatedAt = DateTime.UtcNow;

        return Ok(new ArtistDto
        {
            Id = artist.Id,
            Name = artist.Name,
            Biography = artist.Biography,
            ImageUrl = artist.ImageUrl,
            BirthDate = artist.BirthDate,
            Country = artist.Country,
            CreatedAt = artist.CreatedAt,
            UpdatedAt = artist.UpdatedAt
        });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteArtist(int id)
    {
        var artist = Artists.FirstOrDefault(a => a.Id == id);
        if (artist == null)
            return NotFound();

        Artists.Remove(artist);
        return NoContent();
    }
}

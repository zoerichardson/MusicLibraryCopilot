using Microsoft.AspNetCore.Mvc;
using MusicLibraryCopilot.DTOs;
using MusicLibraryCopilot.Models;

namespace MusicLibraryCopilot.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenresController : ControllerBase
{
    private static readonly List<Genre> Genres = [];

    [HttpGet]
    public ActionResult<IEnumerable<GenreDto>> GetAllGenres()
    {
        var genreDtos = Genres.Select(g => new GenreDto
        {
            Id = g.Id,
            Name = g.Name,
            Description = g.Description,
            CreatedAt = g.CreatedAt,
            UpdatedAt = g.UpdatedAt
        }).ToList();

        return Ok(genreDtos);
    }

    [HttpGet("{id}")]
    public ActionResult<GenreDto> GetGenreById(int id)
    {
        var genre = Genres.FirstOrDefault(g => g.Id == id);
        if (genre == null)
            return NotFound();

        return Ok(new GenreDto
        {
            Id = genre.Id,
            Name = genre.Name,
            Description = genre.Description,
            CreatedAt = genre.CreatedAt,
            UpdatedAt = genre.UpdatedAt
        });
    }

    [HttpPost]
    public ActionResult<GenreDto> CreateGenre([FromBody] CreateGenreDto dto)
    {
        var genre = new Genre
        {
            Id = Genres.Count > 0 ? Genres.Max(g => g.Id) + 1 : 1,
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        Genres.Add(genre);

        return CreatedAtAction(nameof(GetGenreById), new { id = genre.Id }, new GenreDto
        {
            Id = genre.Id,
            Name = genre.Name,
            Description = genre.Description,
            CreatedAt = genre.CreatedAt,
            UpdatedAt = genre.UpdatedAt
        });
    }

    [HttpPut("{id}")]
    public ActionResult<GenreDto> UpdateGenre(int id, [FromBody] UpdateGenreDto dto)
    {
        var genre = Genres.FirstOrDefault(g => g.Id == id);
        if (genre == null)
            return NotFound();

        if (!string.IsNullOrEmpty(dto.Name))
            genre.Name = dto.Name;
        if (dto.Description != null)
            genre.Description = dto.Description;
        genre.UpdatedAt = DateTime.UtcNow;

        return Ok(new GenreDto
        {
            Id = genre.Id,
            Name = genre.Name,
            Description = genre.Description,
            CreatedAt = genre.CreatedAt,
            UpdatedAt = genre.UpdatedAt
        });
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteGenre(int id)
    {
        var genre = Genres.FirstOrDefault(g => g.Id == id);
        if (genre == null)
            return NotFound();

        Genres.Remove(genre);
        return NoContent();
    }
}

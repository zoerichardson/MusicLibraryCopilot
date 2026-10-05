# Music Library API - Documentation

## Overview
A comprehensive RESTful API for managing a music library, built with ASP.NET Core 10.0. The API provides full CRUD operations for artists, genres, albums, songs, playlists, and users.

## Models Overview

### Core Entities

#### 1. **Artist** (`Models/Artist.cs`)
Represents a music artist in the library.

**Properties:**
- `Id` (int) - Unique identifier
- `Name` (string) - Artist name
- `Biography` (string) - Artist biography
- `ImageUrl` (string) - Profile image URL
- `BirthDate` (DateTime) - Date of birth
- `Country` (string) - Artist country
- `CreatedAt` (DateTime) - Creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `Albums` (ICollection) - Related albums
- `Songs` (ICollection) - Related songs

#### 2. **Genre** (`Models/Genre.cs`)
Represents music genres.

**Properties:**
- `Id` (int) - Unique identifier
- `Name` (string) - Genre name (e.g., "Rock", "Jazz")
- `Description` (string) - Genre description
- `CreatedAt` (DateTime) - Creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `Albums` (ICollection) - Related albums

#### 3. **Album** (`Models/Album.cs`)
Represents a music album.

**Properties:**
- `Id` (int) - Unique identifier
- `Title` (string) - Album title
- `Description` (string) - Album description
- `CoverImageUrl` (string) - Album cover image URL
- `ArtistId` (int) - Foreign key to Artist
- `GenreId` (int) - Foreign key to Genre
- `ReleaseDate` (DateTime) - Album release date
- `TotalTracks` (int) - Total number of tracks
- `RecordLabel` (string) - Record label name
- `CreatedAt` (DateTime) - Creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `Artist` (Artist) - Related artist
- `Genre` (Genre) - Related genre
- `Songs` (ICollection) - Album songs

#### 4. **Song** (`Models/Song.cs`)
Represents a music track.

**Properties:**
- `Id` (int) - Unique identifier
- `Title` (string) - Song title
- `Lyrics` (string) - Song lyrics
- `ArtistId` (int) - Foreign key to Artist
- `AlbumId` (int) - Foreign key to Album
- `TrackNumber` (int) - Track position on album
- `DurationInSeconds` (int) - Song duration
- `AudioUrl` (string) - Audio file URL
- `PlayCount` (int) - Number of plays
- `CreatedAt` (DateTime) - Creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `Artist` (Artist) - Related artist
- `Album` (Album) - Related album
- `Playlists` (ICollection) - Playlists containing this song
- `UserFavorites` (ICollection) - Users who favorited this song

#### 5. **Playlist** (`Models/Playlist.cs`)
Represents user-created playlists.

**Properties:**
- `Id` (int) - Unique identifier
- `Name` (string) - Playlist name
- `Description` (string) - Playlist description
- `UserId` (int) - Foreign key to User
- `IsPublic` (bool) - Public/private flag
- `CoverImageUrl` (string) - Playlist cover image URL
- `CreatedAt` (DateTime) - Creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `User` (User) - Playlist owner
- `Songs` (ICollection) - Songs in playlist

#### 6. **User** (`Models/User.cs`)
Represents application users.

**Properties:**
- `Id` (int) - Unique identifier
- `Username` (string) - Unique username
- `Email` (string) - Email address
- `DisplayName` (string) - Public display name
- `ProfileImageUrl` (string) - Profile image URL
- `Bio` (string) - User biography
- `CreatedAt` (DateTime) - Account creation timestamp
- `UpdatedAt` (DateTime) - Last update timestamp
- `Playlists` (ICollection) - User's playlists
- `UserFavorites` (ICollection) - User's favorite songs

#### 7. **UserFavorite** (`Models/UserFavorite.cs`)
Junction table for user favorites (many-to-many).

**Properties:**
- `Id` (int) - Unique identifier
- `UserId` (int) - Foreign key to User
- `SongId` (int) - Foreign key to Song
- `FavoritedAt` (DateTime) - When favorited

## Data Transfer Objects (DTOs)

### Purpose
DTOs separate external API contracts from internal domain models, allowing flexibility in API design.

### Available DTOs

#### ArtistDtos
- `CreateArtistDto` - Create artist request
- `UpdateArtistDto` - Update artist request
- `ArtistDto` - Artist response

#### GenreDtos
- `CreateGenreDto` - Create genre request
- `UpdateGenreDto` - Update genre request
- `GenreDto` - Genre response

#### AlbumDtos
- `CreateAlbumDto` - Create album request
- `UpdateAlbumDto` - Update album request
- `AlbumDto` - Album response

#### SongDtos
- `CreateSongDto` - Create song request
- `UpdateSongDto` - Update song request
- `SongDto` - Song response

#### PlaylistDtos
- `CreatePlaylistDto` - Create playlist request
- `UpdatePlaylistDto` - Update playlist request
- `PlaylistDto` - Playlist response
- `PlaylistWithSongsDto` - Playlist with related songs

#### UserDtos
- `CreateUserDto` - Create user request
- `UpdateUserDto` - Update user request
- `UserDto` - User response

## API Endpoints

### Currently Implemented

#### Artists Controller (`/api/artists`)
- `GET /api/artists` - Get all artists
- `GET /api/artists/{id}` - Get artist by ID
- `POST /api/artists` - Create new artist
- `PUT /api/artists/{id}` - Update artist
- `DELETE /api/artists/{id}` - Delete artist

#### Genres Controller (`/api/genres`)
- `GET /api/genres` - Get all genres
- `GET /api/genres/{id}` - Get genre by ID
- `POST /api/genres` - Create new genre
- `PUT /api/genres/{id}` - Update genre
- `DELETE /api/genres/{id}` - Delete genre

### To Be Implemented

Similar CRUD endpoints for:
- Albums (`/api/albums`)
- Songs (`/api/songs`)
- Playlists (`/api/playlists`)
- Users (`/api/users`)
- User Favorites (`/api/favorites`)

## Relationships

### Entity Relationships
```
Artist (1) ──────────── (Many) Album
		 └──────────────── (Many) Song

Genre (1) ───────────── (Many) Album

Album (1) ───────────── (Many) Song

User (1) ────────────── (Many) Playlist
	  └─────────────── (Many) UserFavorite

Song (Many-to-Many) ──── Playlist

Song (1) ───────────── (Many) UserFavorite
User (1) ───────────── (Many) UserFavorite
```

## Technical Details

### Technology Stack
- **Framework**: ASP.NET Core 10.0
- **API Style**: RESTful with MVC pattern
- **Documentation**: OpenAPI/Swagger
- **Response Format**: JSON

### Design Patterns Used
- **Repository Pattern** - (Recommended for future database implementation)
- **DTO Pattern** - Separating API contracts from domain models
- **SOLID Principles** - Clean, maintainable code structure

### Current Storage
- **In-Memory Collections** - For demonstration
- **Production Ready**: Requires database implementation (SQL Server, PostgreSQL, etc.)

## Future Enhancements

1. **Database Integration**
   - Entity Framework Core implementation
   - Migration support
   - Performance optimization

2. **Authentication & Authorization**
   - JWT token support
   - Role-based access control
   - User authentication

3. **Advanced Features**
   - Pagination & filtering
   - Search functionality
   - Recommendations engine
   - Statistics & analytics

4. **Additional Endpoints**
   - Trending songs/albums
   - User following
   - Comments/ratings
   - Download history

5. **Performance**
   - Caching (Redis)
   - Async operations
   - Connection pooling

## Getting Started

### Build the Project
```bash
dotnet build
```

### Run the Application
```bash
dotnet run
```

The API will be available at: `https://localhost:5001`

### Test the API
Use the HTTP file included (`MusicLibraryCopilot.http`) or any HTTP client:
- Postman
- Thunder Client
- VS Code REST Client

### Example Request

**Create an Artist:**
```
POST /api/artists
Content-Type: application/json

{
  "name": "The Beatles",
  "biography": "British rock band from Liverpool",
  "country": "United Kingdom",
  "birthDate": "1960-01-01"
}
```

**Response:**
```
201 Created
{
  "id": 1,
  "name": "The Beatles",
  "biography": "British rock band from Liverpool",
  "country": "United Kingdom",
  "birthDate": "1960-01-01T00:00:00Z",
  "imageUrl": null,
  "createdAt": "2024-01-15T10:30:00Z",
  "updatedAt": "2024-01-15T10:30:00Z"
}
```

## Notes

- All timestamps are stored in UTC
- The `required` keyword on properties indicates they are mandatory
- DTOs use nullable strings for optional fields
- In-memory storage is suitable for development/testing only

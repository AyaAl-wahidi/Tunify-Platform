using Tunify_Platform.Models;

namespace Tunify_Platform.Repositories.Interfaces
{
    public interface IArtist 
    {
        Task<Artist> CreateArtist(Artist artist);
        Task<List<Artist>> GetAllArtist();
        Task<Artist> GetArtistById(int artistId);
        Task<Artist> UpdateArtist(int id, Artist artist);
        Task DeleteArtist(int id);
        Task<Song> AddSongToArtist(int artistId, int songId);
        Task<List<Song>> GetAllSongsFromArtistId(int artistId);
    }
}
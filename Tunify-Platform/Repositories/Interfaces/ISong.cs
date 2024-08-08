using Tunify_Platform.Models;

namespace Tunify_Platform.Repositories.Interfaces
{
    public interface ISong
    {
        Task<Song> CreateSong(Song song);
        Task<List<Song>> GetAllSongs();
        Task<Song> GetSongById(int songId);
        Task<Song> UpdateSong(int id, Song song);
        Task DeleteSong(int id);
    }
}
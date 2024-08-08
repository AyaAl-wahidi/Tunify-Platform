using Tunify_Platform.Models;

namespace Tunify_Platform.Repositories.Interfaces
{
    public interface IPlaylist
    {
        Task<Playlist> CreatePlaylist(Playlist playlist);
        Task<List<Playlist>> GetAllPlaylist();
        Task<Playlist> GetPlaylistById(int playlistId);
        Task<Playlist> UpdatePlaylist(int id, Playlist playlist);
        Task DeletePlaylist(int id);
    }
}
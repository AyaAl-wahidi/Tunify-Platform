using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class PlaylistServise : IPlaylist
    {
        private readonly TunifyDbContext _context;

        public PlaylistServise(TunifyDbContext context)
        {
            _context = context;
        }
        public async Task<Playlist> CreatePlaylist(Playlist playlist)
        {
            try
            {
                _context.Entry(playlist).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return playlist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task DeletePlaylist(int id)
        {
            try
            {
                var playlist = await GetPlaylistById(id);
                _context.Entry(playlist).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task<List<Playlist>> GetAllPlaylist()
        {
            try
            {
                var allPlaylists = await _context.Playlist.ToListAsync();
                return allPlaylists;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Playlist> GetPlaylistById(int playlistId)
        {
            try
            {
                var playlist = await _context.Playlist.FindAsync(playlistId);
                return playlist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Playlist> UpdatePlaylist(int id, Playlist playlist)
        {
            try
            {
                _context.Entry(playlist).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return playlist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
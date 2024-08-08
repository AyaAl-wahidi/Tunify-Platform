using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class SongService : ISong
    {
        private readonly TunifyDbContext _context;

        public SongService(TunifyDbContext context)
        {
            _context = context;
        }
        public async Task<Song> CreateSong(Song song)
        {
            try
            {
                _context.Entry(song).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return song;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task DeleteSong(int id)
        {
            try
            {
                var song = await GetSongById(id);
                _context.Entry(song).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task<List<Song>> GetAllSongs()
        {
            try
            {
                var allSongs = await _context.Song.ToListAsync();
                return allSongs;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Song> GetSongById(int songId)
        {
            try
            {
                var song = await _context.Song.FindAsync(songId);
                return song;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Song> UpdateSong(int id, Song song)
        {
            try
            {
                _context.Entry(song).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return song;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class ArtistService : IArtist
    {
        private readonly TunifyDbContext _context;

        public ArtistService(TunifyDbContext context)
        {
            _context = context;
        }

        public async Task<Artist> CreateArtist(Artist artist)
        {
            try
            {
                _context.Entry(artist).State = EntityState.Added;
                await _context.SaveChangesAsync();
                return artist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task DeleteArtist(int id)
        {
            try
            {
                var artist = await GetArtistById(id);
                _context.Entry(artist).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task<List<Artist>> GetAllArtist()
        {
            try
            {
                var allArtists = await _context.Artist.ToListAsync();
                return allArtists;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Artist> GetArtistById(int artistId)
        {
            try
            {
                var artist = await _context.Artist.FindAsync(artistId);
                return artist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Artist> UpdateArtist(int id, Artist artist)
        {
            try
            {
                _context.Entry(artist).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return artist;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Song> AddSongToArtist(int artistId, int songId)
        {
            var song = await _context.Song.FindAsync(songId);
            if (song != null)
            {
                song.ArtistId = artistId;
                _context.Entry(song).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            var songs = _context.Song.Where(a => a.ArtistId == artistId).FirstOrDefault();
            return songs;
        }

        public async Task<List<Song>> GetAllSongsFromArtistId(int artistId)
        {
            var allSongs = await _context.Song
              .Where(ps => ps.ArtistId == artistId)
              .ToListAsync();

            return allSongs;
        }
    }
}
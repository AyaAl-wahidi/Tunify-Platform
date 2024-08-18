using Microsoft.AspNetCore.Mvc;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtist _context;

        public ArtistsController(IArtist context)
        {
            _context = context;
        }

        // GET: api/Artists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtist()
        {
            return await _context.GetAllArtist();
        }

        // GET: api/Artists/5
        [Route("/GetAllArtists")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            return await _context.GetArtistById(id);
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist(int id, Artist artist)
        {
            var updateUser = await _context.UpdateArtist(id, artist);
            return Ok(updateUser);
        }

        // POST: api/Artists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        {
            var addUser = await _context.CreateArtist(artist);
            return Ok(addUser);
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            var deleteUser = _context.DeleteArtist(id);
            return Ok();
        }

        [HttpPost("{artistId}/songs/{songId}")]
        public async Task<Song> AddSongToArtist(int artistId, int songId)
        {
            var Song = await _context.AddSongToArtist(artistId, songId);
            return Song;
        }

        [HttpGet("{artistId}/songs")]
        public async Task<ActionResult<IEnumerable<Song>>> GetAllSongsFromArtistId(int artistId)
        {
            var songs = await _context.GetAllSongsFromArtistId(artistId);
            if (songs == null || !songs.Any())
            {
                return NotFound($"No songs found for playlist with ID {artistId}");
            }
            return songs;
        }
    }
}
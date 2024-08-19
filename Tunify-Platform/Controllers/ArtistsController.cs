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
        public async Task<ActionResult<IEnumerable<Artist>>> GetArtists()
        {
            return await _context.GetAllArtist();
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            var artist = await _context.GetArtistById(id);
            if (artist == null)
            {
                return NotFound();
            }
            return artist;
        }

        // PUT: api/Artists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtist(int ArtistId, [FromBody] Artist artist)
        {
            if (ArtistId != artist.ArtistId)
            {
                return BadRequest("Artist ID mismatch");
            }

            var updatedArtist = await _context.UpdateArtist(ArtistId, artist);
            if (updatedArtist == null)
            {
                return NotFound();
            }

            return Ok(updatedArtist);
        }

        // POST: api/Artists
        [HttpPost]
        public async Task<ActionResult<Artist>> AddArtist([FromBody] Artist artist)
        {
            var addedArtist = await _context.CreateArtist(artist);
            return CreatedAtAction(nameof(GetArtist), new { id = addedArtist.ArtistId }, addedArtist);
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            try
            {
                var artist = await _context.GetArtistById(id);
                if (artist == null)
                {
                    return NotFound();
                }

                await _context.DeleteArtist(id);
                return Ok();
            }
            catch (Exception e)
            {
                // Log the error
                Console.WriteLine($"An error occurred: {e.Message}");
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        // POST: api/Artists/{artistId}/songs/{songId}
        [HttpPost("{artistId}/songs/{songId}")]
        public async Task<ActionResult<Song>> AddSongToArtist(int artistId, int songId)
        {
            var song = await _context.AddSongToArtist(artistId, songId);
            if (song == null)
            {
                return NotFound($"Song with ID {songId} not found or could not be added to artist with ID {artistId}");
            }
            return Ok(song);
        }

        // GET: api/Artists/{artistId}/songs
        [HttpGet("{artistId}/songs")]
        public async Task<ActionResult<IEnumerable<Song>>> GetAllSongsFromArtistId(int artistId)
        {
            var songs = await _context.GetAllSongsFromArtistId(artistId);
            if (songs == null || !songs.Any())
            {
                return NotFound($"No songs found for artist with ID {artistId}");
            }
            return Ok(songs);
        }
    }
}

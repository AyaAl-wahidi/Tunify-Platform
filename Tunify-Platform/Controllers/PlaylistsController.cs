using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Tunify_Platform.Data;


namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private readonly IPlaylist _context;

        public PlaylistsController(IPlaylist context)
        {
            _context = context;
        }

        // GET: api/Playlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Playlist>>> GetPlaylist()
        {
            return await _context.GetAllPlaylist();
        }

        // GET: api/Playlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Playlist>> GetPlaylist(int id)
        {
            return await _context.GetPlaylistById(id);
        }

        // PUT: api/Playlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlaylist(int id, Playlist playlist)
        {
            var updateUser = await _context.UpdatePlaylist(id, playlist);
            return Ok(updateUser);
        }

        // POST: api/Playlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Playlist>> PostPlaylist(Playlist playlist)
        {
            var addUser = await _context.CreatePlaylist(playlist);
            return Ok(addUser);
        }

        // DELETE: api/Playlists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlaylist(int id)
        {
            var deletePlaylist = _context.DeletePlaylist(id);
            return Ok();
        }

        [HttpPost("/{playlistId}/songs/{songId}")]
        public async Task<IActionResult> AddSongToPlaylist(int playlistId, int songId)
        {
            var newSong = _context.AddSongToPlaylist(playlistId, songId);
            return Ok();
        }

        [HttpGet("{playlistId}/songs")]
        public async Task<ActionResult<IEnumerable<Song>>> GetAllSongsFromPlaylistId(int playlistId)
        {
            var songs = await _context.GetAllSongsFromPlaylistId(playlistId);
            if (songs == null || !songs.Any())
            {
                return NotFound($"No songs found for playlist with ID {playlistId}");
            }

            return songs;
        }
    }
}
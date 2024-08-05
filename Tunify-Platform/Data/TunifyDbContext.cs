using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Models;
using System;

namespace Tunify_Platform.Data
{
    public class TunifyDbContext : DbContext
    {
        public TunifyDbContext(DbContextOptions options) : base(options) {}

        public DbSet<User> User { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //User
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "Mario", Email = "mario@gmail.com", Join_Date = new DateTime(2024 - 05 - 05), SubscriptionId = 556 },
                new User { UserId = 2, Username = "Mario2", Email = "mario2@gmail.com", Join_Date = new DateTime(2024 - 06 - 06), SubscriptionId = 557 },
                new User { UserId = 3, Username = "Mario3", Email = "mario3@gmail.com", Join_Date = new DateTime(2024 - 07 - 07), SubscriptionId = 558 }
                );
            //Subscription
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription { SubscriptionId = 1, Subscription_Type = "Free", Price = 0 },
                new Subscription { SubscriptionId = 2, Subscription_Type = "Gold", Price = 9.99 }
            );
            //Song
            modelBuilder.Entity<Song>().HasData(
                new Song { SongId = 1, Title = "Musical1", ArtistId = 1, AlbumId = 1, Duration = TimeSpan.FromMinutes(3), Genre = "Pop" },
                new Song { SongId = 2, Title = "Musical2", ArtistId = 1, AlbumId = 1, Duration = TimeSpan.FromMinutes(4), Genre = "Rock" }
            );
            //Artist
            modelBuilder.Entity<Artist>().HasData(
              new Artist { ArtistId = 1, Name = "Artist1", Bio = "Bio of Artist One" },
              new Artist { ArtistId = 2, Name = "Artist2", Bio = "Bio of Artist Two" }
            );
            //Album
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Album_Name = "Album1", Release_Date = DateTime.Now, ArtistId = 1 },
                new Album { AlbumId = 2, Album_Name = "Album2", Release_Date = DateTime.Now, ArtistId = 2 }
            );
            //Playlist
            modelBuilder.Entity<Playlist>().HasData(
                new Playlist { PlaylistId = 1, UserId = 1, Playlist_Name = "Playlist1", Created_Date = new DateTime(2024 - 05 - 05) },
                new Playlist { PlaylistId = 2, UserId = 2, Playlist_Name = "Playlist2", Created_Date = new DateTime(2024 - 02 - 02) }
            );
            //PlaylistSongs
            modelBuilder.Entity<PlaylistSongs>().HasData(
                new PlaylistSongs { PlaylistSongsId = 1, PlaylistId = 1, SongId = 1 },
                new PlaylistSongs { PlaylistSongsId = 2, PlaylistId = 1, SongId = 2 },
                new PlaylistSongs { PlaylistSongsId = 3, PlaylistId = 2, SongId = 1 }
            );
        }
    }
}
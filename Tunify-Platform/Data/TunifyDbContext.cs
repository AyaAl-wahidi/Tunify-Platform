using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Models;
using System;
using Microsoft.Identity.Client;

namespace Tunify_Platform.Data
{
    public class TunifyDbContext : DbContext
    {
        public TunifyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<PlaylistSongs> PlaylistSongs { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<PlaylistSongs>().HasKey(pk => new { pk.SongId, pk.PlaylistId });

            // PlaylistSongs and Playlist: Many-to-One
            modelBuilder.Entity<PlaylistSongs>()
                .HasOne(ps => ps.Playlist)
                .WithMany(p => p.playlistSongs)
                .HasForeignKey(ps => ps.PlaylistId)
                .OnDelete(DeleteBehavior.Restrict);

            // PlaylistSongs and Songs: Many-to-One
            modelBuilder.Entity<PlaylistSongs>()
                .HasOne(ps => ps.Song)
                .WithMany(s => s.playlistSongs)
                .HasForeignKey(ps => ps.SongId)
                .OnDelete(DeleteBehavior.Restrict);

            // Users and Subscriptions: One-to-Many
            modelBuilder.Entity<User>()
                .HasOne(u => u.Subscription)
                .WithMany(s => s.Users)
                .HasForeignKey(u => u.SubscriptionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Users and Playlists: One-to-Many
            modelBuilder.Entity<Playlist>()
                .HasOne(p => p.User)
                .WithMany(u => u.Playlists)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Songs and Artists: Many-to-One
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Artist)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            // Songs and Albums: Many-to-One
            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);

            // Albums and Artists: Many-to-One
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(ar => ar.Albums)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            // Seeding Subscription data
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription { SubscriptionId = 1, Subscription_Type = "Basic", Price = 9.99 },
                new Subscription { SubscriptionId = 2, Subscription_Type = "Premium", Price = 19.99 }
            );

            // Seeding Artist data
            modelBuilder.Entity<Artist>().HasData(
                new Artist { ArtistId = 1, Name = "Artist One", Bio = "Bio of Artist One" },
                new Artist { ArtistId = 2, Name = "Artist Two", Bio = "Bio of Artist Two" }
            );

            // Seeding Album data
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumId = 1, Album_Name = "Album One", Release_Date = new DateTime(2023, 1, 1), ArtistId = 1 },
                new Album { AlbumId = 2, Album_Name = "Album Two", Release_Date = new DateTime(2023, 6, 1), ArtistId = 2 }
            );

            // Seeding Song data
            modelBuilder.Entity<Song>().HasData(
                new Song { SongId = 1, Title = "Song One", ArtistId = 1, AlbumId = 1, Duration = TimeSpan.FromMinutes(3), Genre = "Pop" },
                new Song { SongId = 2, Title = "Song Two", ArtistId = 2, AlbumId = 2, Duration = TimeSpan.FromMinutes(4), Genre = "Rock" },
                 new Song { SongId = 3, Title = "Song 3", ArtistId = 1, AlbumId = 1, Duration = TimeSpan.FromMinutes(3), Genre = "Pop" },
                new Song { SongId = 4, Title = "Song 4", ArtistId = 2, AlbumId = 2, Duration = TimeSpan.FromMinutes(4), Genre = "Rock" }
            );

            // Seeding User data
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "user1", Email = "user1@example.com", Join_Date = DateTime.Now, SubscriptionId = 1 },
                new User { UserId = 2, Username = "user2", Email = "user2@example.com", Join_Date = DateTime.Now, SubscriptionId = 2 }
            );

            // Seeding Playlist data
            modelBuilder.Entity<Playlist>().HasData(
                new Playlist { PlaylistId = 1, UserId = 1, Playlist_Name = "Playlist One", Created_Date = DateTime.Now },
                new Playlist { PlaylistId = 2, UserId = 2, Playlist_Name = "Playlist Two", Created_Date = DateTime.Now },
                new Playlist { PlaylistId = 3, UserId = 1, Playlist_Name = "Playlist 3", Created_Date = DateTime.Now },
                new Playlist { PlaylistId = 4, UserId = 2, Playlist_Name = "Playlist 4", Created_Date = DateTime.Now }
            );

            // Seeding PlaylistSongs data
            modelBuilder.Entity<PlaylistSongs>().HasData(
                new PlaylistSongs { PlaylistSongsId = 1, PlaylistId = 1, SongId = 1 },
                new PlaylistSongs { PlaylistSongsId = 2, PlaylistId = 2, SongId = 2 }
            );
        }
    }
}
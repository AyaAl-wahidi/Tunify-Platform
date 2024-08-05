using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "Album_Name", "ArtistId", "Release_Date" },
                values: new object[,]
                {
                    { 1, "Album1", 1, new DateTime(2024, 8, 5, 14, 20, 16, 454, DateTimeKind.Local).AddTicks(6958) },
                    { 2, "Album2", 2, new DateTime(2024, 8, 5, 14, 20, 16, 454, DateTimeKind.Local).AddTicks(6973) }
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "Bio of Artist One", "Artist1" },
                    { 2, "Bio of Artist Two", "Artist2" }
                });

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "PlaylistId", "Created_Date", "Playlist_Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014), "Playlist1", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2020), "Playlist2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "ArtistId", "Duration", "Genre", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 0, 3, 0, 0), "Pop", "Musical1" },
                    { 2, 1, 1, new TimeSpan(0, 0, 4, 0, 0), "Rock", "Musical2" }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "SubscriptionId", "Price", "Subscription_Type" },
                values: new object[,]
                {
                    { 1, 0.0, "Free" },
                    { 2, 9.9900000000000002, "Gold" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Join_Date", "SubscriptionId", "Username" },
                values: new object[,]
                {
                    { 1, "mario@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2014), 556, "Mario" },
                    { 2, "mario2@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2012), 557, "Mario2" },
                    { 3, "mario3@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2010), 558, "Mario3" }
                });

            migrationBuilder.InsertData(
                table: "PlaylistSongs",
                columns: new[] { "PlaylistSongsId", "PlaylistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumn: "PlaylistSongsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumn: "PlaylistSongsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaylistSongs",
                keyColumn: "PlaylistSongsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "SubscriptionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "SubscriptionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 2);
        }
    }
}

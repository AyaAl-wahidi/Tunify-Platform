using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_User_SubscriptionId",
                table: "User",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumId",
                table: "Song",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_ArtistId",
                table: "Song",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_UserId",
                table: "Playlist",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistId",
                table: "Album",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Playlist_User_UserId",
                table: "Playlist",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Subscription_SubscriptionId",
                table: "User",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "SubscriptionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Artist_ArtistId",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlist_User_UserId",
                table: "Playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Album_AlbumId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Artist_ArtistId",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Subscription_SubscriptionId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_SubscriptionId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Song_AlbumId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Song_ArtistId",
                table: "Song");

            migrationBuilder.DropIndex(
                name: "IX_Playlist_UserId",
                table: "Playlist");

            migrationBuilder.DropIndex(
                name: "IX_Album_ArtistId",
                table: "Album");

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
    }
}

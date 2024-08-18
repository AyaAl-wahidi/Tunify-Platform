using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "PlaylistId", "Created_Date", "Playlist_Name", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5233), "Playlist 3", 1 },
                    { 4, new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5235), "Playlist 4", 2 }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumId", "ArtistId", "Duration", "Genre", "Title" },
                values: new object[,]
                {
                    { 3, 1, 1, new TimeSpan(0, 0, 3, 0, 0), "Pop", "Song 3" },
                    { 4, 2, 2, new TimeSpan(0, 0, 4, 0, 0), "Rock", "Song 4" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5214));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 17, 9, 15, 343, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 17, 9, 15, 343, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 16, 17, 9, 15, 343, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 16, 17, 9, 15, 343, DateTimeKind.Local).AddTicks(1765));
        }
    }
}

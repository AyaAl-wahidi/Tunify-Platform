using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class RoutingMethods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 17, 16, 26, 33, 396, DateTimeKind.Local).AddTicks(8513));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 16, 18, 31, 50, 244, DateTimeKind.Local).AddTicks(5235));

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
    }
}

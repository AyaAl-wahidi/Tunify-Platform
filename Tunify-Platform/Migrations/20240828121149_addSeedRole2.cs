using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addSeedRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: -552013858);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 132728676);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 629323637);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1854669225);

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 15, 11, 49, 97, DateTimeKind.Local).AddTicks(4800));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { -552013858, "permission", "update", "user" },
                    { 132728676, "permission", "create", "admin" },
                    { 629323637, "permission", "update", "admin" },
                    { 1854669225, "permission", "delete", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 3, 2, 50, 845, DateTimeKind.Local).AddTicks(6465));
        }
    }
}

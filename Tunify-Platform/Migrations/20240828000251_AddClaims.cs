using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "00000000-0000-0000-0000-000000000000", "Admin", "ADMIN" },
                    { "user", "00000000-0000-0000-0000-000000000000", "User", "USER" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "user");

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 22, 16, 51, 8, 362, DateTimeKind.Local).AddTicks(7663));
        }
    }
}

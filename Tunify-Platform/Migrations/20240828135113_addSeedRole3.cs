using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addSeedRole3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { -1504998532, "permission", "create", "admin" },
                    { -30977526, "permission", "update", "admin" },
                    { 2064380599, "permission", "update", "user" }
                });

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Playlist",
                keyColumn: "PlaylistId",
                keyValue: 4,
                column: "Created_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 28, 16, 51, 12, 985, DateTimeKind.Local).AddTicks(8736));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: -1504998532);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: -30977526);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2064380599);

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
    }
}

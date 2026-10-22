using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductInsight.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Ean", "Category", "ImageUrl", "LastLookupDate", "Name" },
                values: new object[,]
                {
                    { "4006381333931", "Papetarie", null, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set markere Faber" },
                    { "5901234123457", "electrocasnice", null, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cafetiera " }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AuthorName", "Date", "ProductEan", "Rating", "Source", "Text" },
                values: new object[,]
                {
                    { 1, "Ana", new DateTime(2026, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901234123457", 4, "Seed", "Face o cafea bună, dar e zgomotoasă." },
                    { 2, "Mihai", new DateTime(2026, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901234123457", 2, "Seed", "După 3 luni s-a stricat pompa." },
                    { 3, "Elena", new DateTime(2026, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901234123457", 5, "Seed", "Raport calitate/preț excelent." },
                    { 4, "Radu", new DateTime(2026, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "4006381333931", 5, "Seed", "Culori vii, nu se usucă repede." },
                    { 5, "Ioana", new DateTime(2026, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "4006381333931", 3, "Seed", "Mi se pare cam scump pentru ce oferă." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Ean",
                keyValue: "4006381333931");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Ean",
                keyValue: "5901234123457");
        }
    }
}

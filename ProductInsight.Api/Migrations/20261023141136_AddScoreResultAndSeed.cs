using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductInsight.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddScoreResultAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductEan = table.Column<string>(type: "TEXT", nullable: false),
                    AverageRating = table.Column<double>(type: "REAL", nullable: false),
                    ReviewsCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Verdict = table.Column<int>(type: "INTEGER", nullable: false),
                    CalculatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScoreResult_Products_ProductEan",
                        column: x => x.ProductEan,
                        principalTable: "Products",
                        principalColumn: "Ean",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Ean", "Category", "ImageUrl", "LastLookupDate", "Name" },
                values: new object[,]
                {
                    { "5901111111119", "Electrocasnice", null, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspirator Turbo Clean" },
                    { "5902222222220", "Sport", null, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sticla termica Frost 500ml" },
                    { "5941234567899", "Electronice", null, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casti wireless Sony" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Face o cafea buna, dar e zgomotoasa.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "Dupa 3 luni s-a stricat pompa.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "Raport calitate/pret excelent.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Text",
                value: "Culori vii, nu se usuca repede.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "Mi se pare cam scump pentru ce ofera.");

            migrationBuilder.InsertData(
                table: "ScoreResult",
                columns: new[] { "Id", "AverageRating", "CalculatedAt", "ProductEan", "ReviewsCount", "Verdict" },
                values: new object[,]
                {
                    { 1, 3.6699999999999999, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901234123457", 3, 1 },
                    { 2, 4.0, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "4006381333931", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AuthorName", "Date", "ProductEan", "Rating", "Source", "Text" },
                values: new object[,]
                {
                    { 6, "Vlad", new DateTime(2026, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "5941234567899", 5, "Seed", "Sunet foarte bun si baterie care tine." },
                    { 7, "Maria", new DateTime(2026, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "5941234567899", 4, "Seed", "Confortabile, dar microfonul e slab." },
                    { 8, "Dan", new DateTime(2026, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "5941234567899", 5, "Seed", "Cel mai bun raport calitate/pret din categorie." },
                    { 9, "Carmen", new DateTime(2026, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901111111119", 2, "Seed", "Aspia slab si face mult zgomot." },
                    { 10, "Sorin", new DateTime(2026, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901111111119", 1, "Seed", "S-a stricat motorul dupa o luna." },
                    { 11, "Laura", new DateTime(2026, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901111111119", 3, "Seed", "Merge decent pe suprafete mici." },
                    { 12, "Andrei", new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "5902222222220", 4, "Seed", "Tine apa rece toata ziua." },
                    { 13, "Bianca", new DateTime(2026, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "5902222222220", 3, "Seed", "Capacul se desface greu, altfel e ok." }
                });

            migrationBuilder.InsertData(
                table: "ScoreResult",
                columns: new[] { "Id", "AverageRating", "CalculatedAt", "ProductEan", "ReviewsCount", "Verdict" },
                values: new object[,]
                {
                    { 3, 4.6699999999999999, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5941234567899", 3, 2 },
                    { 4, 2.0, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5901111111119", 3, 0 },
                    { 5, 3.5, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "5902222222220", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScoreResult_ProductEan",
                table: "ScoreResult",
                column: "ProductEan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreResult");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Ean",
                keyValue: "5901111111119");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Ean",
                keyValue: "5902222222220");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Ean",
                keyValue: "5941234567899");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "Face o cafea bună, dar e zgomotoasă.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "După 3 luni s-a stricat pompa.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Text",
                value: "Raport calitate/preț excelent.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "Text",
                value: "Culori vii, nu se usucă repede.");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "Text",
                value: "Mi se pare cam scump pentru ce oferă.");
        }
    }
}

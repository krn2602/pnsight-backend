using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductInsight.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddAiEvaluation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AiEvaluation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductEan = table.Column<string>(type: "TEXT", nullable: false),
                    Vandabilitate = table.Column<int>(type: "INTEGER", nullable: false),
                    Calitate = table.Column<int>(type: "INTEGER", nullable: false),
                    RaportCalitatePret = table.Column<int>(type: "INTEGER", nullable: true),
                    Durabilitate = table.Column<int>(type: "INTEGER", nullable: false),
                    SatisfactieGenerala = table.Column<int>(type: "INTEGER", nullable: false),
                    CredibilitateRecenzii = table.Column<int>(type: "INTEGER", nullable: false),
                    Rezumat = table.Column<string>(type: "TEXT", nullable: false),
                    EvaluatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiEvaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AiEvaluation_Products_ProductEan",
                        column: x => x.ProductEan,
                        principalTable: "Products",
                        principalColumn: "Ean",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AiEvaluation_ProductEan",
                table: "AiEvaluation",
                column: "ProductEan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AiEvaluation");
        }
    }
}

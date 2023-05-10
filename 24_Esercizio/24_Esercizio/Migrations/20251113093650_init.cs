using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _24_Esercizio.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    AutoreId = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cognome = table.Column<string>(type: "TEXT", nullable: false),
                    DataDiNascita = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.AutoreId);
                });

            migrationBuilder.CreateTable(
                name: "Libri",
                columns: table => new
                {
                    LibroID = table.Column<string>(type: "TEXT", nullable: false),
                    AutoreId = table.Column<string>(type: "TEXT", nullable: false),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Anno = table.Column<int>(type: "INTEGER", nullable: false),
                    Pagine = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libri", x => new { x.LibroID, x.AutoreId });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Libri");
        }
    }
}

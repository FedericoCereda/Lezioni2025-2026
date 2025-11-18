using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _26_ClassiStudente.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studente_Classe_ClasseId",
                table: "Studente");

            migrationBuilder.DropIndex(
                name: "IX_Studente_ClasseId",
                table: "Studente");

            migrationBuilder.DropColumn(
                name: "ClasseId",
                table: "Studente");

            migrationBuilder.CreateIndex(
                name: "IX_Studente_FkClasse",
                table: "Studente",
                column: "FkClasse");

            migrationBuilder.AddForeignKey(
                name: "FK_Studente_Classe_FkClasse",
                table: "Studente",
                column: "FkClasse",
                principalTable: "Classe",
                principalColumn: "ClasseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studente_Classe_FkClasse",
                table: "Studente");

            migrationBuilder.DropIndex(
                name: "IX_Studente_FkClasse",
                table: "Studente");

            migrationBuilder.AddColumn<int>(
                name: "ClasseId",
                table: "Studente",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Studente_ClasseId",
                table: "Studente",
                column: "ClasseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studente_Classe_ClasseId",
                table: "Studente",
                column: "ClasseId",
                principalTable: "Classe",
                principalColumn: "ClasseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

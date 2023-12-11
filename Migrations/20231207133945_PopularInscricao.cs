using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopularInscricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incricoes_Concursos_ConcursoCodConc",
                table: "Incricoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incricoes",
                table: "Incricoes");

            migrationBuilder.DropColumn(
                name: "CodConc",
                table: "Incricoes");

            migrationBuilder.RenameTable(
                name: "Incricoes",
                newName: "Inscricoes");

            migrationBuilder.RenameColumn(
                name: "ConcursoCodConc",
                table: "Inscricoes",
                newName: "CodConc1");

            migrationBuilder.RenameIndex(
                name: "IX_Incricoes_ConcursoCodConc",
                table: "Inscricoes",
                newName: "IX_Inscricoes_CodConc1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inscricoes",
                table: "Inscricoes",
                column: "CodInsc");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscricoes_Concursos_CodConc1",
                table: "Inscricoes",
                column: "CodConc1",
                principalTable: "Concursos",
                principalColumn: "CodConc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscricoes_Concursos_CodConc1",
                table: "Inscricoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inscricoes",
                table: "Inscricoes");

            migrationBuilder.RenameTable(
                name: "Inscricoes",
                newName: "Incricoes");

            migrationBuilder.RenameColumn(
                name: "CodConc1",
                table: "Incricoes",
                newName: "ConcursoCodConc");

            migrationBuilder.RenameIndex(
                name: "IX_Inscricoes_CodConc1",
                table: "Incricoes",
                newName: "IX_Incricoes_ConcursoCodConc");

            migrationBuilder.AddColumn<int>(
                name: "CodConc",
                table: "Incricoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incricoes",
                table: "Incricoes",
                column: "CodInsc");

            migrationBuilder.AddForeignKey(
                name: "FK_Incricoes_Concursos_ConcursoCodConc",
                table: "Incricoes",
                column: "ConcursoCodConc",
                principalTable: "Concursos",
                principalColumn: "CodConc");
        }
    }
}

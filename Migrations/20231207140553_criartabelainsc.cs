using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class criartabelainsc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
        name: "Incricoes",
        columns: table => new
        {
            CodInsc = table.Column<int>(nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            Nome = table.Column<string>(nullable: true),
            FormaIngresso = table.Column<string>(nullable: true),
            Status = table.Column<string>(nullable: true),
            CodConc = table.Column<int>(nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Incricoes", x => x.CodInsc);
            table.ForeignKey(
                name: "FK_Incricoes_Concursos_CodConc",
                column: x => x.CodConc,
                principalTable: "Concursos",
                principalColumn: "CodConc",
                onDelete: ReferentialAction.Cascade);
        });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incricoes");
        }
    }
}

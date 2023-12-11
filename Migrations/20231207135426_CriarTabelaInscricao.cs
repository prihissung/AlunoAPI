using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaInscricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Inscricoes",  // Nome da tabela no banco de dados
            columns: table => new
        {
            CodInsc = table.Column<int>(nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            Nome = table.Column<string>(nullable: true),
            FormaIngresso = table.Column<string>(nullable: true),
            Status = table.Column<string>(nullable: true),
            CodConc = table.Column<int>(nullable: false)  // Esta é a coluna de chave estrangeira
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Inscricoes", x => x.CodInsc);
            table.ForeignKey(
                name: "FK_Inscricoes_Concursos_CodConc",  // Nome da chave estrangeira
                column: x => x.CodConc,
                principalTable: "Concursos",  // Nome da tabela referenciada (Concursos)
                principalColumn: "CodConc",  // Nome da coluna referenciada na tabela Concursos
                onDelete: ReferentialAction.Cascade);
        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Inscricoes");
        }
    }
}

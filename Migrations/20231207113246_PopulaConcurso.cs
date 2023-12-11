using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaConcurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Concursos(Nome) Values('UAM - COI')");
            mb.Sql("insert into Concursos(Nome) Values('USJT - COI')");
            mb.Sql("insert into Concursos(Nome) Values('AGES - COI')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Concursos");
        }
    }
}

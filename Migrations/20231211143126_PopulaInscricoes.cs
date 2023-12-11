using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaInscricoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Inscricoes(Nome,FormaIngresso,Status,CodConc) " +
                   "Values('Allan Reidi', 'Transferencia Externa', 'Incompleta, '2')");
            mb.Sql("insert into Inscricoes(Nome,FormaIngresso,Status,CodConc) " +
                   "Values('Jacob Fontes', 'Reingresso', 'Finalizada', '3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Inscricoes");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaInscricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Incricoes(Nome,FormaIngresso,Status,CodConc,Concurso) " +
                   "Values('Paola Sannini', 'Obtencao Novo Titulo', 'Finalizada', '1', '1')");
            mb.Sql("insert into Incricoes(Nome,FormaIngresso,Status,CodConc,Concurso) " +
                   "Values('Allan Reidi', 'Transferencia Externa', 'Incompleta, '2', '2')");
            mb.Sql("insert into Incricoes(Nome,FormaIngresso,Status,CodConc,Concurso) " +
                   "Values('Jacob Fontes', 'Reingresso', 'Finalizada', '3', '3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Incricoes");
        }
    }
}

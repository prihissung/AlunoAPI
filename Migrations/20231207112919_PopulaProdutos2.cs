using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlunoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migB)
        {
            migB.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                   "Values('Lanche de Atum', 'Lanche de Atum com Maionese', 8.75, 'atum.jpg', 10, now(), 2)");
            migB.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                   "Values('Pudim 100g', 'Pudim de Leite Condensado 100g', 6.70, 'pudim.jpg', 20, now(), 3)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migB)
        {
            migB.Sql("Delete from Produtos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) VALUES('Coca-Cola Zero', 'Refrigerante 350ml', 5.45, 'cocacola.jpg', 50, now(), 1)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) VALUES('Lanche de Atum', 'Lanche de Atum com Maionese', 8.50, 'atum.jpg', 10, now(), 2)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, CategoriaId) VALUES('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'pudim.jpg', 20, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}

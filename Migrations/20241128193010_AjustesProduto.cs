using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfoodSocial.Migrations
{
    /// <inheritdoc />
    public partial class AjustesProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodProduto",
                table: "Produto",
                newName: "Cod_Produto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cod_Produto",
                table: "Produto",
                newName: "CodProduto");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfoodSocial.Migrations
{
    /// <inheritdoc />
    public partial class AjustesCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpreedimentoCod_Empreedimento",
                table: "Empreendimento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cod_Empreedimento",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empreendimento_EmpreedimentoCod_Empreedimento",
                table: "Empreendimento",
                column: "EmpreedimentoCod_Empreedimento");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_Cod_Empreedimento",
                table: "Categoria",
                column: "Cod_Empreedimento");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Empreendimento_Cod_Empreedimento",
                table: "Categoria",
                column: "Cod_Empreedimento",
                principalTable: "Empreendimento",
                principalColumn: "Cod_Empreedimento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empreendimento_Empreendimento_EmpreedimentoCod_Empreedimento",
                table: "Empreendimento",
                column: "EmpreedimentoCod_Empreedimento",
                principalTable: "Empreendimento",
                principalColumn: "Cod_Empreedimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Empreendimento_Cod_Empreedimento",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_Empreendimento_Empreendimento_EmpreedimentoCod_Empreedimento",
                table: "Empreendimento");

            migrationBuilder.DropIndex(
                name: "IX_Empreendimento_EmpreedimentoCod_Empreedimento",
                table: "Empreendimento");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_Cod_Empreedimento",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "EmpreedimentoCod_Empreedimento",
                table: "Empreendimento");

            migrationBuilder.DropColumn(
                name: "Cod_Empreedimento",
                table: "Categoria");
        }
    }
}

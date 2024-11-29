using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IfoodSocial.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Cod_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dcr_Categoria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img_Categoria = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Cod_Categoria);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Cod_Cidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dcr_Cidade = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Cod_Cidade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    Cod_Bairro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dcr_Bairro = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_Cidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.Cod_Bairro);
                    table.ForeignKey(
                        name: "FK_Bairro_Cidade_Cod_Cidade",
                        column: x => x.Cod_Cidade,
                        principalTable: "Cidade",
                        principalColumn: "Cod_Cidade",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cod_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_Cliente = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dcr_Endereco = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dcr_Complemento = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Num_Cep = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_Cidade = table.Column<int>(type: "int", nullable: false),
                    Cod_Bairro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cod_Cliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Bairro_Cod_Bairro",
                        column: x => x.Cod_Bairro,
                        principalTable: "Bairro",
                        principalColumn: "Cod_Bairro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Cidade_Cod_Cidade",
                        column: x => x.Cod_Cidade,
                        principalTable: "Cidade",
                        principalColumn: "Cod_Cidade",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empreendimento",
                columns: table => new
                {
                    Cod_Empreedimento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dcr_Empreendimento = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dcr_Nome_Fantasia = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dcr_Endereco = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dcr_Complemento = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Num_Cep = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_Cidade = table.Column<int>(type: "int", nullable: false),
                    Bairro_Cod_Bairro = table.Column<int>(type: "int", nullable: false),
                    Img_Empreendimento = table.Column<byte[]>(type: "longblob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empreendimento", x => x.Cod_Empreedimento);
                    table.ForeignKey(
                        name: "FK_Empreendimento_Bairro_Bairro_Cod_Bairro",
                        column: x => x.Bairro_Cod_Bairro,
                        principalTable: "Bairro",
                        principalColumn: "Cod_Bairro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empreendimento_Cidade_Cod_Cidade",
                        column: x => x.Cod_Cidade,
                        principalTable: "Cidade",
                        principalColumn: "Cod_Cidade",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    CodProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Dcr_Produto = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img_Produto = table.Column<byte[]>(type: "longblob", nullable: true),
                    Vlr_Produto = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: true),
                    Flag_Disponivel = table.Column<string>(type: "varchar(1)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cod_Categoria = table.Column<int>(type: "int", nullable: false),
                    Cod_Empreedimento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.CodProduto);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_Cod_Categoria",
                        column: x => x.Cod_Categoria,
                        principalTable: "Categoria",
                        principalColumn: "Cod_Categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Empreendimento_Cod_Empreedimento",
                        column: x => x.Cod_Empreedimento,
                        principalTable: "Empreendimento",
                        principalColumn: "Cod_Empreedimento",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bairro_Cod_Cidade",
                table: "Bairro",
                column: "Cod_Cidade");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Cod_Bairro",
                table: "Cliente",
                column: "Cod_Bairro");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Cod_Cidade",
                table: "Cliente",
                column: "Cod_Cidade");

            migrationBuilder.CreateIndex(
                name: "IX_Empreendimento_Bairro_Cod_Bairro",
                table: "Empreendimento",
                column: "Bairro_Cod_Bairro");

            migrationBuilder.CreateIndex(
                name: "IX_Empreendimento_Cod_Cidade",
                table: "Empreendimento",
                column: "Cod_Cidade");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Cod_Categoria",
                table: "Produto",
                column: "Cod_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Cod_Empreedimento",
                table: "Produto",
                column: "Cod_Empreedimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Empreendimento");

            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Cidade");
        }
    }
}

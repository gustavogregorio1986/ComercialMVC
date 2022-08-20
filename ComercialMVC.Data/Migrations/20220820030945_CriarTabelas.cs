using Microsoft.EntityFrameworkCore.Migrations;

namespace ComercialMVC.Data.Migrations
{
    public partial class CriarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Login", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "tb_Administrador",
                columns: table => new
                {
                    IdAdm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Administrador", x => x.IdAdm);
                    table.ForeignKey(
                        name: "FK_tb_Administrador_tb_Login_Id_login",
                        column: x => x.Id_login,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_tb_Usuario_tb_Login_Id_login",
                        column: x => x.Id_login,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Loja",
                columns: table => new
                {
                    IdLoja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLoja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Loja", x => x.IdLoja);
                    table.ForeignKey(
                        name: "FK_tb_Loja_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_loja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Produto", x => x.IdProduto);
                    table.ForeignKey(
                        name: "FK_tb_Produto_tb_Loja_Id_loja",
                        column: x => x.Id_loja,
                        principalTable: "tb_Loja",
                        principalColumn: "IdLoja",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qtde = table.Column<int>(type: "int", nullable: false),
                    Id_Produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Produto_Id_Produto",
                        column: x => x.Id_Produto,
                        principalTable: "tb_Produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Administrador_Id_login",
                table: "tb_Administrador",
                column: "Id_login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Usuario",
                table: "tb_Endereco",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Loja_Id_Usuario",
                table: "tb_Loja",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Produto",
                table: "tb_Pagamento",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Produto_Id_loja",
                table: "tb_Produto",
                column: "Id_loja");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Usuario_Id_login",
                table: "tb_Usuario",
                column: "Id_login");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Administrador");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Produto");

            migrationBuilder.DropTable(
                name: "tb_Loja");

            migrationBuilder.DropTable(
                name: "tb_Usuario");

            migrationBuilder.DropTable(
                name: "tb_Login");
        }
    }
}

using CadastroDeVeiculo.Dominio.Modelos.Enums;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CadastroDeVeiculo.Data.Migrations
{
    public partial class proprietario_adicionato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:e_status", "ativo,inativo");

            migrationBuilder.CreateTable(
                name: "proprietarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "Indica informações sobre o nome de nascimento da pessoa"),
                    documento = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "Indica infomrações de registro da pessoa dono do carro"),
                    email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false, comment: "Email para mandar informações para o proprietario"),
                    endereco = table.Column<string>(type: "text", nullable: true, comment: "Indica onde o proprietario mora"),
                    status = table.Column<EStatus>(type: "e_status", nullable: false, defaultValue: EStatus.ATIVO, comment: "Indica se essa classe esta ativa ou nao")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proprietarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proprietarios");
        }
    }
}

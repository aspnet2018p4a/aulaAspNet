using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication4.Migrations
{
    public partial class CriarTipoJogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoJogoId",
                table: "Mesas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoJogo",
                columns: table => new
                {
                    TipoJogoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Nome = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    MinJogadores = table.Column<int>(nullable: false),
                    MaxJogadores = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoJogo", x => x.TipoJogoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_TipoJogoId",
                table: "Mesas",
                column: "TipoJogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas",
                column: "TipoJogoId",
                principalTable: "TipoJogo",
                principalColumn: "TipoJogoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas");

            migrationBuilder.DropTable(
                name: "TipoJogo");

            migrationBuilder.DropIndex(
                name: "IX_Mesas_TipoJogoId",
                table: "Mesas");

            migrationBuilder.DropColumn(
                name: "TipoJogoId",
                table: "Mesas");
        }
    }
}

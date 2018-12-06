using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class seedTipoJogoETipoDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT TipoJogo
                    (Nome, Url, MinJogadores, MaxJogadores)
                    values
                    ('Xadrez', '/Mesas/MesaChess', 2, 2);");
            migrationBuilder.Sql(
                @"UPDATE Mesas
                    SET TipoJogoId=(SELECT Min(TipoJogoId) FROM TipoJogo);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

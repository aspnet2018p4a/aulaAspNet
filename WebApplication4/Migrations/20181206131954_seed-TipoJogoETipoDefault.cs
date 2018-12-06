using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class seedTipoJogoETipoDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"INSERT [dbo].[TipoJogo]
                    ([Nome], [Url], [MinJogadores], [MaxJogadores])
                    values
                    ('Xadrez', '/Mesas/MesaChess', 2, 2);");
            migrationBuilder.Sql(
                //update TABLE1 set tabel2id = TABLE2.Id from TABLE1 s inner join TABLE2 s on u.name = s.NAME
                @"UPDATE Mesas
                    SET TipoJogoId=SCOPE_IDENTITY();");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

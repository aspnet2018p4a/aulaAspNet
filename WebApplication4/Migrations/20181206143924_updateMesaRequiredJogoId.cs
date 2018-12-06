using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class updateMesaRequiredJogoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas");

            migrationBuilder.AlterColumn<int>(
                name: "TipoJogoId",
                table: "Mesas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas",
                column: "TipoJogoId",
                principalTable: "TipoJogo",
                principalColumn: "TipoJogoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas");

            migrationBuilder.AlterColumn<int>(
                name: "TipoJogoId",
                table: "Mesas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_TipoJogo_TipoJogoId",
                table: "Mesas",
                column: "TipoJogoId",
                principalTable: "TipoJogo",
                principalColumn: "TipoJogoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Mat3x.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MatrixNumbers",
                table: "Matrices",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MatrixNumbers",
                table: "Matrices",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

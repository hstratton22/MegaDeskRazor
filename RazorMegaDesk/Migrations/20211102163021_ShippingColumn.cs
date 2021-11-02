using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorMegaDesk.Migrations
{
    public partial class ShippingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RushDays",
                table: "Deskquote",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RushDays",
                table: "Deskquote");
        }
    }
}

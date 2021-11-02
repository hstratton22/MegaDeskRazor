using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorMegaDesk.Migrations
{
    public partial class DateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "quoteDate",
                table: "Deskquote",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quoteDate",
                table: "Deskquote");
        }
    }
}

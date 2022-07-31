using Microsoft.EntityFrameworkCore.Migrations;

namespace PackIT.Infrastructure.EF.Migrations
{
    public partial class Init_Read_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Version",
                schema: "packing",
                table: "PackingLists",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                schema: "packing",
                table: "PackingLists");
        }
    }
}

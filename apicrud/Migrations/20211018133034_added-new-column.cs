using Microsoft.EntityFrameworkCore.Migrations;

namespace apicrud.Migrations
{
    public partial class addednewcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageFile",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageFile",
                table: "Employees");
        }
    }
}

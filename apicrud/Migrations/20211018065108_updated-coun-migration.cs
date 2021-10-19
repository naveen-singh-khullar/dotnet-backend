using Microsoft.EntityFrameworkCore.Migrations;

namespace apicrud.Migrations
{
    public partial class updatedcounmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TYPE",
                table: "Employees",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "STATUS",
                table: "Employees",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Employees",
                newName: "TYPE");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Employees",
                newName: "STATUS");
        }
    }
}

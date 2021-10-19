using Microsoft.EntityFrameworkCore.Migrations;

namespace apicrud.Migrations
{
    public partial class updatedcolumnmigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Age",
                table: "Employees",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastpayment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Paid",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "STATUS",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TYPE",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Values",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Lastpayment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TYPE",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Values",
                table: "Employees");
        }
    }
}

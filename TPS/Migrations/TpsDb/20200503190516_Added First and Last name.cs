using Microsoft.EntityFrameworkCore.Migrations;

namespace TPS.Migrations.TpsDb
{
    public partial class AddedFirstandLastname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "CustomerManagement",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "CustomerManagement",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "CustomerManagement",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: true);
        }
    }
}

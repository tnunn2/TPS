using Microsoft.EntityFrameworkCore.Migrations;

namespace TPS.Migrations.TpsDb
{
    public partial class MovedCustomertabletoCustomerManagementschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CustomerManagement");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customers",
                newSchema: "CustomerManagement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "CustomerManagement",
                newName: "Customers");
        }
    }
}

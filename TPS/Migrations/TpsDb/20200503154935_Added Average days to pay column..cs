using Microsoft.EntityFrameworkCore.Migrations;

namespace TPS.Migrations.TpsDb
{
    public partial class AddedAveragedaystopaycolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AverageDaysToPay",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageDaysToPay",
                schema: "CustomerManagement",
                table: "Customers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TPS.Migrations.TpsDb
{
    public partial class ChangeddecimalandinttonullableonCustomertableandremovedduplicatecolumnv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageDaysToPay",
                schema: "CustomerManagement",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "User",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "CustomerManagement",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "User",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "CustomerManagement",
                table: "Customers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AverageDaysToPay",
                schema: "CustomerManagement",
                table: "Customers",
                type: "numeric",
                nullable: true);
        }
    }
}

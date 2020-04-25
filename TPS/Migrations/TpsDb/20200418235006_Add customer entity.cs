using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TPS.Migrations.TpsDb
{
    public partial class Addcustomerentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AttentionOrCareOf = table.Column<string>(nullable: true),
                    Suite = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    BillingContact = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    BalanceMethod = table.Column<string>(nullable: true),
                    TermsCode = table.Column<string>(nullable: true),
                    CreditLimit = table.Column<string>(nullable: true),
                    AverageDaysToPay = table.Column<string>(nullable: true),
                    AverageDaysToPays = table.Column<decimal>(nullable: false),
                    CurrentBalance = table.Column<decimal>(nullable: false),
                    PastDueAmount = table.Column<decimal>(nullable: false),
                    HighBalance = table.Column<decimal>(nullable: false),
                    Pricing = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    RequiredPoNumber = table.Column<int>(nullable: false),
                    ShipVia = table.Column<string>(nullable: true),
                    TaxCode = table.Column<string>(nullable: true),
                    ShipTo = table.Column<string>(nullable: true),
                    BillTo = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    TaxNumber = table.Column<int>(nullable: false),
                    AccountReceivable = table.Column<int>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    SalesPtdHistory = table.Column<decimal>(nullable: false),
                    SalesYtdHistory = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

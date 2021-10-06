using Microsoft.EntityFrameworkCore.Migrations;

namespace Northwind.Migrations
{
    public partial class RevisedCustomerAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adddress",
                table: "Customers",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "Adddress");
        }
    }
}

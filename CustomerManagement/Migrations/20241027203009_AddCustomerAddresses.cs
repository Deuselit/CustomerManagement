using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerAddresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Customer_CustomerId1",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_CustomerId1",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFullName",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeFullName",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerId1",
                table: "Customer",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Customer_CustomerId1",
                table: "Customer",
                column: "CustomerId1",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }
    }
}

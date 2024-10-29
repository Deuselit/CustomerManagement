using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerManagement.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnwantedFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_EmployeeId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "EmployeeFullName",
                table: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeFullName",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_EmployeeId",
                table: "Address",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Employee_EmployeeId",
                table: "Address",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId");
        }
    }
}

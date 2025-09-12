using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSession1.Migrations
{
    /// <inheritdoc />
    public partial class Many2OneRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId",
                principalTable: "Departments",
                principalColumn: "DebtId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmpDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpDeptId",
                table: "Employees");
        }
    }
}

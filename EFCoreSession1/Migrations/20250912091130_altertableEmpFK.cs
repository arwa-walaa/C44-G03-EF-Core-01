using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreSession1.Migrations
{
    /// <inheritdoc />
    public partial class altertableEmpFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DebtId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DebtId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DebtId",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "EmpDeptId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId",
                principalTable: "Departments",
                principalColumn: "DebtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmpDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DebtId", "DeptName", "MangerId" },
                values: new object[,]
                {
                    { 6, "Sales", null },
                    { 7, "HR", null },
                    { 8, "IT", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId",
                principalTable: "Departments",
                principalColumn: "DebtId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

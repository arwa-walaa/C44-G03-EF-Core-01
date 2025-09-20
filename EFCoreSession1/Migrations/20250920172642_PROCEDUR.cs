using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSession1.Migrations
{
    /// <inheritdoc />
    public partial class PROCEDUR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        CREATE PROCEDURE GetEmployeesByDept
            @DeptId INT
        AS
        BEGIN
            SELECT * FROM Employees WHERE EmpDeptId = @DeptId
        END
    ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetEmployeesByDept");
        }
    }
}

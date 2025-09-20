using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSession1.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmpDeptView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE VIEW EmpDeptView 
                                WITH SCHEMABINDING ,Encryption
                                  AS 
                                SELECT e.EmployeeID, e.Name, d.DebtId, d.DeptName 
                                FROM dbo.Employees e JOIN dbo.Departments d 
                                ON e.EmpDeptId = d.DebtId");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View EmpDeptView");


        }
    }
}

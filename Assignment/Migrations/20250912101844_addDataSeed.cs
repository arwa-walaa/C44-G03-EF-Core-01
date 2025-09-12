using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class addDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "HiringDate", "Ins_ID", "Name" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, "Computer Science (Seed)" },
                    { 102, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, "Information Systems (Seed)" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 101, "Programming (Seed)" },
                    { 102, "Databases (Seed)" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "Duration", "Name", "Top_ID" },
                values: new object[,]
                {
                    { 101, "Seeded C# Course", 40, "EF Core Seed", 101 },
                    { 102, "Seeded SQL Course", 35, "SQL Seed", 102 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "Address", "Bouns", "Dept_ID", "HourRate", "Name", "Salary" },
                values: new object[,]
                {
                    { 101, "111 Seed St", 600m, 101, 120m, "Carol", 6000m },
                    { 102, "222 Seed Ave", 550m, 102, 110m, "Dave", 5500m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Address", "Age", "Dep_Id", "FName", "LName" },
                values: new object[,]
                {
                    { 101, "333 Seed Blvd", 23, 101, "Mike", "Seedman" },
                    { 102, "444 Seed Rd", 24, 102, "Sara", "Seeder" }
                });

            migrationBuilder.InsertData(
                table: "CourseInstructors",
                columns: new[] { "Course_ID", "inst_ID", "evaluate" },
                values: new object[,]
                {
                    { 101, 101, "Seeded Excellent" },
                    { 102, 102, "Seeded Good" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "Course_ID", "stud_ID", "Grade" },
                values: new object[,]
                {
                    { 101, 101, 90m },
                    { 102, 102, 85m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "Course_ID", "inst_ID" },
                keyValues: new object[] { 101, 101 });

            migrationBuilder.DeleteData(
                table: "CourseInstructors",
                keyColumns: new[] { "Course_ID", "inst_ID" },
                keyValues: new object[] { 102, 102 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "Course_ID", "stud_ID" },
                keyValues: new object[] { 101, 101 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "Course_ID", "stud_ID" },
                keyValues: new object[] { 102, 102 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "ID",
                keyValue: 102);
        }
    }
}

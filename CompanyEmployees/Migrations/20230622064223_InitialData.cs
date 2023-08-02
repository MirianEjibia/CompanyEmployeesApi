using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Forest Avenue, BF 923", "USA", "Admin_Solutions Ltd" },
                    { new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { new Guid("b66cabbe-73f8-4c5a-8b53-9b1f578b77c8"), 26, new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e"), "Sam Raiden", "Software developer", 6000 },
                    { new Guid("c0a6a7b6-cc72-4f8e-8cdd-aa94f6e6e5e7"), 30, new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e"), "Jana McLeaf", "Software developer", 7500 },
                    { new Guid("cbb3e61f-0d8e-4f0a-ae55-83023d2db1a5"), 35, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Kane Miller", "Administrator", 5500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b66cabbe-73f8-4c5a-8b53-9b1f578b77c8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("c0a6a7b6-cc72-4f8e-8cdd-aa94f6e6e5e7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("cbb3e61f-0d8e-4f0a-ae55-83023d2db1a5"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-4f3a-9be9-3e5d8c95d57e"));
        }
    }
}

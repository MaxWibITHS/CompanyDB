using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Data.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "Location", "OrgNumber" },
                values: new object[] { 1, "Wibergs AB", "Sweden", "5542-1243" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyName", "Location", "OrgNumber" },
                values: new object[] { 2, "Wibergs AB", "Denmark", "4254-2213" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyClassId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, 1, "Head of Sales" },
                    { 2, 2, "Production" },
                    { 3, 2, "Mechanic" },
                    { 4, 1, "Accountant" },
                    { 5, 2, "Head of Production" },
                    { 6, 1, "Human Resources" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

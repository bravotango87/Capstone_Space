using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Hkklo8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eca7599-be4e-47c1-9499-6e53c37a51f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aea51871-a4de-4e43-91c7-a1a8bc4e8e6d", "d50c75fc-0ef0-4f94-9150-aee52d773f22", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aea51871-a4de-4e43-91c7-a1a8bc4e8e6d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0eca7599-be4e-47c1-9499-6e53c37a51f2", "320b6087-a182-4dee-843a-0966ac9af127", "Customer", "CUSTOMER" });
        }
    }
}

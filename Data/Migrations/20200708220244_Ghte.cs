using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Ghte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "033823ab-8160-447f-a9e6-f00ca5c03bc7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95a384e6-4361-4353-a518-aacfdbd9de0b", "f355dd95-99f5-4ea7-a924-5adde68dd5a5", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a384e6-4361-4353-a518-aacfdbd9de0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "033823ab-8160-447f-a9e6-f00ca5c03bc7", "d6040d44-37ec-48b8-8cae-0fa637096a80", "Customer", "CUSTOMER" });
        }
    }
}

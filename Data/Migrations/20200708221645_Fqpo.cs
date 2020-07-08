using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Fqpo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a384e6-4361-4353-a518-aacfdbd9de0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad519c8f-a1ae-46ee-94f9-a73a3b40b3e2", "b3c70756-08db-494b-bf45-8a462378b58d", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad519c8f-a1ae-46ee-94f9-a73a3b40b3e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95a384e6-4361-4353-a518-aacfdbd9de0b", "f355dd95-99f5-4ea7-a924-5adde68dd5a5", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Qlkaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad519c8f-a1ae-46ee-94f9-a73a3b40b3e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78f23b79-4be2-45b8-ae99-d782cc79ec5a", "ab656c84-77e3-4589-ba41-610804e6ad39", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78f23b79-4be2-45b8-ae99-d782cc79ec5a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad519c8f-a1ae-46ee-94f9-a73a3b40b3e2", "b3c70756-08db-494b-bf45-8a462378b58d", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Guest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78f23b79-4be2-45b8-ae99-d782cc79ec5a");

            migrationBuilder.AddColumn<int>(
                name: "Guests",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22765d85-be7b-477c-aa34-357fd4529c42", "072e40fc-da60-4c97-87c9-425c64960347", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22765d85-be7b-477c-aa34-357fd4529c42");

            migrationBuilder.DropColumn(
                name: "Guests",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78f23b79-4be2-45b8-ae99-d782cc79ec5a", "ab656c84-77e3-4589-ba41-610804e6ad39", "Customer", "CUSTOMER" });
        }
    }
}

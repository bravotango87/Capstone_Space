using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Bghk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdf3c66c-77d4-45e5-bd35-793de1400aa1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c818d244-3517-4498-8f4a-2ea0b855515d", "f6605ca8-2959-4b7a-9cd8-1eef31ad50d2", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c818d244-3517-4498-8f4a-2ea0b855515d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdf3c66c-77d4-45e5-bd35-793de1400aa1", "b466ba08-0203-4aae-a5f4-8d3f5cee8a8c", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Nggkhh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c818d244-3517-4498-8f4a-2ea0b855515d");

            migrationBuilder.AddColumn<string>(
                name: "Itinerary",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad4d7d96-bb26-4d18-8060-d2462b0b9862", "c604cc2d-d44f-4012-9d05-1b8deb372988", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad4d7d96-bb26-4d18-8060-d2462b0b9862");

            migrationBuilder.DropColumn(
                name: "Itinerary",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c818d244-3517-4498-8f4a-2ea0b855515d", "f6605ca8-2959-4b7a-9cd8-1eef31ad50d2", "Customer", "CUSTOMER" });
        }
    }
}

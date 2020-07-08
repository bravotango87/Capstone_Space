using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Gddww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e2501c8-61e3-4823-92af-b42d8a401f97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "033823ab-8160-447f-a9e6-f00ca5c03bc7", "d6040d44-37ec-48b8-8cae-0fa637096a80", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "033823ab-8160-447f-a9e6-f00ca5c03bc7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e2501c8-61e3-4823-92af-b42d8a401f97", "efc056d1-adad-408e-89dd-f499631315f8", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Dferre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad4d7d96-bb26-4d18-8060-d2462b0b9862");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bf5e529-9ae0-49cd-85fb-35460a4a2906", "ec12a533-aae2-4144-834e-eaf2229871ad", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf5e529-9ae0-49cd-85fb-35460a4a2906");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad4d7d96-bb26-4d18-8060-d2462b0b9862", "c604cc2d-d44f-4012-9d05-1b8deb372988", "Customer", "CUSTOMER" });
        }
    }
}

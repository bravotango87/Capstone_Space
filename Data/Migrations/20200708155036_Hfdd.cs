using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Hfdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf5e529-9ae0-49cd-85fb-35460a4a2906");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7db32fab-0da4-4a5e-9320-6f54db1be985", "a93a9032-1316-4266-9bda-530ad26ba84f", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7db32fab-0da4-4a5e-9320-6f54db1be985");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bf5e529-9ae0-49cd-85fb-35460a4a2906", "ec12a533-aae2-4144-834e-eaf2229871ad", "Customer", "CUSTOMER" });
        }
    }
}

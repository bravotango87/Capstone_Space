using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Ghghg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7db32fab-0da4-4a5e-9320-6f54db1be985");

            migrationBuilder.AddColumn<string>(
                name: "Trip",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c39ebb1d-c7e7-4fc3-81dd-93591ab3f660", "23db54cc-082e-404a-9855-4a9efb5629f0", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c39ebb1d-c7e7-4fc3-81dd-93591ab3f660");

            migrationBuilder.DropColumn(
                name: "Trip",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7db32fab-0da4-4a5e-9320-6f54db1be985", "a93a9032-1316-4266-9bda-530ad26ba84f", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Hnuuu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b931c8a3-f046-4b32-9421-2f194a7d2a37");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Trips");

            migrationBuilder.AddColumn<int>(
                name: "TripId",
                table: "Trips",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "TripKey",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerKey",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "TripId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0eca7599-be4e-47c1-9499-6e53c37a51f2", "320b6087-a182-4dee-843a-0966ac9af127", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eca7599-be4e-47c1-9499-6e53c37a51f2");

            migrationBuilder.DropColumn(
                name: "TripId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "TripKey",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "CustomerKey",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trips",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b931c8a3-f046-4b32-9421-2f194a7d2a37", "ba7cd9a3-5625-4136-adce-16484b765893", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Fore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "097ee1f9-e758-44bc-a018-9b493a561fd6");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Trips",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Trips",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b931c8a3-f046-4b32-9421-2f194a7d2a37", "ba7cd9a3-5625-4136-adce-16484b765893", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Trips_IdentityUserId",
                table: "Trips",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_AspNetUsers_IdentityUserId",
                table: "Trips",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_AspNetUsers_IdentityUserId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_IdentityUserId",
                table: "Trips");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b931c8a3-f046-4b32-9421-2f194a7d2a37");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Trips");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "097ee1f9-e758-44bc-a018-9b493a561fd6", "584257ce-adf3-451a-9c3e-f95b4fff23f6", "Customer", "CUSTOMER" });
        }
    }
}

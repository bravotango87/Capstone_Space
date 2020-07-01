using Microsoft.EntityFrameworkCore.Migrations;

namespace Space.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    LaunchLocation = table.Column<string>(nullable: true),
                    TripCost = table.Column<int>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    AmountOfGuests = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf9ee30c-c6a4-4ffe-a508-e8de0f3aa179", "9c14436a-c84d-4e70-9e9e-7448cb7ccede", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf9ee30c-c6a4-4ffe-a508-e8de0f3aa179");
        }
    }
}

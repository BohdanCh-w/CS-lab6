using Microsoft.EntityFrameworkCore.Migrations;

namespace CS_final.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    MaxPlayers = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerID1 = table.Column<long>(type: "bigint", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    LocationID1 = table.Column<long>(type: "bigint", nullable: true),
                    PlayersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                    table.ForeignKey(
                        name: "FK_Games_Customers_CustomerID1",
                        column: x => x.CustomerID1,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Locations_LocationID1",
                        column: x => x.LocationID1,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentUsages",
                columns: table => new
                {
                    EquipmentUsageID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<int>(type: "int", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    EquipmentID1 = table.Column<long>(type: "bigint", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    SnapPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GameID1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentUsages", x => x.EquipmentUsageID);
                    table.ForeignKey(
                        name: "FK_EquipmentUsages_Equipments_EquipmentID1",
                        column: x => x.EquipmentID1,
                        principalTable: "Equipments",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipmentUsages_Games_GameID1",
                        column: x => x.GameID1,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_EquipmentID1",
                table: "EquipmentUsages",
                column: "EquipmentID1");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_GameID1",
                table: "EquipmentUsages",
                column: "GameID1");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CustomerID1",
                table: "Games",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Games_LocationID1",
                table: "Games",
                column: "LocationID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentUsages");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}

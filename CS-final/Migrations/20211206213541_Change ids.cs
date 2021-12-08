using Microsoft.EntityFrameworkCore.Migrations;

namespace CS_final.Migrations
{
    public partial class Changeids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentID1",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Games_GameID1",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Customers_CustomerID1",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Locations_LocationID1",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Locations",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "LocationID1",
                table: "Games",
                newName: "LocationId1");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Games",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "CustomerID1",
                table: "Games",
                newName: "CustomerId1");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Games",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "GameID",
                table: "Games",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_LocationID1",
                table: "Games",
                newName: "IX_Games_LocationId1");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CustomerID1",
                table: "Games",
                newName: "IX_Games_CustomerId1");

            migrationBuilder.RenameColumn(
                name: "GameID1",
                table: "EquipmentUsages",
                newName: "GameId1");

            migrationBuilder.RenameColumn(
                name: "GameID",
                table: "EquipmentUsages",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "EquipmentID1",
                table: "EquipmentUsages",
                newName: "EquipmentId1");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "EquipmentUsages",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "EquipmentUsageID",
                table: "EquipmentUsages",
                newName: "EquipmentUsageId");

            migrationBuilder.RenameIndex(
                name: "IX_EquipmentUsages_GameID1",
                table: "EquipmentUsages",
                newName: "IX_EquipmentUsages_GameId1");

            migrationBuilder.RenameIndex(
                name: "IX_EquipmentUsages_EquipmentID1",
                table: "EquipmentUsages",
                newName: "IX_EquipmentUsages_EquipmentId1");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "Equipments",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentId1",
                table: "EquipmentUsages",
                column: "EquipmentId1",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Games_GameId1",
                table: "EquipmentUsages",
                column: "GameId1",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Customers_CustomerId1",
                table: "Games",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Locations_LocationId1",
                table: "Games",
                column: "LocationId1",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentId1",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Games_GameId1",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Customers_CustomerId1",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Locations_LocationId1",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Locations",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "LocationId1",
                table: "Games",
                newName: "LocationID1");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Games",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "CustomerId1",
                table: "Games",
                newName: "CustomerID1");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Games",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Games",
                newName: "GameID");

            migrationBuilder.RenameIndex(
                name: "IX_Games_LocationId1",
                table: "Games",
                newName: "IX_Games_LocationID1");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CustomerId1",
                table: "Games",
                newName: "IX_Games_CustomerID1");

            migrationBuilder.RenameColumn(
                name: "GameId1",
                table: "EquipmentUsages",
                newName: "GameID1");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "EquipmentUsages",
                newName: "GameID");

            migrationBuilder.RenameColumn(
                name: "EquipmentId1",
                table: "EquipmentUsages",
                newName: "EquipmentID1");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "EquipmentUsages",
                newName: "EquipmentID");

            migrationBuilder.RenameColumn(
                name: "EquipmentUsageId",
                table: "EquipmentUsages",
                newName: "EquipmentUsageID");

            migrationBuilder.RenameIndex(
                name: "IX_EquipmentUsages_GameId1",
                table: "EquipmentUsages",
                newName: "IX_EquipmentUsages_GameID1");

            migrationBuilder.RenameIndex(
                name: "IX_EquipmentUsages_EquipmentId1",
                table: "EquipmentUsages",
                newName: "IX_EquipmentUsages_EquipmentID1");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "Equipments",
                newName: "EquipmentID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentID1",
                table: "EquipmentUsages",
                column: "EquipmentID1",
                principalTable: "Equipments",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Games_GameID1",
                table: "EquipmentUsages",
                column: "GameID1",
                principalTable: "Games",
                principalColumn: "GameID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Customers_CustomerID1",
                table: "Games",
                column: "CustomerID1",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Locations_LocationID1",
                table: "Games",
                column: "LocationID1",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

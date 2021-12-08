using Microsoft.EntityFrameworkCore.Migrations;

namespace CS_final.Migrations
{
    public partial class Changedtypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Games_CustomerId1",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_LocationId1",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentUsages_EquipmentId1",
                table: "EquipmentUsages");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentUsages_GameId1",
                table: "EquipmentUsages");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "LocationId1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "EquipmentId1",
                table: "EquipmentUsages");

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "EquipmentUsages");

            migrationBuilder.AlterColumn<long>(
                name: "LocationId",
                table: "Games",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Games",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "EquipmentUsages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "EquipmentId",
                table: "EquipmentUsages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CustomerId",
                table: "Games",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_LocationId",
                table: "Games",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_EquipmentId",
                table: "EquipmentUsages",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_GameId",
                table: "EquipmentUsages",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentId",
                table: "EquipmentUsages",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentUsages_Games_GameId",
                table: "EquipmentUsages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Customers_CustomerId",
                table: "Games",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Locations_LocationId",
                table: "Games",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Equipments_EquipmentId",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentUsages_Games_GameId",
                table: "EquipmentUsages");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Customers_CustomerId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Locations_LocationId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CustomerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_LocationId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentUsages_EquipmentId",
                table: "EquipmentUsages");

            migrationBuilder.DropIndex(
                name: "IX_EquipmentUsages_GameId",
                table: "EquipmentUsages");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId1",
                table: "Games",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LocationId1",
                table: "Games",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GameId",
                table: "EquipmentUsages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "EquipmentUsages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "EquipmentId1",
                table: "EquipmentUsages",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "GameId1",
                table: "EquipmentUsages",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CustomerId1",
                table: "Games",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Games_LocationId1",
                table: "Games",
                column: "LocationId1");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_EquipmentId1",
                table: "EquipmentUsages",
                column: "EquipmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentUsages_GameId1",
                table: "EquipmentUsages",
                column: "GameId1");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IflDiary.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DemandRequiredFor",
                table: "Demands",
                newName: "Required");

            migrationBuilder.RenameColumn(
                name: "DemandReceivedOn",
                table: "Demands",
                newName: "ReceivedOn");

            migrationBuilder.RenameColumn(
                name: "DemandPurchaseBy",
                table: "Demands",
                newName: "PurchaseBy");

            migrationBuilder.RenameColumn(
                name: "DemandCreatedOn",
                table: "Demands",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DemandCreateBy",
                table: "Demands",
                newName: "Creater");

            migrationBuilder.RenameColumn(
                name: "DemandCategory",
                table: "Demands",
                newName: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PurchaserId",
                table: "Demands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Purchasers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchasers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demands_PurchaserId",
                table: "Demands",
                column: "PurchaserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_Purchasers_PurchaserId",
                table: "Demands",
                column: "PurchaserId",
                principalTable: "Purchasers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_Purchasers_PurchaserId",
                table: "Demands");

            migrationBuilder.DropTable(
                name: "Purchasers");

            migrationBuilder.DropIndex(
                name: "IX_Demands_PurchaserId",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "PurchaserId",
                table: "Demands");

            migrationBuilder.RenameColumn(
                name: "Required",
                table: "Demands",
                newName: "DemandRequiredFor");

            migrationBuilder.RenameColumn(
                name: "ReceivedOn",
                table: "Demands",
                newName: "DemandReceivedOn");

            migrationBuilder.RenameColumn(
                name: "PurchaseBy",
                table: "Demands",
                newName: "DemandPurchaseBy");

            migrationBuilder.RenameColumn(
                name: "Creater",
                table: "Demands",
                newName: "DemandCreateBy");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Demands",
                newName: "DemandCreatedOn");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Demands",
                newName: "DemandCategory");
        }
    }
}

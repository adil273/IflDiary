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
                newName: "RequiredFor");

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
                newName: "CreateBy");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.RenameColumn(
                name: "RequiredFor",
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
                name: "CreatedOn",
                table: "Demands",
                newName: "DemandCreatedOn");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "Demands",
                newName: "DemandCreateBy");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Demands",
                newName: "DemandCategory");
        }
    }
}

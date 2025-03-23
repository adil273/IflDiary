using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IflDiary.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OgpId",
                table: "Ogps",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "Loans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FollowupId",
                table: "Followups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DiaryId",
                table: "Diaries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DemandId",
                table: "Demands",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ogps",
                newName: "OgpId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Loans",
                newName: "LoanId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Followups",
                newName: "FollowupId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Diaries",
                newName: "DiaryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Demands",
                newName: "DemandId");
        }
    }
}

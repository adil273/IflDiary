using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IflDiary.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActivityNumber",
                table: "Diaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Diaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Diaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Diaries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FeedbackOn",
                table: "Diaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MechanicalDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualityDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityDepartments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diaries_DepartmentId",
                table: "Diaries",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaries_Departments_DepartmentId",
                table: "Diaries",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diaries_Departments_DepartmentId",
                table: "Diaries");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "MechanicalDepartments");

            migrationBuilder.DropTable(
                name: "ProcessDepartments");

            migrationBuilder.DropTable(
                name: "QualityDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Diaries_DepartmentId",
                table: "Diaries");

            migrationBuilder.DropColumn(
                name: "ActivityNumber",
                table: "Diaries");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Diaries");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Diaries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Diaries");

            migrationBuilder.DropColumn(
                name: "FeedbackOn",
                table: "Diaries");
        }
    }
}

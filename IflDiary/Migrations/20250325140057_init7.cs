﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IflDiary.Migrations
{
    /// <inheritdoc />
    public partial class init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectricalDepartmentId",
                table: "Demands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ElectricalDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalDepartments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demands_ElectricalDepartmentId",
                table: "Demands",
                column: "ElectricalDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_ElectricalDepartments_ElectricalDepartmentId",
                table: "Demands",
                column: "ElectricalDepartmentId",
                principalTable: "ElectricalDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_ElectricalDepartments_ElectricalDepartmentId",
                table: "Demands");

            migrationBuilder.DropTable(
                name: "ElectricalDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Demands_ElectricalDepartmentId",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "ElectricalDepartmentId",
                table: "Demands");
        }
    }
}

﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IflDiary.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DemandCategoryId",
                table: "Demands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DemandCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demands_DemandCategoryId",
                table: "Demands",
                column: "DemandCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demands_DemandCategories_DemandCategoryId",
                table: "Demands",
                column: "DemandCategoryId",
                principalTable: "DemandCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demands_DemandCategories_DemandCategoryId",
                table: "Demands");

            migrationBuilder.DropTable(
                name: "DemandCategories");

            migrationBuilder.DropIndex(
                name: "IX_Demands_DemandCategoryId",
                table: "Demands");

            migrationBuilder.DropColumn(
                name: "DemandCategoryId",
                table: "Demands");
        }
    }
}

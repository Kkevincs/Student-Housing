using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddChoreCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Chores",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Chores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chores_CreatorId",
                table: "Chores",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores",
                column: "CreatorId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores");

            migrationBuilder.DropIndex(
                name: "IX_Chores_CreatorId",
                table: "Chores");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Chores");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Chores");
        }
    }
}

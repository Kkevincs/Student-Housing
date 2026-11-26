using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class CreatorSetNullOnDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores");

            migrationBuilder.AddForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores",
                column: "CreatorId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores");

            migrationBuilder.AddForeignKey(
                name: "FK_Chores_Students_CreatorId",
                table: "Chores",
                column: "CreatorId",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}

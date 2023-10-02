using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _006_EF.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Thems_TeamId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thems",
                table: "Thems");

            migrationBuilder.RenameTable(
                name: "Thems",
                newName: "Teams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Thems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thems",
                table: "Thems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Thems_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Thems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

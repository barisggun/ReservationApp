using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addreservationfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_AppUserId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_AppUserId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AppUserId",
                table: "Reservations",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_AppUserId",
                table: "Reservations",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_AppUserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_AppUserId",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId1",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AppUserId1",
                table: "Reservations",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_AppUserId1",
                table: "Reservations",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

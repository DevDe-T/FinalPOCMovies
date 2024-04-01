using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalPOCService.Migrations
{
    /// <inheritdoc />
    public partial class phase8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "movieDesc",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "movieRating",
                table: "movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieDesc",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "movieRating",
                table: "movies");
        }
    }
}

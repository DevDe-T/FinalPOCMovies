using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalPOCService.Migrations
{
    /// <inheritdoc />
    public partial class phase7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "moviePosterLink",
                table: "movies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "moviePosterLink",
                table: "movies");
        }
    }
}

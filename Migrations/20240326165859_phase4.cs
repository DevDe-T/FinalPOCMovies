using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalPOCService.Migrations
{
    /// <inheritdoc />
    public partial class phase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNo",
                table: "users",
                newName: "phoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "users",
                newName: "phoneNo");
        }
    }
}

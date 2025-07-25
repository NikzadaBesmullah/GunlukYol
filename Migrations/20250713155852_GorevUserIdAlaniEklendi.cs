using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GorevTakipApi.Migrations
{
    /// <inheritdoc />
    public partial class GorevUserIdAlaniEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Gorevler",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Gorevler");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt4_Bazodanowa_aplikacja_webowa.Migrations
{
    /// <inheritdoc />
    public partial class zuza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Movie");
        }
    }
}

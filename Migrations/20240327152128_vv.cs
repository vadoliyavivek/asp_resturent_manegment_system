using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MRV_resturant.Migrations
{
    /// <inheritdoc />
    public partial class vv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "DB01T01",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "DB01T01");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KASHOP.Migrations
{
    /// <inheritdoc />
    public partial class addImageCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Imag",
                table: "Products",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Imag");
        }
    }
}

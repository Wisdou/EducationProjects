using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCenter.Migrations
{
    public partial class AddShorscToProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescr",
                table: "Products");
        }
    }
}

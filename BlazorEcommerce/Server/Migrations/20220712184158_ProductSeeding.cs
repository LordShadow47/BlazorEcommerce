using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "RPG", "https://a.allegroimg.com/original/03ef7f/a2f7f1f44518b44e400e834745c6/THE-WITCHER-3-WILD-HUNT-PL-GOG-KLUCZ-GRATIS", 9.99m, "Wiedźmin" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Horror", "https://assets.reedpopcdn.com/dead_space_remake_felieton.jpg/BROK/thumbnail/1200x1200/quality/100/dead_space_remake_felieton.jpg", 7.99m, "Dead Space" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Logic", "https://a.allegroimg.com/original/11e87f/f56f2f0d47a48ede1ff0300d4549/Factorio-STEAM", 19.99m, "Factorio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

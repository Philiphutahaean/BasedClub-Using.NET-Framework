using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasedClub.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Kaos murah dengan design elegan", "based-club-injut1night.jpg", "Based Club in Just 1 Night", 150000m },
                    { 2, "Kaos murah dengan design kekinian", "Based-Club-Kitten.jpg", "Based Club Kitten", 140000m },
                    { 3, "Kaos murah dengan design yang wow", "Based-Club-Retro.jpg", "Based Club Retro", 140000m },
                    { 4, "Kaos murah dengan design yang mencengangkan", "Based-Club-Bintang.jpg", "Based Club Star", 170000m },
                    { 5, "Kaos murah dengan design yang out of the box", "Based-Club-Girl.jpg", "Based Club Girl", 190000m },
                    { 6, "Kaos murah dengan design yang diluar nalar", "Based-Club-Sexy.jpg", "Based Club Ear", 200000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

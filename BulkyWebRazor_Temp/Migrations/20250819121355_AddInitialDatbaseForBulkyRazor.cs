using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWebRazor_Temp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialDatbaseForBulkyRazor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Action" },
                    { 2, 2, "Adventure" },
                    { 3, 3, "Animation" },
                    { 4, 4, "Biography" },
                    { 5, 5, "Comedy" },
                    { 6, 6, "Crime" },
                    { 7, 7, "Documentary" },
                    { 8, 8, "Drama" },
                    { 9, 9, "Family" },
                    { 10, 10, "Fantasy" },
                    { 11, 11, "Film-Noir" },
                    { 12, 12, "History" },
                    { 13, 13, "Horror" },
                    { 14, 14, "Music" },
                    { 15, 15, "Musical" },
                    { 16, 16, "Mystery" },
                    { 17, 17, "Romance" },
                    { 18, 18, "Sci-Fi" },
                    { 19, 19, "Short" },
                    { 20, 20, "Sport" },
                    { 21, 21, "Superhero" },
                    { 22, 22, "Thriller" },
                    { 23, 23, "War" },
                    { 24, 24, "Western" },
                    { 25, 25, "Disaster" },
                    { 26, 26, "Epic" },
                    { 27, 27, "Survival" },
                    { 28, 28, "Psychological" },
                    { 29, 29, "Paranormal" },
                    { 30, 30, "Heist" },
                    { 31, 31, "Spy" },
                    { 32, 32, "Zombie" },
                    { 33, 33, "Christmas" },
                    { 34, 34, "Martial Arts" },
                    { 35, 35, "Time Travel" },
                    { 36, 36, "Space" },
                    { 37, 37, "Alien" },
                    { 38, 38, "Spy Thriller" },
                    { 39, 39, "Legal" },
                    { 40, 40, "Medical" },
                    { 41, 41, "Teen" },
                    { 42, 42, "Political" },
                    { 43, 43, "Road Movie" },
                    { 44, 44, "Coming-of-Age" },
                    { 45, 45, "Satire" },
                    { 46, 46, "Detective" },
                    { 47, 47, "Mockumentary" },
                    { 48, 48, "Found Footage" },
                    { 49, 49, "Game Show" },
                    { 50, 50, "Tragedy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameLand.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategoriesTable",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "null", "Игровые ноутбуки" },
                    { 2, "null", "Игровые системные блоки" },
                    { 3, "null", "Игровые мониторы" },
                    { 4, "null", "Консоли PlayStation 5" },
                    { 5, "null", "Игры для PlayStation 5" },
                    { 6, "null", "Аксессуары для PlayStation 5" },
                    { 7, "null", "Игры для PlayStation 4" },
                    { 8, "null", "Аксессуары для PlayStation 4" },
                    { 9, "null", "Клавиатуры" },
                    { 10, "null", "Мышки" },
                    { 11, "null", "Гарнитура" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesTable");
        }
    }
}

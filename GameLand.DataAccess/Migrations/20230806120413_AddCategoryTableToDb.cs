using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameLand.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTableToDb : Migration
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
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategoriesTable",
                columns: new[] { "Id", "Code", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "#A1", "null", "Игровые ноутбуки" },
                    { 2, "#A2", "null", "Игровые системные блоки" },
                    { 3, "#A3", "null", "Игровые мониторы" },
                    { 4, "#B1", "null", "Консоли PlayStation 5" },
                    { 5, "#B2", "null", "Игры для PlayStation 5" },
                    { 6, "#B3", "null", "Аксессуары для PlayStation 5" },
                    { 7, "#C1", "null", "Игры для PlayStation 4" },
                    { 8, "#C2", "null", "Аксессуары для PlayStation 4" },
                    { 9, "#D1", "null", "Клавиатуры" },
                    { 10, "#E1", "null", "Мышки" },
                    { 11, "#F1", "null", "Гарнитура" }
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

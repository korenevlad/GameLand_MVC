using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameLand.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddToDbCategoriesTableAndProductsTable : Migration
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

            migrationBuilder.CreateTable(
                name: "ProductsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Article = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OldPrice = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsTable_CategoriesTable_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoriesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "ProductsTable",
                columns: new[] { "Id", "Article", "CategoryId", "Description", "ImageURL", "Name", "OldPrice", "Price" },
                values: new object[,]
                {
                    { 1, "400135845", 1, "null", "", "Ноутбук игровой Thunderobot 911 M G3 Pro JT009M00BRU", 129999.0, 114999.0 },
                    { 2, "400079994", 1, "null", "", "Ноутбук игровой Thunderobot 911 Air Wave D", 85999.0, 59999.0 },
                    { 3, "400132672", 1, "null", "", "Ноутбук игровой Thunderobot 911 Plus G3 Pro JT009R00BRU", 134999.0, 124999.0 },
                    { 4, "30067633", 1, "null", "", "Ноутбук игровой ASUS TUF Dash F15 FX517ZM-HN157", 105999.0, 99999.0 },
                    { 5, "400156623", 1, "null", "", "Ноутбук игровой Thunderobot 911 Air XS D", 0.0, 69999.0 },
                    { 6, "30067660", 1, "null", "", "Ноутбук игровой MSI GF63 Thin 11UC-255XRU", 69999.0, 62999.0 },
                    { 7, "30066169", 1, "null", "", "Ноутбук игровой Thunderobot 911 MT Pro D", 111999.0, 89999.0 },
                    { 8, "30067313", 1, "null", "", "Ноутбук игровой MSI Raider GE78 HX 13VI-206RU (MS-17S1)", 429999.0, 364999.0 },
                    { 9, "400132671", 1, "null", "", "Ноутбук игровой Thunderobot Zero G3 Ultra Orange JT009N00BRU", 0.0, 299999.0 },
                    { 10, "4212284", 1, "null", "", "Ноутбук игровой Thunderobot Zero Ultra XT", 0.0, 279999.0 },
                    { 11, "30066473", 1, "null", "", "Ноутбук игровой MSI Raider GE77HX 12UGS-221RU", 269999.0, 229999.0 },
                    { 12, "4212282", 1, "null", "", "Ноутбук игровой Thunderobot Zero Ultra 7 Yellow", 249999.0, 219999.0 },
                    { 13, "30065216", 2, "null", "", "Системный блок игровой Acer Predator PO3-630", 129999.0, 99999.0 },
                    { 14, "30064738", 2, "null", "", "Системный блок игровой MSI AEGIS Ti5", 332499.0, 299999.0 },
                    { 15, "30064736", 2, "null", "", "Системный блок игровой MSI MAG Codex X5", 0.0, 247499.0 },
                    { 16, "30064351", 2, "null", "", "Системный блок игровой MUST MBM117", 159999.0, 129999.0 },
                    { 17, "30066255", 2, "null", "", "Системный блок игровой Thunderobot BW IV Max D", 174999.0, 129999.0 },
                    { 18, "400089344", 2, "null", "", "Системный блок игровой Thunderobot Black Warrior V Shark 7", 0.0, 299999.0 },
                    { 19, "30065807", 2, "null", "", "Системный блок игровой Raskat STRIKE 520 107290", 86999.0, 81999.0 },
                    { 20, "400156700", 2, "null", "", "Системный блок игровой 4Aces Royal Flush", 249999.0, 234999.0 },
                    { 21, "400095426", 3, "null", "", "Монитор игровой Thunderobot KU48F120E", 124999.0, 99999.0 },
                    { 22, "400086711", 3, "null", "", "Монитор игровой Samsung Odyssey Neo G7 S43CG700NI", 89999.0, 82999.0 },
                    { 23, "400095283", 3, "null", "", "Монитор игровой Thunderobot KU27F144M", 79999.0, 74999.0 },
                    { 24, "400095286", 3, "null", "", "Монитор игровой Thunderobot KQ34C144C", 39999.0, 37999.0 },
                    { 25, "400095371", 3, "null", "", "Монитор игровой Thunderobot KF27C240L", 0.0, 21999.0 },
                    { 26, "400155883", 3, "null", "", "Монитор игровой Thunderobot DF27C240L", 23999.0, 19999.0 },
                    { 27, "40078904", 4, "null", "", "Консоль Sony PlayStation 5 Blu-Ray Edition CFI-12(00/16/18)A", 0.0, 59999.0 },
                    { 28, "40079571", 4, "null", "", "Игровая приставка Sony PlayStation 5 Digital Edition CFI-1200B", 0.0, 52999.0 },
                    { 29, "400122205", 4, "null", "", "Игровая консоль PS5 Sony CFI-1200", 0.0, 60190.0 },
                    { 30, "400122205", 4, "null", "", "Игровая консоль PS5 Sony Playstation 5 Digital Edition", 0.0, 62390.0 },
                    { 31, "6020103", 5, "null", "", "PS5 Electronic Arts FIFA 23", 7199.0, 2159.0 },
                    { 32, "6020101", 5, "null", "", "S5 Warner Bros. IE Mortal Kombat 11 Standard", 3199.0, 899.0 },
                    { 33, "400081693", 5, "null", "", "PS5 игра Focus Home Atomic Heart", 0.0, 5999.0 },
                    { 34, "400171614", 5, "null", "", "PS5 игра Electronic Arts EA Sports FC 24", 0.0, 8999.0 },
                    { 35, "400177672", 5, "null", "", "PS5 игра Sony Marvel's Spider-Man 2", 0.0, 9999.0 },
                    { 36, "40076710", 6, "null", "", "Набор кнопок для геймпада PS5 Red Line 5в1", 0.0, 1399.0 },
                    { 37, "400012658", 6, "null", "", "Кронштейн для игровых консолей PlayStation 5 HOOK HOOK PS5", 0.0, 2190.0 },
                    { 38, "400171569", 7, "null", "", "PS4 игра Electronic Arts EA Sports FC 24", 0.0, 8999.0 },
                    { 39, "400081648", 7, "null", "", "PS4 игра Focus Home Atomic Heart", 0.0, 5399.0 },
                    { 40, "40074581", 7, "null", "", "PS4 игра Sony Marvel's Человек-Паук: Майлз Моралес", 0.0, 4299.0 },
                    { 41, "40079473", 8, "null", "", "Геймпад для консоли PlayStation 4 DualShock 4 v2 White", 0.0, 6499.0 },
                    { 42, "40065372", 8, "null", "", "Геймпад для консоли PS4 PlayStation 4 DualShock 4 v2 Black", 0.0, 6999.0 },
                    { 43, "400012646", 8, "null", "", "Кронштейн для игровых консолей PlayStation 4", 0.0, 1980.0 },
                    { 44, "50174790", 9, "null", "", "Игровая клавиатура Logitech G715 Aurora Collection Linear", 0.0, 25999.0 },
                    { 45, "50141080", 9, "null", "", "Игровая клавиатура Logitech G915 TKL LIGHTSPEED Wireless RGB", 0.0, 20499.0 },
                    { 46, "50141080", 9, "null", "", "Игровая клавиатура Red Square Keyrox TKL g3ms White", 0.0, 11345.0 },
                    { 47, "50167104", 9, "null", "", "Игровая клавиатура Red Square Keyrox Classic Pro", 0.0, 6999.0 },
                    { 48, "50175828", 10, "null", "", "Игровая мышь Logitech G502 X LIGHTSPEED White", 0.0, 11499.0 },
                    { 49, "50175847", 10, "null", "", "Игровая мышь HyperX Pulsefire Haste Wireless White", 0.0, 6999.0 },
                    { 50, "50173476", 10, "null", "", "Игровая мышь Logitech G703", 0.0, 8799.0 },
                    { 51, "50175523", 11, "null", "", "Игровые наушники Logitech G733 Lightspeed Lilac", 0.0, 17599.0 },
                    { 52, "50175813", 11, "null", "", "Игровые наушники HyperX Cloud Alpha S", 0.0, 11499.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsTable_CategoryId",
                table: "ProductsTable",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsTable");

            migrationBuilder.DropTable(
                name: "CategoriesTable");
        }
    }
}

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
                    { 1, "400135845", 1, "null", "\\images\\product\\42e671bd-1d26-4343-b859-4f39e39610b1.jpg", "Ноутбук игровой Thunderobot 911 M G3 Pro JT009M00BRU", 129999.0, 114999.0 },
                    { 2, "400079994", 1, "null", "\\images\\product\\279ab8fe-f947-46f9-93f1-340e2fe1f25e.jpg", "Ноутбук игровой Thunderobot 911 Air Wave D", 85999.0, 59999.0 },
                    { 3, "400132672", 1, "null", "\\images\\product\\0d58f316-aca3-4251-87c3-90a24423fd40.jpg", "Ноутбук игровой Thunderobot 911 Plus G3 Pro JT009R00BRU", 134999.0, 124999.0 },
                    { 4, "30067633", 1, "null", "\\images\\product\\1061ae0b-ea1f-493a-855a-2db6ba232fd4.jpg", "Ноутбук игровой ASUS TUF Dash F15 FX517ZM-HN157", 105999.0, 99999.0 },
                    { 5, "400156623", 1, "null", "\\images\\product\\9a5c7945-37a3-4c9a-8f5e-0004af0be8e9.jpg", "Ноутбук игровой Thunderobot 911 Air XS D", 0.0, 69999.0 },
                    { 6, "30067660", 1, "null", "\\images\\product\\65149011-d425-4105-9606-46feab01df54.jpg", "Ноутбук игровой MSI GF63 Thin 11UC-255XRU", 69999.0, 62999.0 },
                    { 7, "30066169", 1, "null", "\\images\\product\\8bb94d52-a4d5-4ebc-a159-e8032cfa775f.jpg", "Ноутбук игровой Thunderobot 911 MT Pro D", 111999.0, 89999.0 },
                    { 8, "30067313", 1, "null", "\\images\\product\\0d1e2c6b-3b80-4e80-af0c-5d81feedecab.jpg", "Ноутбук игровой MSI Raider GE78 HX 13VI-206RU (MS-17S1)", 429999.0, 364999.0 },
                    { 9, "400132671", 1, "null", "\\images\\product\\821d9e89-7309-4e1f-9327-9f923ecfb503.jpg", "Ноутбук игровой Thunderobot Zero G3 Ultra Orange JT009N00BRU", 0.0, 299999.0 },
                    { 10, "4212284", 1, "null", "\\images\\product\\97cd125b-4d27-4b41-a58b-4e6abd27a275.jpg", "Ноутбук игровой Thunderobot Zero Ultra XT", 0.0, 279999.0 },
                    { 11, "30066473", 1, "null", "\\images\\product\\a43d2a2d-1432-4be7-989f-ab8acee69a1f.jpg", "Ноутбук игровой MSI Raider GE77HX 12UGS-221RU", 269999.0, 229999.0 },
                    { 12, "4212282", 1, "null", "\\images\\product\\cd6a28a8-9c77-41a2-b70a-d433357a06e2.jpg", "Ноутбук игровой Thunderobot Zero Ultra 7 Yellow", 249999.0, 219999.0 },
                    { 13, "30065216", 2, "null", "\\images\\product\\761857a3-5184-4090-b72b-1768f9c41772.jpg", "Системный блок игровой Acer Predator PO3-630", 129999.0, 99999.0 },
                    { 14, "30064738", 2, "null", "\\images\\product\\49ac2be4-3547-43f7-9c61-dd39cb5450be.jpg", "Системный блок игровой MSI AEGIS Ti5", 332499.0, 299999.0 },
                    { 15, "30064736", 2, "null", "\\images\\product\\f83a65f0-134b-439d-a6a0-7e2a5a8a72ad.jpg", "Системный блок игровой MSI MAG Codex X5", 0.0, 247499.0 },
                    { 16, "30064351", 2, "null", "\\images\\product\\6b4ea99d-7c4f-495d-b042-088bd3f840c4.jpg", "Системный блок игровой MUST MBM117", 159999.0, 129999.0 },
                    { 17, "30066255", 2, "null", "\\images\\product\\7606ce80-49bd-4dda-813c-3d7bc32c6975.jpg", "Системный блок игровой Thunderobot BW IV Max D", 174999.0, 129999.0 },
                    { 18, "400089344", 2, "null", "\\images\\product\\07cc637e-6cd2-477d-9b72-5b4641f37f39.jpg", "Системный блок игровой Thunderobot Black Warrior V Shark 7", 0.0, 299999.0 },
                    { 19, "30065807", 2, "null", "\\images\\product\\12131301-6594-4936-9e85-1e9c45ae7937.jpg", "Системный блок игровой Raskat STRIKE 520 107290", 86999.0, 81999.0 },
                    { 20, "400156700", 2, "null", "\\images\\product\\3c6fadf6-2f30-4c41-97ba-93ad753d3b1b.jpg", "Системный блок игровой 4Aces Royal Flush", 249999.0, 234999.0 },
                    { 21, "400095426", 3, "null", "\\images\\product\\dcc68fcb-4661-4099-95a1-9dff72dae6c5.jpg", "Монитор игровой Thunderobot KU48F120E", 124999.0, 99999.0 },
                    { 22, "400086711", 3, "null", "\\images\\product\\6d341196-9ff3-476e-bb44-768253bee6c7.jpg", "Монитор игровой Samsung Odyssey Neo G7 S43CG700NI", 89999.0, 82999.0 },
                    { 23, "400095283", 3, "null", "\\images\\product\\748ed21e-74c9-4d74-afab-316bc14c0597.jpg", "Монитор игровой Thunderobot KU27F144M", 79999.0, 74999.0 },
                    { 24, "400095286", 3, "null", "\\images\\product\\b3a9764e-2c1d-4fbd-a4f3-ef33a6a3b86c.jpg", "Монитор игровой Thunderobot KQ34C144C", 39999.0, 37999.0 },
                    { 25, "400095371", 3, "null", "\\images\\product\\bc8bd696-60e0-44dd-a08e-65248563ff21.jpg", "Монитор игровой Thunderobot KF27C240L", 0.0, 21999.0 },
                    { 26, "400155883", 3, "null", "\\images\\product\\abc69ff0-a2ec-42dc-9b25-38303524c7c6.jpg", "Монитор игровой Thunderobot DF27C240L", 23999.0, 19999.0 },
                    { 27, "40078904", 4, "null", "\\images\\product\\f9c6eb3d-78c4-42de-aba4-a81fc6b04835.jpg", "Консоль Sony PlayStation 5 Blu-Ray Edition CFI-12(00/16/18)A", 0.0, 59999.0 },
                    { 28, "40079571", 4, "null", "\\images\\product\\65f10155-3b20-4a05-b3e0-f42f33b953f5.jpg", "Игровая приставка Sony PlayStation 5 Digital Edition CFI-1200B", 0.0, 52999.0 },
                    { 29, "400122205", 4, "null", "\\images\\product\\10215343-9415-4c9f-b184-6ea93ae3200b.jpg", "Игровая консоль PS5 Sony CFI-1200", 0.0, 60190.0 },
                    { 30, "400122205", 4, "null", "\\images\\product\\3f9df10a-0e34-45fa-aa07-be6440520376.jpg", "Игровая консоль PS5 Sony Playstation 5 Digital Edition", 0.0, 62390.0 },
                    { 31, "6020103", 5, "null", "\\images\\product\\bae42bf4-6c57-4fc2-a54a-4986145fa904.jpg", "PS5 Electronic Arts FIFA 23", 7199.0, 2159.0 },
                    { 32, "6020101", 5, "null", "\\images\\product\\ec34da26-8d70-420a-bc8a-8d43551878fa.jpg", "S5 Warner Bros. IE Mortal Kombat 11 Standard", 3199.0, 899.0 },
                    { 33, "400081693", 5, "null", "\\images\\product\\fb8da971-afe0-49dd-8843-62c2096c2677.jpg", "PS5 игра Focus Home Atomic Heart", 0.0, 5999.0 },
                    { 34, "400171614", 5, "null", "\\images\\product\\9869d232-49a6-4009-a6ad-3b193b48266a.jpg", "PS5 игра Electronic Arts EA Sports FC 24", 0.0, 8999.0 },
                    { 35, "400177672", 5, "null", "\\images\\product\\ea3dfe08-8d17-4394-8400-7c3c573db38d.jpg", "PS5 игра Sony Marvel's Spider-Man 2", 0.0, 9999.0 },
                    { 36, "40076710", 6, "null", "\\images\\product\\c6c055b5-b7ff-4460-a84a-697846c80dd2.jpg", "Набор кнопок для геймпада PS5 Red Line 5в1", 0.0, 1399.0 },
                    { 37, "400012658", 6, "null", "\\images\\product\\78656946-fa32-4ce3-9d21-1b35419cf4f8.jpg", "Кронштейн для игровых консолей PlayStation 5 HOOK HOOK PS5", 0.0, 2190.0 },
                    { 38, "400171569", 7, "null", "\\images\\product\\1bb19a42-9077-49d4-936e-daf8ee3c736f.jpg", "PS4 игра Electronic Arts EA Sports FC 24", 0.0, 8999.0 },
                    { 39, "400081648", 7, "null", "\\images\\product\\e800ecbb-d315-4a88-acaf-5515e42a5ad5.jpg", "PS4 игра Focus Home Atomic Heart", 0.0, 5399.0 },
                    { 40, "40074581", 7, "null", "\\images\\product\\ae2b4834-5360-46fb-b58e-ea9a0102dd4c.jpg", "PS4 игра Sony Marvel's Человек-Паук: Майлз Моралес", 0.0, 4299.0 },
                    { 41, "40079473", 8, "null", "\\images\\product\\a71f1821-fae8-41ab-9ba1-8066737addb6.jpg", "Геймпад для консоли PlayStation 4 DualShock 4 v2 White", 0.0, 6499.0 },
                    { 42, "40065372", 8, "null", "\\images\\product\\d194d5f1-3c84-437c-81d9-6af1a4aca615.jpg", "Геймпад для консоли PS4 PlayStation 4 DualShock 4 v2 Black", 0.0, 6999.0 },
                    { 43, "400012646", 8, "null", "\\images\\product\\97864b5b-d5bd-4654-a971-e8e6dc6a198c.jpg", "Кронштейн для игровых консолей PlayStation 4", 0.0, 1980.0 },
                    { 44, "50174790", 9, "null", "\\images\\product\\fc12df68-cc87-416c-8644-729d338b3469.jpg", "Игровая клавиатура Logitech G715 Aurora Collection Linear", 0.0, 25999.0 },
                    { 45, "50141080", 9, "null", "\\images\\product\\7fffb182-2443-440c-8353-94262a0a195f.jpg", "Игровая клавиатура Logitech G915 TKL LIGHTSPEED Wireless RGB", 0.0, 20499.0 },
                    { 46, "50141080", 9, "null", "\\images\\product\\ef005796-ef47-4619-8c82-50bd30791e95.jpg", "Игровая клавиатура Red Square Keyrox TKL g3ms White", 0.0, 11345.0 },
                    { 47, "50167104", 9, "null", "\\images\\product\\6ef5baa8-8cc5-4e76-ae8d-02248841d386.jpg", "Игровая клавиатура Red Square Keyrox Classic Pro", 0.0, 6999.0 },
                    { 48, "50175828", 10, "null", "\\images\\product\\a43c6909-c1bb-45b3-aaea-f8d6f454673f.jpg", "Игровая мышь Logitech G502 X LIGHTSPEED White", 0.0, 11499.0 },
                    { 49, "50175847", 10, "null", "\\images\\product\\79d33e76-c25a-4097-b33d-81d51858c5dc.jpg", "Игровая мышь HyperX Pulsefire Haste Wireless White", 0.0, 6999.0 },
                    { 50, "50173476", 10, "null", "\\images\\product\\7178780d-d0e0-4cc0-bec6-c8c79d55a5b8.jpg", "Игровая мышь Logitech G703", 0.0, 8799.0 },
                    { 51, "50175523", 11, "null", "\\images\\product\\4a7fe03e-6ee1-4d97-94c9-afc68150a83c.jpg", "Игровые наушники Logitech G733 Lightspeed Lilac", 0.0, 17599.0 },
                    { 52, "50175813", 11, "null", "\\images\\product\\7d9be698-a312-466e-bb89-f912559264a9.jpg", "Игровые наушники HyperX Cloud Alpha S", 0.0, 11499.0 }
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

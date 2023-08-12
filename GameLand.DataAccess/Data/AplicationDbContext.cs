using GameLand.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.DataAccess.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Игровые ноутбуки", Code = "#A1", Description = "null" },
                new Category { Id = 2, Name = "Игровые системные блоки", Code = "#A2", Description = "null" },
                new Category { Id = 3, Name = "Игровые мониторы", Code = "#A3", Description = "null" },
                new Category { Id = 4, Name = "Консоли PlayStation 5", Code = "#B1", Description = "null" },
                new Category { Id = 5, Name = "Игры для PlayStation 5", Code = "#B2", Description = "null" },
                new Category { Id = 6, Name = "Аксессуары для PlayStation 5", Code = "#B3", Description = "null" },
                new Category { Id = 7, Name = "Игры для PlayStation 4", Code = "#C1", Description = "null" },
                new Category { Id = 8, Name = "Аксессуары для PlayStation 4", Code = "#C2", Description = "null" },
                new Category { Id = 9, Name = "Клавиатуры", Code = "#D1", Description = "null" },
                new Category { Id = 10, Name = "Мышки", Code = "#E1", Description = "null" },
                new Category { Id = 11, Name = "Гарнитура", Code = "#F1", Description = "null" }
                );


            modelBuilder.Entity<Product>().HasData(
                //Игровые ноутбуки
                new Product
                {
                    Id = 1,
                    Name = "Ноутбук игровой Thunderobot 911 M G3 Pro JT009M00BRU",
                    Article = "400135845",
                    Description = "null",
                    Price = 114999,
                    OldPrice = 129999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\42e671bd-1d26-4343-b859-4f39e39610b1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Ноутбук игровой Thunderobot 911 Air Wave D",
                    Article = "400079994",
                    Description = "null",
                    Price = 59999,
                    OldPrice = 85999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\279ab8fe-f947-46f9-93f1-340e2fe1f25e.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Ноутбук игровой Thunderobot 911 Plus G3 Pro JT009R00BRU",
                    Article = "400132672",
                    Description = "null",
                    Price = 124999,
                    OldPrice = 134999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\0d58f316-aca3-4251-87c3-90a24423fd40.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Ноутбук игровой ASUS TUF Dash F15 FX517ZM-HN157",
                    Article = "30067633",
                    Description = "null",
                    Price = 99999,
                    OldPrice = 105999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\1061ae0b-ea1f-493a-855a-2db6ba232fd4.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Ноутбук игровой Thunderobot 911 Air XS D",
                    Article = "400156623",
                    Description = "null",
                    Price = 69999,
                    OldPrice = 0,
                    CategoryId = 1,
                    ImageURL = @"\images\product\9a5c7945-37a3-4c9a-8f5e-0004af0be8e9.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Ноутбук игровой MSI GF63 Thin 11UC-255XRU",
                    Article = "30067660",
                    Description = "null",
                    Price = 62999,
                    OldPrice = 69999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\65149011-d425-4105-9606-46feab01df54.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Ноутбук игровой Thunderobot 911 MT Pro D",
                    Article = "30066169",
                    Description = "null",
                    Price = 89999,
                    OldPrice = 111999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\8bb94d52-a4d5-4ebc-a159-e8032cfa775f.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "Ноутбук игровой MSI Raider GE78 HX 13VI-206RU (MS-17S1)",
                    Article = "30067313",
                    Description = "null",
                    Price = 364999,
                    OldPrice = 429999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\0d1e2c6b-3b80-4e80-af0c-5d81feedecab.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Ноутбук игровой Thunderobot Zero G3 Ultra Orange JT009N00BRU",
                    Article = "400132671",
                    Description = "null",
                    Price = 299999,
                    OldPrice = 0,
                    CategoryId = 1,
                    ImageURL = @"\images\product\821d9e89-7309-4e1f-9327-9f923ecfb503.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "Ноутбук игровой Thunderobot Zero Ultra XT",
                    Article = "4212284",
                    Description = "null",
                    Price = 279999,
                    OldPrice = 0,
                    CategoryId = 1,
                    ImageURL = @"\images\product\97cd125b-4d27-4b41-a58b-4e6abd27a275.jpg"
                },
                new Product
                {
                    Id = 11,
                    Name = "Ноутбук игровой MSI Raider GE77HX 12UGS-221RU",
                    Article = "30066473",
                    Description = "null",
                    Price = 229999,
                    OldPrice = 269999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\a43d2a2d-1432-4be7-989f-ab8acee69a1f.jpg"
                },
                new Product
                {
                    Id = 12,
                    Name = "Ноутбук игровой Thunderobot Zero Ultra 7 Yellow",
                    Article = "4212282",
                    Description = "null",
                    Price = 219999,
                    OldPrice = 249999,
                    CategoryId = 1,
                    ImageURL = @"\images\product\cd6a28a8-9c77-41a2-b70a-d433357a06e2.jpg"
                },




                //Игровые системные блоки
                new Product
                {
                    Id = 13,
                    Name = "Системный блок игровой Acer Predator PO3-630",
                    Article = "30065216",
                    Description = "null",
                    Price = 99999,
                    OldPrice = 129999,
                    CategoryId = 2,
                    ImageURL = @"\images\product\761857a3-5184-4090-b72b-1768f9c41772.jpg"
                },
                new Product
                {
                    Id = 14,
                    Name = "Системный блок игровой MSI AEGIS Ti5",
                    Article = "30064738",
                    Description = "null",
                    Price = 299999,
                    OldPrice = 332499,
                    CategoryId = 2,
                    ImageURL = @"\images\product\49ac2be4-3547-43f7-9c61-dd39cb5450be.jpg"
                },
                new Product
                {
                    Id = 15,
                    Name = "Системный блок игровой MSI MAG Codex X5",
                    Article = "30064736",
                    Description = "null",
                    Price = 247499,
                    OldPrice = 0,
                    CategoryId = 2,
                    ImageURL = @"\images\product\f83a65f0-134b-439d-a6a0-7e2a5a8a72ad.jpg"
                },
                new Product
                {
                    Id = 16,
                    Name = "Системный блок игровой MUST MBM117",
                    Article = "30064351",
                    Description = "null",
                    Price = 129999,
                    OldPrice = 159999,
                    CategoryId = 2,
                    ImageURL = @"\images\product\6b4ea99d-7c4f-495d-b042-088bd3f840c4.jpg"
                },
                new Product
                {
                    Id = 17,
                    Name = "Системный блок игровой Thunderobot BW IV Max D",
                    Article = "30066255",
                    Description = "null",
                    Price = 129999,
                    OldPrice = 174999,
                    CategoryId = 2,
                    ImageURL = @"\images\product\7606ce80-49bd-4dda-813c-3d7bc32c6975.jpg"
                },
                new Product
                {
                    Id = 18,
                    Name = "Системный блок игровой Thunderobot Black Warrior V Shark 7",
                    Article = "400089344",
                    Description = "null",
                    Price = 299999,
                    OldPrice = 0,
                    CategoryId = 2,
                    ImageURL = @"\images\product\07cc637e-6cd2-477d-9b72-5b4641f37f39.jpg"
                },
                new Product
                {
                    Id = 19,
                    Name = "Системный блок игровой Raskat STRIKE 520 107290",
                    Article = "30065807",
                    Description = "null",
                    Price = 81999,
                    OldPrice = 86999,
                    CategoryId = 2,
                    ImageURL = @"\images\product\12131301-6594-4936-9e85-1e9c45ae7937.jpg"
                },
                new Product
                {
                    Id = 20,
                    Name = "Системный блок игровой 4Aces Royal Flush",
                    Article = "400156700",
                    Description = "null",
                    Price = 234999,
                    OldPrice = 249999,
                    CategoryId = 2,
                    ImageURL = @"\images\product\3c6fadf6-2f30-4c41-97ba-93ad753d3b1b.jpg"
                },



                //Игровые мониторы
                new Product
                {
                    Id = 21,
                    Name = "Монитор игровой Thunderobot KU48F120E",
                    Article = "400095426",
                    Description = "null",
                    Price = 99999,
                    OldPrice = 124999,
                    CategoryId = 3,
                    ImageURL = @"\images\product\dcc68fcb-4661-4099-95a1-9dff72dae6c5.jpg"
                },
                new Product
                {
                    Id = 22,
                    Name = "Монитор игровой Samsung Odyssey Neo G7 S43CG700NI",
                    Article = "400086711",
                    Description = "null",
                    Price = 82999,
                    OldPrice = 89999,
                    CategoryId = 3,
                    ImageURL = @"\images\product\6d341196-9ff3-476e-bb44-768253bee6c7.jpg"
                },
                new Product
                {
                    Id = 23,
                    Name = "Монитор игровой Thunderobot KU27F144M",
                    Article = "400095283",
                    Description = "null",
                    Price = 74999,
                    OldPrice = 79999,
                    CategoryId = 3,
                    ImageURL = @"\images\product\748ed21e-74c9-4d74-afab-316bc14c0597.jpg"
                },
                new Product
                {
                    Id = 24,
                    Name = "Монитор игровой Thunderobot KQ34C144C",
                    Article = "400095286",
                    Description = "null",
                    Price = 37999,
                    OldPrice = 39999,
                    CategoryId = 3,
                    ImageURL = @"\images\product\b3a9764e-2c1d-4fbd-a4f3-ef33a6a3b86c.jpg"
                },
                new Product
                {
                    Id = 25,
                    Name = "Монитор игровой Thunderobot KF27C240L",
                    Article = "400095371",
                    Description = "null",
                    Price = 21999,
                    OldPrice = 0,
                    CategoryId = 3,
                    ImageURL = @"\images\product\bc8bd696-60e0-44dd-a08e-65248563ff21.jpg"
                },
                new Product
                {
                    Id = 26,
                    Name = "Монитор игровой Thunderobot DF27C240L",
                    Article = "400155883",
                    Description = "null",
                    Price = 19999,
                    OldPrice = 23999,
                    CategoryId = 3,
                    ImageURL = @"\images\product\abc69ff0-a2ec-42dc-9b25-38303524c7c6.jpg"
                },


                //Консоли PlayStation 5
                new Product
                {
                    Id = 27,
                    Name = "Консоль Sony PlayStation 5 Blu-Ray Edition CFI-12(00/16/18)A",
                    Article = "40078904",
                    Description = "null",
                    Price = 59999,
                    OldPrice = 0,
                    CategoryId = 4,
                    ImageURL = @"\images\product\f9c6eb3d-78c4-42de-aba4-a81fc6b04835.jpg"
                },
                new Product
                {
                    Id = 28,
                    Name = "Игровая приставка Sony PlayStation 5 Digital Edition CFI-1200B",
                    Article = "40079571",
                    Description = "null",
                    Price = 52999,
                    OldPrice = 0,
                    CategoryId = 4,
                    ImageURL = @"\images\product\65f10155-3b20-4a05-b3e0-f42f33b953f5.jpg"
                },
                new Product
                {
                    Id = 29,
                    Name = "Игровая консоль PS5 Sony CFI-1200",
                    Article = "400122205",
                    Description = "null",
                    Price = 60190,
                    OldPrice = 0,
                    CategoryId = 4,
                    ImageURL = @"\images\product\10215343-9415-4c9f-b184-6ea93ae3200b.jpg"
                },
                new Product
                {
                    Id = 30,
                    Name = "Игровая консоль PS5 Sony Playstation 5 Digital Edition",
                    Article = "400122205",
                    Description = "null",
                    Price = 62390,
                    OldPrice = 0,
                    CategoryId = 4,
                    ImageURL = @"\images\product\3f9df10a-0e34-45fa-aa07-be6440520376.jpg"
                },


                //Игры для PlayStation 5
                new Product
                {
                    Id = 31,
                    Name = "PS5 Electronic Arts FIFA 23",
                    Article = "6020103",
                    Description = "null",
                    Price = 2159,
                    OldPrice = 7199,
                    CategoryId = 5,
                    ImageURL = @"\images\product\bae42bf4-6c57-4fc2-a54a-4986145fa904.jpg"
                },
                new Product
                {
                    Id = 32,
                    Name = "S5 Warner Bros. IE Mortal Kombat 11 Standard",
                    Article = "6020101",
                    Description = "null",
                    Price = 899,
                    OldPrice = 3199,
                    CategoryId = 5,
                    ImageURL = @"\images\product\ec34da26-8d70-420a-bc8a-8d43551878fa.jpg"
                },
                new Product
                {
                    Id = 33,
                    Name = "PS5 игра Focus Home Atomic Heart",
                    Article = "400081693",
                    Description = "null",
                    Price = 5999,
                    OldPrice = 0,
                    CategoryId = 5,
                    ImageURL = @"\images\product\fb8da971-afe0-49dd-8843-62c2096c2677.jpg"
                },
                new Product
                {
                    Id = 34,
                    Name = "PS5 игра Electronic Arts EA Sports FC 24",
                    Article = "400171614",
                    Description = "null",
                    Price = 8999,
                    OldPrice = 0,
                    CategoryId = 5,
                    ImageURL = @"\images\product\9869d232-49a6-4009-a6ad-3b193b48266a.jpg"
                },
                new Product
                {
                    Id = 35,
                    Name = "PS5 игра Sony Marvel's Spider-Man 2",
                    Article = "400177672",
                    Description = "null",
                    Price = 9999,
                    OldPrice = 0,
                    CategoryId = 5,
                    ImageURL = @"\images\product\ea3dfe08-8d17-4394-8400-7c3c573db38d.jpg"
                },


                //Аксуссуары для PlayStation 5
                new Product
                {
                    Id = 36,
                    Name = "Набор кнопок для геймпада PS5 Red Line 5в1",
                    Article = "40076710",
                    Description = "null",
                    Price = 1399,
                    OldPrice = 0,
                    CategoryId = 6,
                    ImageURL = @"\images\product\c6c055b5-b7ff-4460-a84a-697846c80dd2.jpg"
                },
                new Product
                {
                    Id = 37,
                    Name = "Кронштейн для игровых консолей PlayStation 5 HOOK HOOK PS5",
                    Article = "400012658",
                    Description = "null",
                    Price = 2190,
                    OldPrice = 0,
                    CategoryId = 6,
                    ImageURL = @"\images\product\78656946-fa32-4ce3-9d21-1b35419cf4f8.jpg"
                },


                //Игры для PlayStation 4
                new Product
                {
                    Id = 38,
                    Name = "PS4 игра Electronic Arts EA Sports FC 24",
                    Article = "400171569",
                    Description = "null",
                    Price = 8999,
                    OldPrice = 0,
                    CategoryId = 7,
                    ImageURL = @"\images\product\1bb19a42-9077-49d4-936e-daf8ee3c736f.jpg"
                },
                new Product
                {
                    Id = 39,
                    Name = "PS4 игра Focus Home Atomic Heart",
                    Article = "400081648",
                    Description = "null",
                    Price = 5399,
                    OldPrice = 0,
                    CategoryId = 7,
                    ImageURL = @"\images\product\e800ecbb-d315-4a88-acaf-5515e42a5ad5.jpg"
                },
                new Product
                {
                    Id = 40,
                    Name = "PS4 игра Sony Marvel's Человек-Паук: Майлз Моралес",
                    Article = "40074581",
                    Description = "null",
                    Price = 4299,
                    OldPrice = 0,
                    CategoryId = 7,
                    ImageURL = @"\images\product\ae2b4834-5360-46fb-b58e-ea9a0102dd4c.jpg"
                },


                //Аксессуары для PlayStation 4
                new Product
                {
                    Id = 41,
                    Name = "Геймпад для консоли PlayStation 4 DualShock 4 v2 White",
                    Article = "40079473",
                    Description = "null",
                    Price = 6499,
                    OldPrice = 0,
                    CategoryId = 8,
                    ImageURL = @"\images\product\a71f1821-fae8-41ab-9ba1-8066737addb6.jpg"
                },
                new Product
                {
                    Id = 42,
                    Name = "Геймпад для консоли PS4 PlayStation 4 DualShock 4 v2 Black",
                    Article = "40065372",
                    Description = "null",
                    Price = 6999,
                    OldPrice = 0,
                    CategoryId = 8,
                    ImageURL = @"\images\product\d194d5f1-3c84-437c-81d9-6af1a4aca615.jpg"
                },
                new Product
                {
                    Id = 43,
                    Name = "Кронштейн для игровых консолей PlayStation 4",
                    Article = "400012646",
                    Description = "null",
                    Price = 1980,
                    OldPrice = 0,
                    CategoryId = 8,
                    ImageURL = @"\images\product\97864b5b-d5bd-4654-a971-e8e6dc6a198c.jpg"
                },


                //Клавиатуры
                new Product
                {
                    Id = 44,
                    Name = "Игровая клавиатура Logitech G715 Aurora Collection Linear",
                    Article = "50174790",
                    Description = "null",
                    Price = 25999,
                    OldPrice = 0,
                    CategoryId = 9,
                    ImageURL = @"\images\product\fc12df68-cc87-416c-8644-729d338b3469.jpg"
                },
                new Product
                {
                    Id = 45,
                    Name = "Игровая клавиатура Logitech G915 TKL LIGHTSPEED Wireless RGB",
                    Article = "50141080",
                    Description = "null",
                    Price = 20499,
                    OldPrice = 0,
                    CategoryId = 9,
                    ImageURL = @"\images\product\7fffb182-2443-440c-8353-94262a0a195f.jpg"
                },
                new Product
                {
                    Id = 46,
                    Name = "Игровая клавиатура Red Square Keyrox TKL g3ms White",
                    Article = "50141080",
                    Description = "null",
                    Price = 11345,
                    OldPrice = 0,
                    CategoryId = 9,
                    ImageURL = @"\images\product\ef005796-ef47-4619-8c82-50bd30791e95.jpg"
                },
                new Product
                {
                    Id = 47,
                    Name = "Игровая клавиатура Red Square Keyrox Classic Pro",
                    Article = "50167104",
                    Description = "null",
                    Price = 6999,
                    OldPrice = 0,
                    CategoryId = 9,
                    ImageURL = @"\images\product\6ef5baa8-8cc5-4e76-ae8d-02248841d386.jpg"
                },


                //Мышки
                new Product
                {
                    Id = 48,
                    Name = "Игровая мышь Logitech G502 X LIGHTSPEED White",
                    Article = "50175828",
                    Description = "null",
                    Price = 11499,
                    OldPrice = 0,
                    CategoryId = 10,
                    ImageURL = @"\images\product\a43c6909-c1bb-45b3-aaea-f8d6f454673f.jpg"
                },
                new Product
                {
                    Id = 49,
                    Name = "Игровая мышь HyperX Pulsefire Haste Wireless White",
                    Article = "50175847",
                    Description = "null",
                    Price = 6999,
                    OldPrice = 0,
                    CategoryId = 10,
                    ImageURL = @"\images\product\79d33e76-c25a-4097-b33d-81d51858c5dc.jpg"
                },
                new Product
                {
                    Id = 50,
                    Name = "Игровая мышь Logitech G703",
                    Article = "50173476",
                    Description = "null",
                    Price = 8799,
                    OldPrice = 0,
                    CategoryId = 10,
                    ImageURL = @"\images\product\7178780d-d0e0-4cc0-bec6-c8c79d55a5b8.jpg"
                },


                //Гарнитура
                new Product
                {
                    Id = 51,
                    Name = "Игровые наушники Logitech G733 Lightspeed Lilac",
                    Article = "50175523",
                    Description = "null",
                    Price = 17599,
                    OldPrice = 0,
                    CategoryId = 11,
                    ImageURL = @"\images\product\4a7fe03e-6ee1-4d97-94c9-afc68150a83c.jpg"
                },
                new Product
                {
                    Id = 52,
                    Name = "Игровые наушники HyperX Cloud Alpha S",
                    Article = "50175813",
                    Description = "null",
                    Price = 11499,
                    OldPrice = 0,
                    CategoryId = 11,
                    ImageURL = @"\images\product\7d9be698-a312-466e-bb89-f912559264a9.jpg"
                }
                );
        }
    }
}

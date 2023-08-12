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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
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
                    ImageURL = ""
                }
                );
        }
    }
}

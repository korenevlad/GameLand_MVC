﻿// <auto-generated />
using GameLand.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameLand.DataAccess.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230812120229_AddToDbCategoriesTableAndProductsTable")]
    partial class AddToDbCategoriesTableAndProductsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameLand.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CategoriesTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "#A1",
                            Description = "null",
                            Name = "Игровые ноутбуки"
                        },
                        new
                        {
                            Id = 2,
                            Code = "#A2",
                            Description = "null",
                            Name = "Игровые системные блоки"
                        },
                        new
                        {
                            Id = 3,
                            Code = "#A3",
                            Description = "null",
                            Name = "Игровые мониторы"
                        },
                        new
                        {
                            Id = 4,
                            Code = "#B1",
                            Description = "null",
                            Name = "Консоли PlayStation 5"
                        },
                        new
                        {
                            Id = 5,
                            Code = "#B2",
                            Description = "null",
                            Name = "Игры для PlayStation 5"
                        },
                        new
                        {
                            Id = 6,
                            Code = "#B3",
                            Description = "null",
                            Name = "Аксессуары для PlayStation 5"
                        },
                        new
                        {
                            Id = 7,
                            Code = "#C1",
                            Description = "null",
                            Name = "Игры для PlayStation 4"
                        },
                        new
                        {
                            Id = 8,
                            Code = "#C2",
                            Description = "null",
                            Name = "Аксессуары для PlayStation 4"
                        },
                        new
                        {
                            Id = 9,
                            Code = "#D1",
                            Description = "null",
                            Name = "Клавиатуры"
                        },
                        new
                        {
                            Id = 10,
                            Code = "#E1",
                            Description = "null",
                            Name = "Мышки"
                        },
                        new
                        {
                            Id = 11,
                            Code = "#F1",
                            Description = "null",
                            Name = "Гарнитура"
                        });
                });

            modelBuilder.Entity("GameLand.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Article")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OldPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductsTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Article = "400135845",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot 911 M G3 Pro JT009M00BRU",
                            OldPrice = 129999.0,
                            Price = 114999.0
                        },
                        new
                        {
                            Id = 2,
                            Article = "400079994",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot 911 Air Wave D",
                            OldPrice = 85999.0,
                            Price = 59999.0
                        },
                        new
                        {
                            Id = 3,
                            Article = "400132672",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot 911 Plus G3 Pro JT009R00BRU",
                            OldPrice = 134999.0,
                            Price = 124999.0
                        },
                        new
                        {
                            Id = 4,
                            Article = "30067633",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой ASUS TUF Dash F15 FX517ZM-HN157",
                            OldPrice = 105999.0,
                            Price = 99999.0
                        },
                        new
                        {
                            Id = 5,
                            Article = "400156623",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot 911 Air XS D",
                            OldPrice = 0.0,
                            Price = 69999.0
                        },
                        new
                        {
                            Id = 6,
                            Article = "30067660",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой MSI GF63 Thin 11UC-255XRU",
                            OldPrice = 69999.0,
                            Price = 62999.0
                        },
                        new
                        {
                            Id = 7,
                            Article = "30066169",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot 911 MT Pro D",
                            OldPrice = 111999.0,
                            Price = 89999.0
                        },
                        new
                        {
                            Id = 8,
                            Article = "30067313",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой MSI Raider GE78 HX 13VI-206RU (MS-17S1)",
                            OldPrice = 429999.0,
                            Price = 364999.0
                        },
                        new
                        {
                            Id = 9,
                            Article = "400132671",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot Zero G3 Ultra Orange JT009N00BRU",
                            OldPrice = 0.0,
                            Price = 299999.0
                        },
                        new
                        {
                            Id = 10,
                            Article = "4212284",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot Zero Ultra XT",
                            OldPrice = 0.0,
                            Price = 279999.0
                        },
                        new
                        {
                            Id = 11,
                            Article = "30066473",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой MSI Raider GE77HX 12UGS-221RU",
                            OldPrice = 269999.0,
                            Price = 229999.0
                        },
                        new
                        {
                            Id = 12,
                            Article = "4212282",
                            CategoryId = 1,
                            Description = "null",
                            ImageURL = "",
                            Name = "Ноутбук игровой Thunderobot Zero Ultra 7 Yellow",
                            OldPrice = 249999.0,
                            Price = 219999.0
                        },
                        new
                        {
                            Id = 13,
                            Article = "30065216",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой Acer Predator PO3-630",
                            OldPrice = 129999.0,
                            Price = 99999.0
                        },
                        new
                        {
                            Id = 14,
                            Article = "30064738",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой MSI AEGIS Ti5",
                            OldPrice = 332499.0,
                            Price = 299999.0
                        },
                        new
                        {
                            Id = 15,
                            Article = "30064736",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой MSI MAG Codex X5",
                            OldPrice = 0.0,
                            Price = 247499.0
                        },
                        new
                        {
                            Id = 16,
                            Article = "30064351",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой MUST MBM117",
                            OldPrice = 159999.0,
                            Price = 129999.0
                        },
                        new
                        {
                            Id = 17,
                            Article = "30066255",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой Thunderobot BW IV Max D",
                            OldPrice = 174999.0,
                            Price = 129999.0
                        },
                        new
                        {
                            Id = 18,
                            Article = "400089344",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой Thunderobot Black Warrior V Shark 7",
                            OldPrice = 0.0,
                            Price = 299999.0
                        },
                        new
                        {
                            Id = 19,
                            Article = "30065807",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой Raskat STRIKE 520 107290",
                            OldPrice = 86999.0,
                            Price = 81999.0
                        },
                        new
                        {
                            Id = 20,
                            Article = "400156700",
                            CategoryId = 2,
                            Description = "null",
                            ImageURL = "",
                            Name = "Системный блок игровой 4Aces Royal Flush",
                            OldPrice = 249999.0,
                            Price = 234999.0
                        },
                        new
                        {
                            Id = 21,
                            Article = "400095426",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Thunderobot KU48F120E",
                            OldPrice = 124999.0,
                            Price = 99999.0
                        },
                        new
                        {
                            Id = 22,
                            Article = "400086711",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Samsung Odyssey Neo G7 S43CG700NI",
                            OldPrice = 89999.0,
                            Price = 82999.0
                        },
                        new
                        {
                            Id = 23,
                            Article = "400095283",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Thunderobot KU27F144M",
                            OldPrice = 79999.0,
                            Price = 74999.0
                        },
                        new
                        {
                            Id = 24,
                            Article = "400095286",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Thunderobot KQ34C144C",
                            OldPrice = 39999.0,
                            Price = 37999.0
                        },
                        new
                        {
                            Id = 25,
                            Article = "400095371",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Thunderobot KF27C240L",
                            OldPrice = 0.0,
                            Price = 21999.0
                        },
                        new
                        {
                            Id = 26,
                            Article = "400155883",
                            CategoryId = 3,
                            Description = "null",
                            ImageURL = "",
                            Name = "Монитор игровой Thunderobot DF27C240L",
                            OldPrice = 23999.0,
                            Price = 19999.0
                        },
                        new
                        {
                            Id = 27,
                            Article = "40078904",
                            CategoryId = 4,
                            Description = "null",
                            ImageURL = "",
                            Name = "Консоль Sony PlayStation 5 Blu-Ray Edition CFI-12(00/16/18)A",
                            OldPrice = 0.0,
                            Price = 59999.0
                        },
                        new
                        {
                            Id = 28,
                            Article = "40079571",
                            CategoryId = 4,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая приставка Sony PlayStation 5 Digital Edition CFI-1200B",
                            OldPrice = 0.0,
                            Price = 52999.0
                        },
                        new
                        {
                            Id = 29,
                            Article = "400122205",
                            CategoryId = 4,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая консоль PS5 Sony CFI-1200",
                            OldPrice = 0.0,
                            Price = 60190.0
                        },
                        new
                        {
                            Id = 30,
                            Article = "400122205",
                            CategoryId = 4,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая консоль PS5 Sony Playstation 5 Digital Edition",
                            OldPrice = 0.0,
                            Price = 62390.0
                        },
                        new
                        {
                            Id = 31,
                            Article = "6020103",
                            CategoryId = 5,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS5 Electronic Arts FIFA 23",
                            OldPrice = 7199.0,
                            Price = 2159.0
                        },
                        new
                        {
                            Id = 32,
                            Article = "6020101",
                            CategoryId = 5,
                            Description = "null",
                            ImageURL = "",
                            Name = "S5 Warner Bros. IE Mortal Kombat 11 Standard",
                            OldPrice = 3199.0,
                            Price = 899.0
                        },
                        new
                        {
                            Id = 33,
                            Article = "400081693",
                            CategoryId = 5,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS5 игра Focus Home Atomic Heart",
                            OldPrice = 0.0,
                            Price = 5999.0
                        },
                        new
                        {
                            Id = 34,
                            Article = "400171614",
                            CategoryId = 5,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS5 игра Electronic Arts EA Sports FC 24",
                            OldPrice = 0.0,
                            Price = 8999.0
                        },
                        new
                        {
                            Id = 35,
                            Article = "400177672",
                            CategoryId = 5,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS5 игра Sony Marvel's Spider-Man 2",
                            OldPrice = 0.0,
                            Price = 9999.0
                        },
                        new
                        {
                            Id = 36,
                            Article = "40076710",
                            CategoryId = 6,
                            Description = "null",
                            ImageURL = "",
                            Name = "Набор кнопок для геймпада PS5 Red Line 5в1",
                            OldPrice = 0.0,
                            Price = 1399.0
                        },
                        new
                        {
                            Id = 37,
                            Article = "400012658",
                            CategoryId = 6,
                            Description = "null",
                            ImageURL = "",
                            Name = "Кронштейн для игровых консолей PlayStation 5 HOOK HOOK PS5",
                            OldPrice = 0.0,
                            Price = 2190.0
                        },
                        new
                        {
                            Id = 38,
                            Article = "400171569",
                            CategoryId = 7,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS4 игра Electronic Arts EA Sports FC 24",
                            OldPrice = 0.0,
                            Price = 8999.0
                        },
                        new
                        {
                            Id = 39,
                            Article = "400081648",
                            CategoryId = 7,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS4 игра Focus Home Atomic Heart",
                            OldPrice = 0.0,
                            Price = 5399.0
                        },
                        new
                        {
                            Id = 40,
                            Article = "40074581",
                            CategoryId = 7,
                            Description = "null",
                            ImageURL = "",
                            Name = "PS4 игра Sony Marvel's Человек-Паук: Майлз Моралес",
                            OldPrice = 0.0,
                            Price = 4299.0
                        },
                        new
                        {
                            Id = 41,
                            Article = "40079473",
                            CategoryId = 8,
                            Description = "null",
                            ImageURL = "",
                            Name = "Геймпад для консоли PlayStation 4 DualShock 4 v2 White",
                            OldPrice = 0.0,
                            Price = 6499.0
                        },
                        new
                        {
                            Id = 42,
                            Article = "40065372",
                            CategoryId = 8,
                            Description = "null",
                            ImageURL = "",
                            Name = "Геймпад для консоли PS4 PlayStation 4 DualShock 4 v2 Black",
                            OldPrice = 0.0,
                            Price = 6999.0
                        },
                        new
                        {
                            Id = 43,
                            Article = "400012646",
                            CategoryId = 8,
                            Description = "null",
                            ImageURL = "",
                            Name = "Кронштейн для игровых консолей PlayStation 4",
                            OldPrice = 0.0,
                            Price = 1980.0
                        },
                        new
                        {
                            Id = 44,
                            Article = "50174790",
                            CategoryId = 9,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая клавиатура Logitech G715 Aurora Collection Linear",
                            OldPrice = 0.0,
                            Price = 25999.0
                        },
                        new
                        {
                            Id = 45,
                            Article = "50141080",
                            CategoryId = 9,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая клавиатура Logitech G915 TKL LIGHTSPEED Wireless RGB",
                            OldPrice = 0.0,
                            Price = 20499.0
                        },
                        new
                        {
                            Id = 46,
                            Article = "50141080",
                            CategoryId = 9,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая клавиатура Red Square Keyrox TKL g3ms White",
                            OldPrice = 0.0,
                            Price = 11345.0
                        },
                        new
                        {
                            Id = 47,
                            Article = "50167104",
                            CategoryId = 9,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая клавиатура Red Square Keyrox Classic Pro",
                            OldPrice = 0.0,
                            Price = 6999.0
                        },
                        new
                        {
                            Id = 48,
                            Article = "50175828",
                            CategoryId = 10,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая мышь Logitech G502 X LIGHTSPEED White",
                            OldPrice = 0.0,
                            Price = 11499.0
                        },
                        new
                        {
                            Id = 49,
                            Article = "50175847",
                            CategoryId = 10,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая мышь HyperX Pulsefire Haste Wireless White",
                            OldPrice = 0.0,
                            Price = 6999.0
                        },
                        new
                        {
                            Id = 50,
                            Article = "50173476",
                            CategoryId = 10,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровая мышь Logitech G703",
                            OldPrice = 0.0,
                            Price = 8799.0
                        },
                        new
                        {
                            Id = 51,
                            Article = "50175523",
                            CategoryId = 11,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровые наушники Logitech G733 Lightspeed Lilac",
                            OldPrice = 0.0,
                            Price = 17599.0
                        },
                        new
                        {
                            Id = 52,
                            Article = "50175813",
                            CategoryId = 11,
                            Description = "null",
                            ImageURL = "",
                            Name = "Игровые наушники HyperX Cloud Alpha S",
                            OldPrice = 0.0,
                            Price = 11499.0
                        });
                });

            modelBuilder.Entity("GameLand.Models.Product", b =>
                {
                    b.HasOne("GameLand.Models.Category", "Category_of_product")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category_of_product");
                });
#pragma warning restore 612, 618
        }
    }
}

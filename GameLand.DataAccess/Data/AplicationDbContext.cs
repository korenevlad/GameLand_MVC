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
                new Category { Id = 11, Name = "Гарнитура", Code = "#F1", Description = "null" });
        }
    }
}

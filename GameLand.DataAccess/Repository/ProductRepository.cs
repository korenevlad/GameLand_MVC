using GameLand.DataAccess.Data;
using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
            
        }
        public void Update(Product obj)
        {
            var objFromDb = _db.ProductsTable.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Article = obj.Article;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.OldPrice = obj.OldPrice;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageURL != null)
                {
                    objFromDb.ImageURL = obj.ImageURL;
                }
            }
        }
    }
}

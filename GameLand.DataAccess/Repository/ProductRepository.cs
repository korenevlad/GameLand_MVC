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
        private readonly AplicationDbContext _db;
        public ProductRepository(AplicationDbContext db): base(db)
        {
            _db = db;
            
        }
        public void Update(Product obj)
        {
            _db.ProductTable.Update(obj);
        }
    }
}

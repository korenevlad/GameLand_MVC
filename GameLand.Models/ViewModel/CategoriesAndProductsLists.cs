using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.Models.ViewModel
{
    public class CategoriesAndProductsLists
    {
        public IEnumerable<Category> categoriesList { get; set; }
        public IEnumerable<Product> productsList { get; set; }
    }
}

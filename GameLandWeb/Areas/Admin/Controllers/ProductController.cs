using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using GameLand.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameLandWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category_of_product").ToList();
            return View(productList);
        }


        public IActionResult Upsert(int? id)
        {
            IEnumerable<SelectListItem> listItemCategory = _unitOfWork.Category.GetAll().Select(u =>
                new SelectListItem { Text = u.Name, Value = u.Id.ToString()});

            ProductVM product_obj = new ProductVM
            {
                Product = new Product(),
                CategoryList = listItemCategory
            };

            if (id == null || id == 0)
            {
                return View(product_obj);
            }
            else
            {
                product_obj.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(product_obj);
            }
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category_of_product").ToList();
            return Json(new { data = productList });
        }

        #endregion
    }
}

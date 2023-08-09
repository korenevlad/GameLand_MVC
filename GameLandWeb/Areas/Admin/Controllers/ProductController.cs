using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using Microsoft.AspNetCore.Mvc;

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

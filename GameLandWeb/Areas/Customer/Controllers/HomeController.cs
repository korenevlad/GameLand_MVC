using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using GameLand.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameLandWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            CategoriesAndProductsLists categoriesAndproductsLists = new CategoriesAndProductsLists
            {
                categoriesList = _unitOfWork.Category.GetAll(),
                productsList = _unitOfWork.Product.GetAll(includeProperties: "Category_of_product")
            };
            return View(categoriesAndproductsLists);
        }

        public IActionResult Details(int? id)
        {
            Product product = _unitOfWork.Product.Get(u => u.Id == id, includeProperties: "Category_of_product");
            return View(product);
        }
        public IActionResult ProductListOfCategory(int? id)
        {
            List<Product> categoryListFromBd = _unitOfWork.Product.GetAll().ToList();
            List<Product> resultcategoryList = new List<Product>();
            foreach(var product in categoryListFromBd)
            {
                if(product.CategoryId == id)
                {
                    resultcategoryList.Add(product);
                }
            }
            return View(resultcategoryList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
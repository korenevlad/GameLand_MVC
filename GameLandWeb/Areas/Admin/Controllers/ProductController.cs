using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using GameLand.Models.ViewModel;
using GameLand.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace GameLandWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
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

        [HttpPost]
        public IActionResult Upsert(ProductVM product_obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string pathToProductImagesFolder = Path.Combine(wwwRootPath, @"images\product");

                    if (!string.IsNullOrEmpty(product_obj.Product.ImageURL))
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, product_obj.Product.ImageURL.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(pathToProductImagesFolder, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    product_obj.Product.ImageURL = @"\images\product\" + fileName;


                }
                if(product_obj.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(product_obj.Product);
                    TempData["success"] = "Товар добавлен успешно!";
                }
                else
                {
                    _unitOfWork.Product.Update(product_obj.Product);
                    TempData["success"] = "Товар обновлен успешно!";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else
            {
                product_obj.CategoryList = _unitOfWork.Category.GetAll().Select(u =>
                    new SelectListItem { Text = u.Name, Value = u.Id.ToString() });

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

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Product productToBeDelete = _unitOfWork.Product.Get(u => u.Id == id);
            if(productToBeDelete == null)
            {
                return Json(new { success = false, message = "Ошибка при удалении товара!" });
            }
            string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, productToBeDelete.ImageURL.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
            _unitOfWork.Product.Remove(productToBeDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Товар удален успешно!" });
        }

        #endregion
    }
}

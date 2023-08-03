using GameLand.DataAccess.Repository.IRepository;
using GameLand.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameLandWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {
            List<Category> categoryList = _unitOfWork.Category.GetAll().ToList();
            return View(categoryList);
        }


        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                return View(new Category());
            }
            else
            {
                Category findedCategory = _unitOfWork.Category.Get(u => u.Id == id);
                return View(findedCategory);
            }
        }


        [HttpPost]
        public IActionResult Upsert(Category obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.Id == 0)
                {
                    _unitOfWork.Category.Add(obj);
                    TempData["success"] = "Категория добавлена успешно!";
                }
                else
                {
                    _unitOfWork.Category.Update(obj);
                    TempData["success"] = "Категория обновлена успешно!";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else { return View(obj); }
        }
    }
}

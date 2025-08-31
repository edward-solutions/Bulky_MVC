using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWOrk _unitOfWork;
        public ProductController(IUnitOfWOrk unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Products.GetAll().ToList();
            return View(objProductList);
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> categoryList = _unitOfWork.Categories.GetAll().ToList().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.CategoryId.ToString()
            });
            ViewBag.CategoryList = categoryList;    
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Products.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product created successfully.";
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Product? Product = _db.Products.Find(id); Find only works for ID's
            //Product? Product = _db.Products.Where(x => x.Id == id).FirstOrDefault(); //Also possible to use Where()
            Product? Product = _unitOfWork.Products.Get(x => x.Id == id); //FirstOrDefault could also work for other properties
            if (Product == null)
            {
                return NotFound();
            }
            return View(Product);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Products.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Product updated successfully.";
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product? Product = _unitOfWork.Products.Get(x => x.Id == id); //FirstOrDefault could also work for other properties
            if (Product == null)
            {
                return NotFound();
            }
            return View(Product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? Product = _unitOfWork.Products.Get(x => x.Id == id);
            if (Product == null)
            {
                return NotFound();
            }
            _unitOfWork.Products.Remove(Product);
            _unitOfWork.Save();
            TempData["success"] = "Product deleted successfully.";
            return RedirectToAction("Index", "Product");
        }
    }
}

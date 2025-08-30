using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

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
            List<Product> objCategoryList = _unitOfWork.Products.GetAll().ToList();
            return View(objCategoryList);
        }
    }
}

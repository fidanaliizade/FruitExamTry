using FruitExamTry.Areas.Manage.ViewModels.ProductVMs;
using FruitExamTry.DAL;
using Microsoft.AspNetCore.Mvc;

namespace FruitExamTry.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;

        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCreateVM vm)
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }
        public IActionResult Update(ProductUpdateVM vm)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}

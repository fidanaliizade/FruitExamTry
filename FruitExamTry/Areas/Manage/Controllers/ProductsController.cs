using FruitExamTry.Areas.Manage.ViewModels.ProductVMs;
using FruitExamTry.DAL;
using FruitExamTry.Helpers;
using FruitExamTry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FruitExamTry.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public ProductsController(AppDbContext db, IWebHostEnvironment env)

        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products  = await _db.Products.ToListAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCreateVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //if (!vm.Image.CheckContent)
            //{

            //}


            Product product = new Product()
            {
                Title = vm.Title,
                Category = vm.Category,
                ImgUrl = vm.Image.Upload(_env.WebRootPath, @"\Upload]Product\")
            };
            return View();
        }
        public async Task<IActionResult> Update(int id)
        {
            Product product =  await _db.Products.FindAsync(id);
            ProductUpdateVM updated = new ProductUpdateVM()
            {
                Id = product.Id,
                Title = product.Title,
                Category = product.Category,             
            };

            return View(updated);
        }
        [HttpPost]
        public IActionResult Update(ProductUpdateVM vm)
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            Product product = _db.Products.Find(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

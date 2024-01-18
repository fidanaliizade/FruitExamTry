using System.ComponentModel.DataAnnotations;

namespace FruitExamTry.Areas.Manage.ViewModels.ProductVMs
{
    public class ProductUpdateVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        public IFormFile? Image { get; set; }
    }
}

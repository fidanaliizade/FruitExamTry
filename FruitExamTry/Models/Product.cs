using FruitExamTry.Models.BaseModel;

namespace FruitExamTry.Models
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string? ImgUrl { get; set; }
    }
}

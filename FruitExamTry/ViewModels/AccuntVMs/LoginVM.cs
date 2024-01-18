using System.ComponentModel.DataAnnotations;

namespace FruitExamTry.ViewModels.AccuntVMs
{
    public class LoginVM
    {
        [Required]
        public string UserNameOrEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

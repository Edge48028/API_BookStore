using System.ComponentModel.DataAnnotations;

namespace API_BookStore.Models
{
    public class CategoryModel
    {
        [Required]
        [MaxLength(50)]
        public string TypeName { get; set; }
    }
}

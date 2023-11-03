using System.ComponentModel.DataAnnotations;

namespace API_BookStore.Models
{
    public class CategoryVM
    {
        public int TypeCode { get; set; }
        public string TypeName { get; set; }
    }
}

using MyApiNetCore6.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace API_BookStore.Data
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int TypeCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string TypeName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

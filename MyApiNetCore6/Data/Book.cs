using API_BookStore.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyApiNetCore6.Data
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public byte Discount { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }

        public int? TypeCode { get; set; }
        [ForeignKey("TypeCode")]
        public Category Category { get; set; }

        // Define a navigation property for OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Book()
        {
            OrderDetails = new List<OrderDetail>(); // Initialize the collection
        }
    }
}

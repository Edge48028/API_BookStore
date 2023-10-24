using MyApiNetCore6.Data;
using System.ComponentModel.DataAnnotations;

namespace API_BookStore.Data
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int Quantity { get; set; }
        [Range(0, 100)]
        public int PurchaseQuantity { get; set; }
        [Range(0, double.MaxValue)]
        public double UnitPriceatSale { get; set; }
        public byte Discount { get; set; }

        // relationship
        public Order Order { get; set; }
        public Book Book { get; set; }

    }
}

using System.Collections.Generic;

namespace API_BookStore.Data
{
    public enum OrderStatus
    {
        New = 0, Payment = 1, Complete = 2, Cancelled = -1
    }

    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderStatus { get; set; }
        public string Receiver { get; set; }
        public string ReceiverAddress { get; set; }
        public string NumberPhone { get; set; }

        // Define a navigation property for OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>(); // Initialize the collection
        }
    }
}

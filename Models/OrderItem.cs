namespace BlazorOnlineShop.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }

    }
}

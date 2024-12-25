namespace BlazorOnlineShop.Models
{
    public class OrderItemDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal TotalPrice => Quantity * ProductPrice;  // Calculated property
        public DateTime OrderedDate { get; set; }
    }
}
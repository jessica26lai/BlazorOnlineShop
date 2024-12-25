namespace BlazorOnlineShop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientAddress { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}

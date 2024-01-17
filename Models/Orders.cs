namespace DeliveryApp.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int? SerialNumber { get; set; }
        public string? SenderCity {  get; set; }
        public string? SenderAddress { get; set; }
        public string? RecipientCity { get; set; }
        public string? RecipientAddress { get; set;}
        public double Weight { get; set; }
        public DateTime PickupDate { get; set; }
    }
}
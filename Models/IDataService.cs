namespace DeliveryApp.Models
{
    public interface IDataService
    {
        public List<Orders> GetAllOrders();

        public int SerialNumber();
    }
}

namespace DeliveryApp.Models
{
    public class DataService : IDataService
    {
        public readonly ApplicationContext _dbContext;
        public DataService(ApplicationContext dbContext) {  _dbContext = dbContext; }

        public List<Orders> GetAllOrders()
        {
            return _dbContext.Orders.Select(o => new Orders
            {
                Id = o.Id,
                SerialNumber = o.SerialNumber,
                SenderCity = o.SenderCity,
                SenderAddress = o.SenderAddress,
                RecipientCity = o.RecipientCity,
                RecipientAddress = o.RecipientAddress,
                Weight = o.Weight,
                PickupDate = o.PickupDate,
            }).ToList();
        }

        public int SerialNumber()
        {
            Random rnd = new Random();
            int SerialNumber;
            do
            {
                SerialNumber = rnd.Next(10000,99999999);
            } while(_dbContext.Orders.Any(o => o.Id == SerialNumber));

            return SerialNumber;

        }
    }
}

using DeliveryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeliveryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _dbContext;
        private readonly IDataService _dataService;

        public HomeController(ILogger<HomeController> logger, ApplicationContext dbContext, IDataService dataService)
        {
            _logger = logger;
            _dbContext = dbContext;
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            var orders = _dataService.GetAllOrders();
            return View(orders);
        }

        [HttpPost]
        public IActionResult Create([Bind("SenderCity, SenderAddress, RecipientCity, RecipientAddress, Weight, PickupDate")] Orders order)
        {
            if (ModelState.IsValid)
            {
                order.SerialNumber = _dataService.SerialNumber();
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                TempData["SuccessMessage"] = "Заказ успешно создан";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Console.WriteLine("ОШИБКА ДАННЫХ");
            }
            return View(order);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Order(int id)
        {
            var order = _dbContext.Orders.Find(id);

            return View(order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

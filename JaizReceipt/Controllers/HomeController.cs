using JaizReceipt.DTO;
using JaizReceipt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JaizReceipt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = new ReceiptViewModel();
            model.MerchantName = "LIZPEE GLOBAL RESOURCES";
            model.Location = "NO. 174 NTA/MBUORA RD, PORTHARCOURT";
            model.TerminalId = 23011845;
            model.Stan = 003862;
            model.Date_time= new DateTime(2022, 08, 30, 17, 32, 58);
            model.Amount = 0.01M;
            model.CardNo = "539941******3369";

            model.expiryDate = "11/24";
            model.AuthorizationCode = "000000";
            model.ResponseCode = 91;
            model.AID = "A0000000041010";
            model.RRN = 000210002450;
            model.PTAD = "Global Accelerex";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
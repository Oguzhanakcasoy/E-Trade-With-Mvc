using Microsoft.AspNetCore.Mvc;

namespace E_TradeProje.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

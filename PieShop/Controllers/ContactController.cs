using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
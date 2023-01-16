using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

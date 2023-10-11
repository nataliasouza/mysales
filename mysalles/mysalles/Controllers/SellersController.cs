using Microsoft.AspNetCore.Mvc;

namespace mysalles.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

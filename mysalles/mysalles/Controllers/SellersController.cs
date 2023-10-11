using Microsoft.AspNetCore.Mvc;
using mysalles.Models;
using mysalles.Services;

namespace mysalles.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAllSellers();
            return View(list);
        }

        // GET: Sellers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller) 
        { 
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using ProjectEcommerce.Models;

namespace ProjectEcommerce.Controllers.User
{
    public class UserController : Controller
    {
        private readonly QuanLyDuLieuContext _context;
        public UserController(QuanLyDuLieuContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items=_context.Products.ToList();
            return View(items);
        }
        public IActionResult Login()
        {
            var items = _context.Products.ToList();
            return View(items);
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult ProductDetail2()
        {
            return View();
        }
        public IActionResult ProductDetail3()
        {
            return View();
        }
        public IActionResult ProductDetail4()
        {
            return View();
        }
        public IActionResult ProductDetail5()
        {
            return View();
        }
    }
}

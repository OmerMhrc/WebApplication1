using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.models;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var model = new HomePageViewModel
            {
                TrendKitaplar = BookRepository.Books
            };

            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
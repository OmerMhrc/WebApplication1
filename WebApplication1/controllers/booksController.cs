using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.models;

namespace WebApplication1.controllers{
    public class booksController : Controller{
       
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        
        [HttpGet]
        public IActionResult List(int? id, string q){
            // var kelime = HttpContext.Request.Query["q"].ToString();
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var genreid = RouteData.Values["id"];

            var books = BookRepository.Books;

            if (id != null)            {
                books = books.Where(m => m.GenreId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q)){
                books = books.Where(i =>
                i.KitapAdi.ToLower().Contains(q.ToLower()) ||
                i.Aciklama.ToLower().Contains(q.ToLower())).ToList();
            }

            var model = new BooksViewModel{
                Kitaplar = books
            };

            return View("List", model);
        }

        //localhost;44361/books/details
        [HttpGet]
        public IActionResult Details(int id){
            return View(BookRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(string KitapAdi , string Aciklama , string KitapYazari , string YayinTarihi ,string ImageUrl , int GenreId){

            var m = new Book{
                KitapAdi = KitapAdi,
                Aciklama = Aciklama,
                YayinTarihi = YayinTarihi,
                KitapYazari = KitapYazari,
                ImageUrl = ImageUrl ,
                GenreId = GenreId
            };

            BookRepository.addBook(m);

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            return View(BookRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Book m){

            return View();
        }
    }
}

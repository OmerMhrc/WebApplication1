using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.ViewComponents{
    public class GenresViewComponent : ViewComponent{
        public IViewComponentResult Invoke(){
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(GenreRepository.Genres);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using WebApplication1.models;

namespace WebApplication1.Data{
    public class GenreRepository{
        private static readonly List<Genre> _genres = null;
        static GenreRepository(){
            _genres = new List<Genre>(){
                new Genre {GenreId = 1 , Name = "Dünya klasikleri"},
                new Genre {GenreId = 2 , Name = "Felsefe"},
                new Genre {GenreId = 3 , Name = "Macera"},
                new Genre {GenreId = 4 , Name = "Roman"},
                new Genre {GenreId = 5 , Name = "Spor"},
                new Genre {GenreId = 6 , Name = "Bilim Kurgu"}
            };
        }
        public static List<Genre> Genres{
            get { return _genres; }
        }

        public static void Add(Genre genre){
            _genres.Add(genre);
        }

        public static Genre GetById(int id){
            return _genres.FirstOrDefault(g => g.GenreId == id);
        }
    }
}
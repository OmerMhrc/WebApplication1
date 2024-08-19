using System.Collections.Generic;
using System.Linq;
using WebApplication1.models;

namespace WebApplication1.Data
{
    public class BookRepository
    {

        private static readonly List<Book> _books = null;

        static BookRepository(){

         _books = new List<Book>(){
          new Book{
            BookId = 1,
            KitapAdi = "To Kill a Mockingbird",
            KitapYazari = "Harper Lee",
            YayinTarihi = "1960",
            Aciklama = "Bir ırkçılık ve adalet mücadelesi hikayesi.",
            Sayfalar = new string[] {"sayfa1", "sayfa2"},
            GenreId = 1,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 2,
            KitapAdi = "1984",
            KitapYazari = "George Orwell",
            YayinTarihi = "1949",
            Aciklama = "Totaliter bir rejimde birey olma mücadelesi.",
            Sayfalar = new string[] {"sayfa3", "sayfa4"},
            GenreId = 2,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 3,
            KitapAdi = "Moby Dick",
            KitapYazari = "Herman Melville",
            YayinTarihi = "1851",
            Aciklama = "Büyük beyaz balina Moby Dick'in peşinde bir kaptanın öyküsü.",
            Sayfalar = new string[] {"sayfa5", "sayfa6"},
            GenreId = 3,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 4,
            KitapAdi = "Pride and Prejudice",
            KitapYazari = "Jane Austen",
            YayinTarihi = "1813",
            Aciklama = "Aşk ve sınıf farklarının ele alındığı bir klasik.",
            Sayfalar = new string[] {"sayfa7", "sayfa8"},
            GenreId = 4,
            ImageUrl = "kitap.jpeg"
           },

          new Book{
            BookId = 5,
            KitapAdi = "The Great Gatsby",
            KitapYazari = "F. Scott Fitzgerald",
            YayinTarihi = "1925",
            Aciklama = "Amerikan rüyası ve sosyal sınıflar üzerine bir inceleme.",
            Sayfalar = new string[] {"sayfa9", "sayfa10"},
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 6,
            KitapAdi = "Brave New World",
            KitapYazari = "Aldous Huxley",
            YayinTarihi = "1932",
            Aciklama = "Teknolojinin ve toplum mühendisliğinin birey üzerindeki etkisi.",
            Sayfalar = new string[] {"sayfa11", "sayfa12"},
            GenreId = 2,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 7,
            KitapAdi = "The Catcher in the Rye",
            KitapYazari = "J.D. Salinger",
            YayinTarihi = "1951",
            Aciklama = "Genç bir adamın toplumla ve kendisiyle mücadelesi.",
            Sayfalar = new string[] {"sayfa13", "sayfa14"},
            GenreId = 3,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 8,
            KitapAdi = "Jane Eyre",
            KitapYazari = "Charlotte Brontë",
            YayinTarihi = "1847",
            Aciklama = "Küçük bir yetimin güçlü bir kadın haline gelme öyküsü.",
            Sayfalar = new string[] {"sayfa15", "sayfa16"},
            GenreId = 4,
            ImageUrl = "kitap.jpeg"
          },

          new Book{
            BookId = 9,
            KitapAdi = "The Hobbit",
            KitapYazari = "J.R.R. Tolkien",
            YayinTarihi = "1937",
            Aciklama = "Bir hobbitin macera dolu yolculuğu.",
            Sayfalar = new string[] {"sayfa17", "sayfa18"},
            GenreId = 1,
            ImageUrl = "kitap.jpeg"
          },
     
          new Book{
            BookId = 10,
            KitapAdi = "Fahrenheit 451",
            KitapYazari = "Ray Bradbury",
            YayinTarihi = "1953",
            Aciklama = "Kitapların yasaklandığı bir gelecekte birey olma mücadelesi.",
            Sayfalar = new string[] {"sayfa19", "sayfa20"},
            GenreId = 1,
            ImageUrl = "kitap.jpeg"
          }
        };
    }
        public static List<Book> Books{
            get { return _books; }
        }
        public static void addBook(Book book){
            book.BookId = _books.Count() + 1;
            _books.Add(book);
        }
        public static Book GetById(int id){
            return _books.FirstOrDefault(m => m.BookId == id);
        }
    }
}
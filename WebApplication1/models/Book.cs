using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.models
{
    public class Book
    {
        [Required]
        public int BookId { get; set; }
        //[DisplayName("Başlık")]
        [Required]
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public string YayinTarihi { get; set; }
        public string Aciklama { get; set; }
        public string[] Sayfalar { get; set; }
        public string ImageUrl { get; set; }
        public int GenreId { get; set; }
    }
}
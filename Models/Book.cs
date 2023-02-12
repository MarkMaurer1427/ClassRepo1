using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Book
    {
        [Required]
        public int BookId { set; get; }

        [Required]
        [MaxLength(200)]
        public string Title { set; get; }

        [Required]
        [MaxLength(50)]
        public string Author { set; get; }

        [Required]
        public Language LanguageId { set; get; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public class Book
    {
        [Required]
        public int Id { set; get; }

        [Required]
        [MaxLength(50)]
        public string Title { set; get; }

        [Required]
        [MaxLength(50)]
        public string Author { set; get; }

        [Required]
        public Language Language { set; get; }


    }
}

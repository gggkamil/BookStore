using System.ComponentModel.DataAnnotations;

namespace E_commerce.Models
{
    public class Bookstore
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}

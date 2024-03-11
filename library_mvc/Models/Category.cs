using System.ComponentModel.DataAnnotations;

namespace library_mvc.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;
    }
}
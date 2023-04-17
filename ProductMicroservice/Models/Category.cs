using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required, StringLength(100)]
        public string? CategoryName { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;
    }
}

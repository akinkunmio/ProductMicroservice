using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public decimal Cost { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}

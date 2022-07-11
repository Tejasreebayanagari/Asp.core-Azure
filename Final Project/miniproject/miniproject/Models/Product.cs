using System.ComponentModel.DataAnnotations;

namespace miniproject.Models
{
    
        public class Products
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string? ProductName { get; set; }
            public int Price { get; set; }
            public string? brand { get; set; }
            public string? ManufactureDate { get; set; }
            public string? ExpirationDate { get; set; }
        }
    
}

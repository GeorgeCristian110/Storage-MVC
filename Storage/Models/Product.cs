using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        
        [StringLength(100)]
        public required string Name { get; set; }

        [Range(0, 1000000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
                
        [StringLength(50)]
        public required string Category { get; set; }

        [StringLength(10)]
        public required string Shelf { get; set; }

        [Range(0, 10000)]
        public int Count { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
    }
}

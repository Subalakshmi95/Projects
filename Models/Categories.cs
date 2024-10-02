using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CategoryName { get; set; }
        [Required]
        public string ?CategoryDescription { get; set; }
        public double CategoryPrice { get; set; }

    }
}

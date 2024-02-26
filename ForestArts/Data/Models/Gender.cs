using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForestArts.Data.Models
{
    [Comment("Represents the gender category for a product.")]
    public class Gender
    {
        [Key]
        [Comment("Unique identifier for the gender.")]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the gender category, e.g., Men, Women, Unisex")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}

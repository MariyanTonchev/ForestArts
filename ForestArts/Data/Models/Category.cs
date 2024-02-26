using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForestArts.Data.Models
{
    [Comment("Represents the category for a product.")]
    public class Category
    {
        [Key]
        [Comment("Unique identifier for the category.")]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the category.")]
        public string Name { get; set; } = string.Empty;
    }
}
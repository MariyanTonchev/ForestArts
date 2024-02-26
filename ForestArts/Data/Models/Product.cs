using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestArts.Data.Models
{
    [Comment("Represents the product.")]
    public class Product
    {
        [Key]
        [Comment("Unique identifier for the product.")]
        public int Id { get; set; }

        [Required]
        [Comment("Name of the product.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Descriptive text about the product.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Indicates if the product is visible to all users on the platform.")]
        public bool IsPublic { get; set; }

        [Required]
        [Comment("Manufacturer's code for the product.")]
        public string ProductCode { get; set; } = string.Empty;

        [Required]
        [Comment("Identifier for the gender the product belongs to.")]
        public int GenderId { get; set; }

        [Required]
        [Comment("Identifier for the category the product belongs to.")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Regular price of the product without any discounts.")]
        public decimal RegularPrice { get; set; }

        [Comment("Sale price of the product if it is on sale. Nullable to indicate that there may not be a sale price.")]
        public decimal? SalePrice { get; set; }

        [Required]
        [Comment("Indicates if the product is currently in stock.")]
        public bool InStock { get; set; }

        [ForeignKey(nameof(GenderId))]
        public virtual Gender Gender { get; set; } = null!;

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<ProductTag> ProductsTags { get; set; } = new List<ProductTag>();
        public virtual ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();


    }
}

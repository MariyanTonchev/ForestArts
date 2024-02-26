using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestArts.Data.Models
{
    [Comment("Represents the image for a product.")]
    public class ProductImage
    {
        [Key]
        [Comment("Unique identifier for the product image.")]
        public int Id { get; set; }

        [Required]
        [Comment("Foreign key to associate with Product.")]
        public int ProductId { get; set; } 

        [Required]
        [Comment("Path to the image file on the server.")]
        public string ImagePath { get; set; } = string.Empty;

        [Required]
        [Comment("Alternate text for the image.")]
        public string AltText { get; set; } = string.Empty;

        [Required]
        [Comment("Order in which to display the images.")]
        public int DisplayOrder { get; set; }

        [Required]
        [Comment("Flag to identify the main image for the product.")]
        public bool IsMainImage { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;
    }
}
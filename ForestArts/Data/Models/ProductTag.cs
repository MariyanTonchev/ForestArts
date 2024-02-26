using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestArts.Data.Models
{
    [Comment("Represents the join table for the many-to-many relationship between Products and Tags.")]
    public class ProductTag
    {
        [Required]
        [Comment("Unique identifier for the Product entity. This is part of the composite primary key - (ProductId, TagId).")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Unique identifier for the Tag entity. This is part of the composite primary key - (ProductId, TagId).")]
        public int TagId { get; set; }

        [ForeignKey(nameof(TagId))]
        public Tag Tag { get; set; } = null!;
    }
}
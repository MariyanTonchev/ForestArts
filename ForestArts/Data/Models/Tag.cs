using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForestArts.Data.Models
{
    public class Tag
    {
        [Key]
        [Comment("Unique identifier for the tag.")]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the tag.")]
        public string Name { get; set; } = string.Empty;

        public ICollection<ProductTag> ProductsTags { get; set; } = new List<ProductTag>();
    }
}
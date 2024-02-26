using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForestArts.Data.Models
{
    [Comment("Represents the review for a product given by a user.")]
    public class Review
    {
        [Key]
        [Comment("Unique identifier for the review.")]
        public int Id { get; set; }

        [Required]
        [Comment("Foreign key to associate with user.")]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [Comment("Foreign key to associate with product")]
        public int ProductId { get; set; }

        [Required]
        [Comment("The rating given by the user.")]
        public int Rating { get; set; }

        [Required]
        [Comment("The comment text of the review.")]
        public string Comment { get; set; } = string.Empty;

        [Required]
        [Comment("the date and time when the review was posted.")]
        public DateTime DatePosted { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
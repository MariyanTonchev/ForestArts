using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestArts.Data.Models
{
    [Comment("Represents the order of the user.")]
    public class Order
    {
        [Key]
        [Comment("Unique identifier for the order.")]
        public int Id { get; set; }

        [Required]
        [Comment("Identifier for the user the order belongs to.")]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [Comment("Date and time of the order.")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Precision(14,2)]
        [Comment("Total amount of the order.")]
        public decimal TotalAmount { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
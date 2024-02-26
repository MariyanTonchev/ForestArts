using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForestArts.Data.Models
{
    [Comment("Represents the order item, detailing each product within an order.")]
    public class OrderItem
    {
        [Key]
        [Comment("Unique identifier for the order item.")]
        public int Id { get; set; }

        [Required]
        [Comment("This identifies the order to which the item belongs")]
        public int OrderId { get; set; }

        [Required]
        [Comment("This identifies the product being ordered.")]
        public int ProductId { get; set; }

        [Required]
        [Comment("the quantity of the product being ordered")]
        public int Quantity { get; set; }

        [Required]
        [Comment("The price of the product at the time of the order.")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; } = null!;

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;
    }
}
using Microsoft.AspNetCore.Identity;

namespace ForestArts.Data.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}

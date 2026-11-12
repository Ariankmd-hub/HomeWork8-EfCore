using BookStore.Domain.Common;
/// <summary>
/// Represents the shopping cart of a single user.
/// </summary>

namespace BookStore.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int UserId { get; set; }

        public User User { get; set; } = null!;
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}

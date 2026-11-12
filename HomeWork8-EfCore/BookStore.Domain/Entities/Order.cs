using BookStore.Domain.Common;
/// <summary>
/// Represents a placed order by a user. Contains the order items and total price.
/// </summary>

namespace BookStore.Domain.Entities
{
    public class Order : BaseEntity
    {
        public decimal TotalPrice { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;


        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


    }
}

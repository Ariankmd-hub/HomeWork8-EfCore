using BookStore.Domain.Common;


namespace BookStore.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; } = 1;
        public int BookId { get; set; }

        // Navigation property 
        public Book Book { get; set; } = null!;

        public int OrderId { get; set; }
        // navigation property
        public Order Order { get; set; } = null!; 
    }
}

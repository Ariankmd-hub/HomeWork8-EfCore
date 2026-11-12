using BookStore.Domain.Common;

namespace BookStore.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public int Quantity { get; set; } = 1;
        
        public int BookId { get; set; }
        
        // Navigation Property 
        public Book Book { get; set; } = null!;
        

        public int CartId { get; set; }
        // Navigation Property 
        public Cart Cart { get; set; } = null!;
    }
}

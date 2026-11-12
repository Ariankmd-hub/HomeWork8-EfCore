using BookStore.Domain.Common;
/// <summary>
/// Represents a book available in the store, including its price and stock.
/// Each book belongs to exactly one category.
/// </summary>

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }


        // Relation with Category ! 
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;




    }
}

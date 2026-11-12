using BookStore.Domain.Common;

/// <summary>
/// Represents a book category. One category can contain many books.
/// </summary>

namespace BookStore.Domain.Entities
{
    public class Category : BaseEntity
    {

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // for Relation 1 to many .
        public ICollection<Book> Books { get; set; } = new List<Book>();


    }
}

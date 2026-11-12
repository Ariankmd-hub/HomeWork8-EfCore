using BookStore.Domain.Common;
/// <summary>
/// Represents a registered customer who can own a cart and place orders.
/// </summary>

namespace BookStore.Domain.Entities
{
    public class User : BaseEntity
    {

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
    }
}

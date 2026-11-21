namespace BookStore.Domain.Common
/// <summary>
/// Base class for all entities.
/// Holds the shared identity and audit fields (Id, CreatedAtUtc, UpdatedAtUtc)
/// so that every entity does not repeat them.
/// </summary>
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } 

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAtUtc { get; set; }
    }
}

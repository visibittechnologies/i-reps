using PM.Core.Domain.Boards;
using PM.Core.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PM.Core.Domain.Projects;

/// <summary>
/// Password format
/// </summary>
public partial class Status : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the board identifier
    /// </summary>
    public long BoardId { get; set; }

    /// <summary>
    /// Gets or sets the issue type name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    [StringLength(1000, MinimumLength = 0)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the position
    /// </summary>
    public int Position { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer has been deleted
    /// </summary>
    public bool Deleted { get; set; } = false;

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime? CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    public DateTime? UpdatedOnUtc { get; set; }

    // Navigation properties
    [ForeignKey("BoardId")]
    public Board Board { get; set; }

    public ICollection<Issue> Issues { get; set; }
}
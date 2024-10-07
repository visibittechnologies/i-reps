using PM.Core.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Projects;

/// <summary>
/// Represents a user role
/// </summary>
public partial class ProjectCategory : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the category name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the project category has been deleted
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
}

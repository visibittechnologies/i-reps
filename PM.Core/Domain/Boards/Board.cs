using PM.Core.Domain.Boards;
using PM.Core.Domain.Common;
using PM.Core.Domain.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PM.Core.Domain.Projects;

/// <summary>
/// Password format
/// </summary>
public partial class Board : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the project identifier
    /// </summary>
    [Required]
    public long ProjectId { get; set; }

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
    /// Gets or sets a value indicating whether the board has been deleted
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
    [ForeignKey("ProjectId")]
    public Project Project { get; set; }
    public ICollection<WorkspaceMember> BoardMembers { get; set; }
    public ICollection<Status> Statuses { get; set; }
}
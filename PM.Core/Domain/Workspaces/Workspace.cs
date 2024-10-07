using PM.Core.Domain.Common;
using PM.Core.Domain.Projects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Users;

/// <summary>
/// Represents a user role
/// </summary>
public partial class Workspace : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the workspace name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the workspace Short name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(50, MinimumLength = 0)]
    public string ShortName { get; set; }

    /// <summary>
    /// Gets or sets the website
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(250, MinimumLength = 0)]
    public string Website { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    [StringLength(1000, MinimumLength = 0)]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the workspace is active
    /// </summary>
    public bool Active { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether the workspace has been deleted
    /// </summary>
    public bool Deleted { get; set; } = false;

    // Navigation properties
    public ICollection<Project> Projects { get; set; }
}

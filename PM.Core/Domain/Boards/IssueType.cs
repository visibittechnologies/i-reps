using PM.Core.Domain.Common;
using PM.Core.Domain.Projects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PM.Core.Domain.Boards;

/// <summary>
/// Password format
/// </summary>
public partial class IssueType : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the project identifier
    /// </summary>
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
    /// Gets or sets the sub task
    /// </summary>
    public bool SubTask { get; set; }

    /// <summary>
    /// Gets or sets the icon Url
    /// </summary>
    public string IconUrl { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the issue type has been deleted
    /// </summary>
    public bool Deleted { get; set; } = false;

    // Navigation properties
    [ForeignKey("ProjectId")]
    public Project Project { get; set; }
}
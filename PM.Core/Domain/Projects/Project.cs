using PM.Core.Domain.Boards;
using PM.Core.Domain.Common;
using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Projects;

/// <summary>
/// Represents a user role
/// </summary>
public partial class Project : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the workspace identifier
    /// </summary>
    [Required]
    public long WorkspaceId { get; set; }

    /// <summary>
    /// Gets or sets the project name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the category identifier
    /// </summary>
    public long? CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the project type identifier
    /// </summary>
    public long? ProjectTypeId { get; set; }

    /// <summary>
    /// Gets or sets the project lead identifier
    /// </summary>
    public long? ProjectLeadId { get; set; }

    /// <summary>
    /// Gets or sets the Assignee Type UNASSIGNED Or PROJECTLEAD
    /// </summary>
    public string AssigneeType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the project has been deleted
    /// </summary>
    public bool Deleted { get; set; } = false;

    // Navigation properties
    [ForeignKey("WorkspaceId")]
    public Workspace Workspace { get; set; }

    public ICollection<Board> Boards { get; set; }

    [ForeignKey("ProjectLeadId")]
    public User ProjectLead { get; set; }

    [ForeignKey("ProjectTypeId")]
    public ProjectType ProjectType { get; set; }

    [ForeignKey("CategoryId")]
    public ProjectCategory Category { get; set; }
}

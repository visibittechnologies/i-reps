using PM.Core.Domain.Projects;
using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class WorkspaceMember : BaseEntity
{
    /// <summary>
    /// Gets or sets the workspace identifier
    /// </summary>
    [Required]
    public long WorkspaceId { get; set; }

    /// <summary>
    /// Gets or sets the user identifier
    /// </summary>
    [Required]
    public long UserId { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime? CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    public DateTime? UpdatedOnUtc { get; set; }

    // Navigation properties
    [ForeignKey("WorkspaceId")]
    public Workspace Workspace { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}

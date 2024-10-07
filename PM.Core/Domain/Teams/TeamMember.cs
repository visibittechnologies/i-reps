using PM.Core.Domain.Common;
using PM.Core.Domain.Projects;
using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class TeamMember : BaseEntity
{
    /// <summary>
    /// Gets or sets the team identifier
    /// </summary>
    [Required]
    public long TeamId { get; set; }

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
    [ForeignKey("TeamId")]
    public Team Team { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}
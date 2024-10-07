using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class IssueMember : BaseEntity
{
    /// <summary>
    /// Gets or sets the issue identifier
    /// </summary>
    public long IssueId { get; set; }

    /// <summary>
    /// Gets or sets the user identifier
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    ///  Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime AssignedOn { get; set; } = DateTime.Now;

    // Navigation properties
    [ForeignKey("IssueId")]
    public Issue Issue { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}

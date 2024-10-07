using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class Comment : BaseEntity
{
    /// <summary>
    /// Gets or sets the issue identifier
    /// </summary>
    [Required]
    public long IssueId { get; set; }

    /// <summary>
    /// Gets or sets the user identifier
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// Gets or sets the content
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime? CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    public DateTime? UpdatedOnUtc { get; set; }

    // Navigation properties
    [ForeignKey("IssueId")]
    public Issue Issue { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}

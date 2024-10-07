using PM.Core.Domain.Projects;
using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class BoardMember : BaseEntity
{
    /// <summary>
    /// Gets or sets the issue identifier
    /// </summary>
    [Required]
    public long BoardId { get; set; }

    /// <summary>
    /// Gets or sets the user identifier
    /// </summary>
    [Required]
    public long UserId { get; set; }

    /// <summary>
    /// Gets or sets the user role as Owner/Member/Viewer
    /// </summary>
    public MemberRole Role { get; set; }

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

    [ForeignKey("UserId")]
    public User User { get; set; }
}

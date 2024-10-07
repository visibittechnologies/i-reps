using PM.Core.Domain.Common;
using PM.Core.Domain.Projects;
using PM.Core.Domain.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class Issue : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the board identifier
    /// </summary>
    [Required]
    public long BoardId { get; set; }

    /// <summary>
    /// Gets or sets the issue type identifier
    /// </summary>
    public long? IssueTypeId { get; set; }

    /// <summary>
    /// Gets or sets the status identifier
    /// </summary>
    public long? StatusId { get; set; }

    /// <summary>
    /// Gets or sets the issue label identifier
    /// </summary>
    public long? IssueLabelId { get; set; }

    /// <summary>
    /// Gets or sets the issue type name
    /// </summary>
    [Required, StringLength(500, MinimumLength = 0)]
    public string Summary { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the assignee identifier {user id}
    /// </summary>
    //public long? AssigneeId { get; set; }

    /// <summary>
    /// Gets or sets the reporter identifier {user id}
    /// </summary>
    public long ReporterId { get; set; }

    /// <summary>
    /// Gets or sets the parent task identifier
    /// </summary>
    public long? ParentId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the issue has been deleted
    /// </summary>
    public bool Deleted { get; set; } = false;

    /// <summary>
    /// Gets or sets a value Allows to flag issues with impediments.
    /// </summary>
    public bool Flagged { get; set; } = false;    

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

    [ForeignKey("StatusId")]
    public Status Status { get; set; }

    [ForeignKey("IssueTypeId")]
    public IssueType IssueType { get; set; }

    [ForeignKey("IssueLabelId")]
    public Label IssueLabel { get; set; }

    [ForeignKey("ReporterId")]
    public User Reporter { get; set; }

    [ForeignKey("ParentId")]
    public Issue ParentIssue { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public ICollection<IssueMember> IssueMembers { get; set; }
    public ICollection<IssueLabel> IssueLabels { get; set; }
    public ICollection<Attachment> Attachments { get; set; }
}

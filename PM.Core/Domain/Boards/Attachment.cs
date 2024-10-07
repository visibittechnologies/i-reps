using PM.Core.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace PM.Core.Domain.Boards;
public partial class Attachment : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the issue identifier
    /// </summary>
    public long IssueId { get; set; }

    /// <summary>
    /// Gets or sets the file name
    /// </summary>
    [Required, StringLength(250, MinimumLength = 0)]
    public string FileName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [Required, StringLength(1000, MinimumLength = 0)]
    public string FilePath { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the issue has been deleted
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
    public Issue Issue { get; set; }
}

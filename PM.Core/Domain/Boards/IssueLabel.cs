using PM.Core.Domain.Common;
using PM.Core.Domain.Projects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class IssueLabel : BaseEntity
{
    /// <summary>
    /// Gets or sets the project identifier
    /// </summary>
    public long ProjectId { get; set; }

    /// <summary>
    /// Gets or sets the label identifier
    /// </summary>
    public long LabelId { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime? CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    public DateTime? UpdatedOnUtc { get; set; }

    // Navigation properties
    [ForeignKey("ProjectId")]
    public Project Project { get; set; }

    [ForeignKey("LabelId")]
    public Label Label { get; set; }
}
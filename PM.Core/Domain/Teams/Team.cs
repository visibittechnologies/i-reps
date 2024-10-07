﻿using PM.Core.Domain.Common;
using PM.Core.Domain.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Boards;
public partial class Team : BaseEntity, ISoftDeletedEntity
{
    /// <summary>
    /// Gets or sets the workspace identifier
    /// </summary>
    [Required]
    public long WorkspaceId { get; set; }

    /// <summary>
    /// Gets or sets the label title
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the label color
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(100, MinimumLength = 0)]
    public string Color { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the label has been deleted
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
    [ForeignKey("WorkspaceId")]
    public Workspace Workspace { get; set; }
}
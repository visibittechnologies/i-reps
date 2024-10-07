using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PM.Core.Domain.Users;

/// <summary>
/// Represents a user role
/// </summary>
public partial class UserRole : BaseEntity
{
    /// <summary>
    /// Gets or sets the customer role name
    /// </summary>
    [Required, Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer role is active
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer role is system
    /// </summary>
    public bool IsSystemRole { get; set; }
}

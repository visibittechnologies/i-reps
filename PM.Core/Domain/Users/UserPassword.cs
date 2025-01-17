﻿using System.ComponentModel.DataAnnotations;

namespace PM.Core.Domain.Customers;

/// <summary>
/// Represents a customer password
/// </summary>
public partial class UserPassword : BaseEntity
{
    public UserPassword()
    {
        PasswordFormat = PasswordFormat.Clear;
    }

    /// <summary>
    /// Gets or sets the user identifier
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// Gets or sets the password
    /// </summary>
    [StringLength(1000, MinimumLength = 0)]
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the password format identifier
    /// </summary>
    public int PasswordFormatId { get; set; }

    /// <summary>
    /// Gets or sets the password salt
    /// </summary>
    [StringLength(1000, MinimumLength = 0)]
    public string PasswordSalt { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    public DateTime CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    public DateTime UpdatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the password format
    /// </summary>
    public PasswordFormat PasswordFormat
    {
        get => (PasswordFormat)PasswordFormatId;
        set => PasswordFormatId = (int)value;
    }
}
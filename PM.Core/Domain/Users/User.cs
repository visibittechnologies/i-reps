using PM.Core.Domain.Boards;
using PM.Core.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM.Core.Domain.Users;

/// <summary>
/// Represents a user
/// </summary>
public partial class User : BaseEntity, ISoftDeletedEntity
{
    public User()
    {
        UserGuid = Guid.NewGuid();
    }

    /// <summary>
    /// Gets or sets the user GUID
    /// </summary>
    public Guid UserGuid { get; set; }

    /// <summary>
    /// Gets or sets the username
    /// </summary>
    [Required, StringLength(250, MinimumLength = 0)]
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the email
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(150, MinimumLength = 0)]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the first name
    /// </summary>
    [StringLength(250, MinimumLength = 0)]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name
    /// </summary>
    [StringLength(250, MinimumLength = 0)]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the gender
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(50, MinimumLength = 0)]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or sets the date of birth
    /// </summary>
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the job title
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(250, MinimumLength = 0)]
    public string JobTitle { get; set; }

    /// <summary>
    /// Gets or sets the organization
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(250, MinimumLength = 0)]
    public string Organization { get; set; }

    /// <summary>
    /// Gets or sets the department
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(250, MinimumLength = 0)]
    public string Department { get; set; }

    /// <summary>
    /// Gets or sets the location
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(250, MinimumLength = 0)]
    public string Location { get; set; }

    /// <summary>
    /// Gets or sets the phone number
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(50, MinimumLength = 0)]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets a email verified
    /// </summary>
    public bool EmailVerified { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer is active
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer has been deleted
    /// </summary>
    public bool Deleted { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the customer account is system
    /// </summary>
    public bool IsSystemAccount { get; set; }

    /// <summary>
    /// Gets or sets the last IP address
    /// </summary>
    [Column(TypeName = "varchar"), StringLength(50, MinimumLength = 0)]
    public string LastIpAddress { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity creation
    /// </summary>
    [Column(TypeName = "datetime2")]
    public DateTime CreatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of entity updated
    /// </summary>
    [Column(TypeName = "datetime2")]
    public DateTime UpdatedOnUtc { get; set; }

    /// <summary>
    /// Gets or sets the date and time of last login
    /// </summary>
    [Column(TypeName = "datetime2")]
    public DateTime? LastLoginDateUtc { get; set; }


    // Navigation properties
    //public ICollection<BoardMember> BoardMembers { get; set; }
    //public ICollection<Comment> Comments { get; set; }
    //public ICollection<IssueMember> IssueMembers { get; set; }
}
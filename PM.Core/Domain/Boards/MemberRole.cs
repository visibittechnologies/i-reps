namespace PM.Core.Domain.Users;

/// <summary>
/// Represents a member role
/// </summary>
public enum MemberRole
{
    /// <summary>
    /// Admin or Owner
    /// </summary>
    Owner = 1,

    /// <summary>
    /// Member
    /// </summary>
    Member = 2,

    /// <summary>
    /// Viewer
    /// </summary>
    Viewer = 3
}

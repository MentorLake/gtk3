namespace MentorLake.Gio;

/// <summary>
/// <para>
/// #GAskPasswordFlags are used to request specific information from the
/// user, or to notify the user of their choices in an authentication
/// situation.
/// </para>
/// </summary>

[Flags]
public enum GAskPasswordFlags : uint
{
/// <summary>
/// <para>
/// operation requires a password.
/// </para>
/// </summary>

	G_ASK_PASSWORD_NEED_PASSWORD = 1,
/// <summary>
/// <para>
/// operation requires a username.
/// </para>
/// </summary>

	G_ASK_PASSWORD_NEED_USERNAME = 2,
/// <summary>
/// <para>
/// operation requires a domain.
/// </para>
/// </summary>

	G_ASK_PASSWORD_NEED_DOMAIN = 4,
/// <summary>
/// <para>
/// operation supports saving settings.
/// </para>
/// </summary>

	G_ASK_PASSWORD_SAVING_SUPPORTED = 8,
/// <summary>
/// <para>
/// operation supports anonymous users.
/// </para>
/// </summary>

	G_ASK_PASSWORD_ANONYMOUS_SUPPORTED = 16,
/// <summary>
/// <para>
/// operation takes TCRYPT parameters (Since: 2.58)
/// </para>
/// </summary>

	G_ASK_PASSWORD_TCRYPT = 32
}

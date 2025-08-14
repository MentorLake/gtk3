namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The client authentication mode for a #GTlsServerConnection.
/// </para>
/// </summary>

[Flags]
public enum GTlsAuthenticationMode
{
/// <summary>
/// <para>
/// client authentication not required
/// </para>
/// </summary>

	G_TLS_AUTHENTICATION_NONE = 0,
/// <summary>
/// <para>
/// client authentication is requested
/// </para>
/// </summary>

	G_TLS_AUTHENTICATION_REQUESTED = 1,
/// <summary>
/// <para>
/// client authentication is required
/// </para>
/// </summary>

	G_TLS_AUTHENTICATION_REQUIRED = 2
}

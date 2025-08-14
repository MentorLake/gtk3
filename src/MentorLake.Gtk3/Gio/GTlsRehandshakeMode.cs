namespace MentorLake.Gio;

/// <summary>
/// <para>
/// When to allow rehandshaking. See
/// g_tls_connection_set_rehandshake_mode().
/// </para>
/// </summary>

[Flags]
public enum GTlsRehandshakeMode
{
/// <summary>
/// <para>
/// Never allow rehandshaking
/// </para>
/// </summary>

	G_TLS_REHANDSHAKE_NEVER = 0,
/// <summary>
/// <para>
/// Allow safe rehandshaking only
/// </para>
/// </summary>

	G_TLS_REHANDSHAKE_SAFELY = 1,
/// <summary>
/// <para>
/// Allow unsafe rehandshaking
/// </para>
/// </summary>

	G_TLS_REHANDSHAKE_UNSAFELY = 2
}

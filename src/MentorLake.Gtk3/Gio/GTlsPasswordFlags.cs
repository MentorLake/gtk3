namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Various flags for the password.
/// </para>
/// </summary>

[Flags]
public enum GTlsPasswordFlags : uint
{
/// <summary>
/// <para>
/// No flags
/// </para>
/// </summary>

	G_TLS_PASSWORD_NONE = 0,
/// <summary>
/// <para>
/// The password was wrong, and the user should retry.
/// </para>
/// </summary>

	G_TLS_PASSWORD_RETRY = 2,
/// <summary>
/// <para>
/// Hint to the user that the password has been
///    wrong many times, and the user may not have many chances left.
/// </para>
/// </summary>

	G_TLS_PASSWORD_MANY_TRIES = 4,
/// <summary>
/// <para>
/// Hint to the user that this is the last try to get
///    this password right.
/// </para>
/// </summary>

	G_TLS_PASSWORD_FINAL_TRY = 8,
/// <summary>
/// <para>
/// For PKCS #11, the user PIN is required.
///    Since: 2.70.
/// </para>
/// </summary>

	G_TLS_PASSWORD_PKCS11_USER = 16,
/// <summary>
/// <para>
/// For PKCS #11, the security officer
///    PIN is required. Since: 2.70.
/// </para>
/// </summary>

	G_TLS_PASSWORD_PKCS11_SECURITY_OFFICER = 32,
/// <summary>
/// <para>
/// For PKCS #11, the context-specific
///    PIN is required. Since: 2.70.
/// </para>
/// </summary>

	G_TLS_PASSWORD_PKCS11_CONTEXT_SPECIFIC = 64
}

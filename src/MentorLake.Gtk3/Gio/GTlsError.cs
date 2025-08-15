namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An error code used with %G_TLS_ERROR in a #GError returned from a
/// TLS-related routine.
/// </para>
/// </summary>

[Flags]
public enum GTlsError
{
/// <summary>
/// <para>
/// No TLS provider is available
/// </para>
/// </summary>

	G_TLS_ERROR_UNAVAILABLE = 0,
/// <summary>
/// <para>
/// Miscellaneous TLS error
/// </para>
/// </summary>

	G_TLS_ERROR_MISC = 1,
/// <summary>
/// <para>
/// The certificate presented could not
///   be parsed or failed validation.
/// </para>
/// </summary>

	G_TLS_ERROR_BAD_CERTIFICATE = 2,
/// <summary>
/// <para>
/// The TLS handshake failed because the
///   peer does not seem to be a TLS server.
/// </para>
/// </summary>

	G_TLS_ERROR_NOT_TLS = 3,
/// <summary>
/// <para>
/// The TLS handshake failed because the
///   peer&apos;s certificate was not acceptable.
/// </para>
/// </summary>

	G_TLS_ERROR_HANDSHAKE = 4,
/// <summary>
/// <para>
/// The TLS handshake failed because
///   the server requested a client-side certificate, but none was
///   provided. See g_tls_connection_set_certificate().
/// </para>
/// </summary>

	G_TLS_ERROR_CERTIFICATE_REQUIRED = 5,
/// <summary>
/// <para>
/// The TLS connection was closed without proper
///   notice, which may indicate an attack. See
///   g_tls_connection_set_require_close_notify().
/// </para>
/// </summary>

	G_TLS_ERROR_EOF = 6,
/// <summary>
/// <para>
/// The TLS handshake failed
///   because the client sent the fallback SCSV, indicating a protocol
///   downgrade attack. Since: 2.60
/// </para>
/// </summary>

	G_TLS_ERROR_INAPPROPRIATE_FALLBACK = 7,
/// <summary>
/// <para>
/// The certificate failed
///   to load because a password was incorrect. Since: 2.72
/// </para>
/// </summary>

	G_TLS_ERROR_BAD_CERTIFICATE_PASSWORD = 8
}

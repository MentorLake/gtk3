namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags for g_tls_database_lookup_certificate_for_handle(),
/// g_tls_database_lookup_certificate_issuer(),
/// and g_tls_database_lookup_certificates_issued_by().
/// </para>
/// </summary>

[Flags]
public enum GTlsDatabaseLookupFlags
{
/// <summary>
/// <para>
/// No lookup flags
/// </para>
/// </summary>

	G_TLS_DATABASE_LOOKUP_NONE = 0,
/// <summary>
/// <para>
/// Restrict lookup to certificates that have
///     a private key.
/// </para>
/// </summary>

	G_TLS_DATABASE_LOOKUP_KEYPAIR = 1
}

namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The TLS or DTLS protocol version used by a #GTlsConnection or
/// #GDtlsConnection. The integer values of these versions are sequential
/// to ensure newer known protocol versions compare greater than older
/// known versions. Any known DTLS protocol version will compare greater
/// than any SSL or TLS protocol version. The protocol version may be
/// %G_TLS_PROTOCOL_VERSION_UNKNOWN if the TLS backend supports a newer
/// protocol version that GLib does not yet know about. This means that
/// it's possible for an unknown DTLS protocol version to compare less
/// than the TLS protocol versions.
/// </para>
/// </summary>

[Flags]
public enum GTlsProtocolVersion
{
/// <summary>
/// <para>
/// No protocol version or unknown protocol version
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_UNKNOWN = 0,
/// <summary>
/// <para>
/// SSL 3.0, which is insecure and should not be used
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_SSL_3_0 = 1,
/// <summary>
/// <para>
/// TLS 1.0, which is insecure and should not be used
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_TLS_1_0 = 2,
/// <summary>
/// <para>
/// TLS 1.1, which is insecure and should not be used
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_TLS_1_1 = 3,
/// <summary>
/// <para>
/// TLS 1.2, defined by [RFC 5246](https://datatracker.ietf.org/doc/html/rfc5246)
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_TLS_1_2 = 4,
/// <summary>
/// <para>
/// TLS 1.3, defined by [RFC 8446](https://datatracker.ietf.org/doc/html/rfc8446)
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_TLS_1_3 = 5,
/// <summary>
/// <para>
/// DTLS 1.0, which is insecure and should not be used
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_DTLS_1_0 = 201,
/// <summary>
/// <para>
/// DTLS 1.2, defined by [RFC 6347](https://datatracker.ietf.org/doc/html/rfc6347)
/// </para>
/// </summary>

	G_TLS_PROTOCOL_VERSION_DTLS_1_2 = 202
}

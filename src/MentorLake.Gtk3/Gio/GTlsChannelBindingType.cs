namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of TLS channel binding data to retrieve from #GTlsConnection
/// or #GDtlsConnection, as documented by RFC 5929 or RFC 9266. The
/// <see href="https://tools.ietf.org/html/rfc5929#section-5">tls-unique-for-telnet</see>
/// binding type is not currently implemented.
/// </para>
/// </summary>

[Flags]
public enum GTlsChannelBindingType
{
/// <summary>
/// <para>
/// <see href="https://tools.ietf.org/html/rfc5929#section-3">tls-unique</see> binding
///    type
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_UNIQUE = 0,
/// <summary>
/// <para>
/// <see href="https://tools.ietf.org/html/rfc5929#section-4">tls-server-end-point</see>
///    binding type
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_SERVER_END_POINT = 1,
/// <summary>
/// <para>
/// <see href="https://www.rfc-editor.org/rfc/rfc9266.html">tls-exporter</see> binding
///    type. Since: 2.74
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_EXPORTER = 2
}

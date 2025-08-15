namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The type of TLS channel binding data to retrieve from #GTlsConnection
/// or #GDtlsConnection, as documented by RFC 5929 or RFC 9266. The
/// &amp;lt;see href=&quot;https://tools.ietf.org/html/rfc5929#section-5&quot;&amp;gt;tls-unique-for-telnet&amp;lt;/see&amp;gt;
/// binding type is not currently implemented.
/// </para>
/// </summary>

[Flags]
public enum GTlsChannelBindingType
{
/// <summary>
/// <para>
/// &amp;lt;see href=&quot;https://tools.ietf.org/html/rfc5929#section-3&quot;&amp;gt;tls-unique&amp;lt;/see&amp;gt; binding
///    type
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_UNIQUE = 0,
/// <summary>
/// <para>
/// &amp;lt;see href=&quot;https://tools.ietf.org/html/rfc5929#section-4&quot;&amp;gt;tls-server-end-point&amp;lt;/see&amp;gt;
///    binding type
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_SERVER_END_POINT = 1,
/// <summary>
/// <para>
/// &amp;lt;see href=&quot;https://www.rfc-editor.org/rfc/rfc9266.html&quot;&amp;gt;tls-exporter&amp;lt;/see&amp;gt; binding
///    type. Since: 2.74
/// </para>
/// </summary>

	G_TLS_CHANNEL_BINDING_TLS_EXPORTER = 2
}

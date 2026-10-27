namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Options to pass to [method@Server.listen], etc.
/// </para>
/// <para>
/// %SOUP_SERVER_LISTEN_IPV4_ONLY and %SOUP_SERVER_LISTEN_IPV6_ONLY
/// only make sense with [method@Server.listen_all] and
/// [method@Server.listen_local], not plain [method@Server.listen] (which
/// simply listens on whatever kind of socket you give it). And you
/// cannot specify both of them in a single call.
/// </para>
/// </summary>

[Flags]
public enum SoupServerListenOptions : uint
{
/// <summary>
/// <para>
/// Listen for https connections rather
///   than plain http.
/// </para>
/// </summary>

	SOUP_SERVER_LISTEN_HTTPS = 1,
/// <summary>
/// <para>
/// Only listen on IPv4 interfaces.
/// </para>
/// </summary>

	SOUP_SERVER_LISTEN_IPV4_ONLY = 2,
/// <summary>
/// <para>
/// Only listen on IPv6 interfaces.
/// </para>
/// </summary>

	SOUP_SERVER_LISTEN_IPV6_ONLY = 4
}

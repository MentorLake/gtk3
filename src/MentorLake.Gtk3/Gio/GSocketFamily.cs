namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The protocol family of a #GSocketAddress. (These values are
/// identical to the system defines %AF_INET, %AF_INET6 and %AF_UNIX,
/// if available.)
/// </para>
/// </summary>

[Flags]
public enum GSocketFamily
{
/// <summary>
/// <para>
/// no address family
/// </para>
/// </summary>

	G_SOCKET_FAMILY_INVALID = 0,
/// <summary>
/// <para>
/// the UNIX domain family
/// </para>
/// </summary>

	G_SOCKET_FAMILY_UNIX = 1,
/// <summary>
/// <para>
/// the IPv4 family
/// </para>
/// </summary>

	G_SOCKET_FAMILY_IPV4 = 2,
/// <summary>
/// <para>
/// the IPv6 family
/// </para>
/// </summary>

	G_SOCKET_FAMILY_IPV6 = 10
}

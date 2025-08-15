namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The host&apos;s network connectivity state, as reported by #GNetworkMonitor.
/// </para>
/// </summary>

[Flags]
public enum GNetworkConnectivity
{
/// <summary>
/// <para>
/// The host is not configured with a
///   route to the Internet; it may or may not be connected to a local
///   network.
/// </para>
/// </summary>

	G_NETWORK_CONNECTIVITY_LOCAL = 1,
/// <summary>
/// <para>
/// The host is connected to a network, but
///   does not appear to be able to reach the full Internet, perhaps
///   due to upstream network problems.
/// </para>
/// </summary>

	G_NETWORK_CONNECTIVITY_LIMITED = 2,
/// <summary>
/// <para>
/// The host is behind a captive portal and
///   cannot reach the full Internet.
/// </para>
/// </summary>

	G_NETWORK_CONNECTIVITY_PORTAL = 3,
/// <summary>
/// <para>
/// The host is connected to a network, and
///   appears to be able to reach the full Internet.
/// </para>
/// </summary>

	G_NETWORK_CONNECTIVITY_FULL = 4
}

namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to set the network proxy mode.
/// </para>
/// </summary>

[Flags]
public enum WebKitNetworkProxyMode
{
/// <summary>
/// <para>
/// Use the default proxy of the system.
/// </para>
/// </summary>

	WEBKIT_NETWORK_PROXY_MODE_DEFAULT = 0,
/// <summary>
/// <para>
/// Do not use any proxy.
/// </para>
/// </summary>

	WEBKIT_NETWORK_PROXY_MODE_NO_PROXY = 1,
/// <summary>
/// <para>
/// Use custom proxy settings.
/// </para>
/// </summary>

	WEBKIT_NETWORK_PROXY_MODE_CUSTOM = 2
}

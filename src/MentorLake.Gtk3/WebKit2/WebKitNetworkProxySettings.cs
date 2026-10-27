namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Configures network proxies.
/// </para>
/// <para>
/// WebKitNetworkProxySettings can be used to provide a custom proxy configuration
/// to a #WebKitWebsiteDataManager. You need to call webkit_website_data_manager_set_network_proxy_settings()
/// with %WEBKIT_NETWORK_PROXY_MODE_CUSTOM and a WebKitNetworkProxySettings.
/// </para>
/// </summary>

public class WebKitNetworkProxySettingsHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitNetworkProxySettings with the given @default_proxy_uri and @ignore_hosts.
/// </para>
/// <para>
/// The default proxy URI will be used for any URI that doesn&apos;t match @ignore_hosts, and doesn&apos;t match any
/// of the schemes added with webkit_network_proxy_settings_add_proxy_for_scheme().
/// If @default_proxy_uri starts with &quot;socks://&quot;, it will be treated as referring to all three of the
/// socks5, socks4a, and socks4 proxy types.
/// </para>
/// <para>
/// @ignore_hosts is a list of hostnames and IP addresses that the resolver should allow direct connections to.
/// Entries can be in one of 4 formats:
/// &amp;lt;itemizedlist&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// A hostname, such as &quot;example.com&quot;, &quot;.example.com&quot;, or &quot;*.example.com&quot;, any of which match &quot;example.com&quot; or
/// any subdomain of it.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// An IPv4 or IPv6 address, such as &quot;192.168.1.1&quot;, which matches only that address.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// A hostname or IP address followed by a port, such as &quot;example.com:80&quot;, which matches whatever the hostname or IP
/// address would match, but only for URLs with the (explicitly) indicated port. In the case of an IPv6 address, the address
/// part must appear in brackets: &quot;[::1]:443&quot;
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;listitem&amp;gt;&amp;lt;para&amp;gt;
/// An IP address range, given by a base address and prefix length, such as &quot;fe80::/10&quot;, which matches any address in that range.
/// &amp;lt;/para&amp;gt;&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// </para>
/// <para>
/// Note that when dealing with Unicode hostnames, the matching is done against the ASCII form of the name.
/// Also note that hostname exclusions apply only to connections made to hosts identified by name, and IP address exclusions apply only
/// to connections made to hosts identified by address. That is, if example.com has an address of 192.168.1.1, and @ignore_hosts
/// contains only &quot;192.168.1.1&quot;, then a connection to &quot;example.com&quot; will use the proxy, and a connection to 192.168.1.1&quot; will not.
/// </para>
/// </summary>

/// <param name="default_proxy_uri">
/// the default proxy URI to use, or %NULL.
/// </param>
/// <param name="ignore_hosts">
/// an optional list of hosts/IP addresses to not use a proxy for.
/// </param>
/// <return>
/// A new #WebKitNetworkProxySettings.
/// </return>

	public static MentorLake.WebKit2.WebKitNetworkProxySettingsHandle New(string default_proxy_uri, string[] ignore_hosts)
	{
		return WebKitNetworkProxySettingsExterns.webkit_network_proxy_settings_new(default_proxy_uri, ignore_hosts);
	}

}


public static class WebKitNetworkProxySettingsExtensions
{
/// <summary>
/// <para>
/// Adds a URI-scheme-specific proxy.
/// </para>
/// <para>
/// URIs whose scheme matches @uri_scheme will be proxied via @proxy_uri.
/// As with the default proxy URI, if @proxy_uri starts with &quot;socks://&quot;, it will be treated as referring to
/// all three of the socks5, socks4a, and socks4 proxy types.
/// </para>
/// </summary>

/// <param name="proxy_settings">
/// a #WebKitNetworkProxySettings
/// </param>
/// <param name="scheme">
/// the URI scheme to add a proxy for
/// </param>
/// <param name="proxy_uri">
/// the proxy URI to use for @uri_scheme
/// </param>

	public static void AddProxyForScheme(this MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings, string scheme, string proxy_uri)
	{
		if (proxy_settings.IsInvalid) throw new Exception("Invalid handle (WebKitNetworkProxySettings)");
		WebKitNetworkProxySettingsExterns.webkit_network_proxy_settings_add_proxy_for_scheme(proxy_settings, scheme, proxy_uri);
	}

/// <summary>
/// <para>
/// Make a copy of the #WebKitNetworkProxySettings.
/// </para>
/// </summary>

/// <param name="proxy_settings">
/// a #WebKitNetworkProxySettings
/// </param>
/// <return>
/// A copy of passed in #WebKitNetworkProxySettings
/// </return>

	public static MentorLake.WebKit2.WebKitNetworkProxySettingsHandle Copy(this MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings)
	{
		if (proxy_settings.IsInvalid) throw new Exception("Invalid handle (WebKitNetworkProxySettings)");
		return WebKitNetworkProxySettingsExterns.webkit_network_proxy_settings_copy(proxy_settings);
	}

/// <summary>
/// <para>
/// Free the #WebKitNetworkProxySettings.
/// </para>
/// </summary>

/// <param name="proxy_settings">
/// A #WebKitNetworkProxySettings
/// </param>

	public static void Free(this MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings)
	{
		if (proxy_settings.IsInvalid) throw new Exception("Invalid handle (WebKitNetworkProxySettings)");
		WebKitNetworkProxySettingsExterns.webkit_network_proxy_settings_free(proxy_settings);
	}


	public static WebKitNetworkProxySettings Dereference(this WebKitNetworkProxySettingsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNetworkProxySettings>(x.DangerousGetHandle());
}
internal class WebKitNetworkProxySettingsExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitNetworkProxySettingsHandle webkit_network_proxy_settings_new(string default_proxy_uri, string[] ignore_hosts);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_network_proxy_settings_add_proxy_for_scheme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))] MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings, string scheme, string proxy_uri);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))]
	internal static extern MentorLake.WebKit2.WebKitNetworkProxySettingsHandle webkit_network_proxy_settings_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))] MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_network_proxy_settings_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitNetworkProxySettingsHandle>))] MentorLake.WebKit2.WebKitNetworkProxySettingsHandle proxy_settings);

}

/// <summary>
/// <para>
/// Configures network proxies.
/// </para>
/// <para>
/// WebKitNetworkProxySettings can be used to provide a custom proxy configuration
/// to a #WebKitWebsiteDataManager. You need to call webkit_website_data_manager_set_network_proxy_settings()
/// with %WEBKIT_NETWORK_PROXY_MODE_CUSTOM and a WebKitNetworkProxySettings.
/// </para>
/// </summary>

public struct WebKitNetworkProxySettings
{
}

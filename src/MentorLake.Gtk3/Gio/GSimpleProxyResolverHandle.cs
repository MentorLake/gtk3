namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSimpleProxyResolver` is a simple [iface@Gio.ProxyResolver] implementation
/// that handles a single default proxy, multiple URI-scheme-specific
/// proxies, and a list of hosts that proxies should not be used for.
/// </para>
/// <para>
/// `GSimpleProxyResolver` is never the default proxy resolver, but it
/// can be used as the base class for another proxy resolver
/// implementation, or it can be created and used manually, such as
/// with [method@Gio.SocketClient.set_proxy_resolver].
/// </para>
/// </summary>

public class GSimpleProxyResolverHandle : GObjectHandle, GProxyResolverHandle
{
/// <summary>
/// <para>
/// Creates a new #GSimpleProxyResolver. See
/// #GSimpleProxyResolver:default-proxy and
/// #GSimpleProxyResolver:ignore-hosts for more details on how the
/// arguments are interpreted.
/// </para>
/// </summary>

/// <param name="default_proxy">
/// the default proxy to use, eg
///     &quot;socks://192.168.1.1&quot;
/// </param>
/// <param name="ignore_hosts">
/// an optional list of hosts/IP addresses
///     to not use a proxy for.
/// </param>
/// <return>
/// a new #GSimpleProxyResolver
/// </return>

	public static MentorLake.Gio.GProxyResolverHandle New(string default_proxy, string[] ignore_hosts)
	{
		return GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_new(default_proxy, ignore_hosts);
	}

}

public static class GSimpleProxyResolverHandleExtensions
{
/// <summary>
/// <para>
/// Sets the default proxy on @resolver, to be used for any URIs that
/// don&apos;t match #GSimpleProxyResolver:ignore-hosts or a proxy set
/// via g_simple_proxy_resolver_set_uri_proxy().
/// </para>
/// <para>
/// If @default_proxy starts with &quot;socks://&quot;,
/// #GSimpleProxyResolver will treat it as referring to all three of
/// the socks5, socks4a, and socks4 proxy types.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GSimpleProxyResolver
/// </param>
/// <param name="default_proxy">
/// the default proxy to use
/// </param>

	public static T SetDefaultProxy<T>(this T resolver, string default_proxy) where T : GSimpleProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GSimpleProxyResolverHandle)");
		GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_set_default_proxy(resolver, default_proxy);
		return resolver;
	}

/// <summary>
/// <para>
/// Sets the list of ignored hosts.
/// </para>
/// <para>
/// See #GSimpleProxyResolver:ignore-hosts for more details on how the
/// @ignore_hosts argument is interpreted.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GSimpleProxyResolver
/// </param>
/// <param name="ignore_hosts">
/// %NULL-terminated list of hosts/IP addresses
///     to not use a proxy for
/// </param>

	public static T SetIgnoreHosts<T>(this T resolver, string[] ignore_hosts) where T : GSimpleProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GSimpleProxyResolverHandle)");
		GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_set_ignore_hosts(resolver, ignore_hosts);
		return resolver;
	}

/// <summary>
/// <para>
/// Adds a URI-scheme-specific proxy to @resolver; URIs whose scheme
/// matches @uri_scheme (and which don&apos;t match
/// #GSimpleProxyResolver:ignore-hosts) will be proxied via @proxy.
/// </para>
/// <para>
/// As with #GSimpleProxyResolver:default-proxy, if @proxy starts with
/// &quot;socks://&quot;, #GSimpleProxyResolver will treat it
/// as referring to all three of the socks5, socks4a, and socks4 proxy
/// types.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GSimpleProxyResolver
/// </param>
/// <param name="uri_scheme">
/// the URI scheme to add a proxy for
/// </param>
/// <param name="proxy">
/// the proxy to use for @uri_scheme
/// </param>

	public static T SetUriProxy<T>(this T resolver, string uri_scheme, string proxy) where T : GSimpleProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GSimpleProxyResolverHandle)");
		GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_set_uri_proxy(resolver, uri_scheme, proxy);
		return resolver;
	}

}

internal class GSimpleProxyResolverHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_proxy_resolver_set_default_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleProxyResolverHandle>))] MentorLake.Gio.GSimpleProxyResolverHandle resolver, string default_proxy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_proxy_resolver_set_ignore_hosts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleProxyResolverHandle>))] MentorLake.Gio.GSimpleProxyResolverHandle resolver, string[] ignore_hosts);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_proxy_resolver_set_uri_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleProxyResolverHandle>))] MentorLake.Gio.GSimpleProxyResolverHandle resolver, string uri_scheme, string proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyResolverHandle g_simple_proxy_resolver_new(string default_proxy, string[] ignore_hosts);

}

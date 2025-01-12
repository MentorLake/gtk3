namespace MentorLake.Gtk3.Gio;

public class GSimpleProxyResolverHandle : GObjectHandle, GProxyResolverHandle
{
	public static GProxyResolverHandle New(string default_proxy, string[] ignore_hosts)
	{
		return GSimpleProxyResolverExterns.g_simple_proxy_resolver_new(default_proxy, ignore_hosts);
	}

}

public static class GSimpleProxyResolverHandleExtensions
{
	public static T SetDefaultProxy<T>(this T resolver, string default_proxy) where T : GSimpleProxyResolverHandle
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_default_proxy(resolver, default_proxy);
		return resolver;
	}

	public static T SetIgnoreHosts<T>(this T resolver, string[] ignore_hosts) where T : GSimpleProxyResolverHandle
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_ignore_hosts(resolver, ignore_hosts);
		return resolver;
	}

	public static T SetUriProxy<T>(this T resolver, string uri_scheme, string proxy) where T : GSimpleProxyResolverHandle
	{
		GSimpleProxyResolverExterns.g_simple_proxy_resolver_set_uri_proxy(resolver, uri_scheme, proxy);
		return resolver;
	}

}

internal class GSimpleProxyResolverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_default_proxy(GSimpleProxyResolverHandle resolver, string default_proxy);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_ignore_hosts(GSimpleProxyResolverHandle resolver, string[] ignore_hosts);

	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_proxy_resolver_set_uri_proxy(GSimpleProxyResolverHandle resolver, string uri_scheme, string proxy);

	[DllImport(Libraries.Gio)]
	internal static extern GProxyResolverHandle g_simple_proxy_resolver_new(string default_proxy, string[] ignore_hosts);

}

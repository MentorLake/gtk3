namespace MentorLake.Gio;

public class GSimpleProxyResolverHandle : GObjectHandle, GProxyResolverHandle
{
	public static MentorLake.Gio.GProxyResolverHandle New(string default_proxy, string[] ignore_hosts)
	{
		return GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_new(default_proxy, ignore_hosts);
	}

}

public static class GSimpleProxyResolverHandleExtensions
{
	public static T SetDefaultProxy<T>(this T resolver, string default_proxy) where T : GSimpleProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GSimpleProxyResolverHandle)");
		GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_set_default_proxy(resolver, default_proxy);
		return resolver;
	}

	public static T SetIgnoreHosts<T>(this T resolver, string[] ignore_hosts) where T : GSimpleProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GSimpleProxyResolverHandle)");
		GSimpleProxyResolverHandleExterns.g_simple_proxy_resolver_set_ignore_hosts(resolver, ignore_hosts);
		return resolver;
	}

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

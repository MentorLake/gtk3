namespace MentorLake.Gtk3.Gio;

public interface GProxyResolverHandle
{
}

internal class GProxyResolverHandleImpl : BaseSafeHandle, GProxyResolverHandle
{
}

public static class GProxyResolverHandleExtensions
{
	public static bool IsSupported(this GProxyResolverHandle resolver)
	{
		return GProxyResolverExterns.g_proxy_resolver_is_supported(resolver);
	}

	public static IntPtr Lookup(this GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GProxyResolverExterns.g_proxy_resolver_lookup(resolver, uri, cancellable, out error);
	}

	public static T LookupAsync<T>(this T resolver, string uri, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GProxyResolverHandle
	{
		GProxyResolverExterns.g_proxy_resolver_lookup_async(resolver, uri, cancellable, callback, user_data);
		return resolver;
	}

	public static IntPtr LookupFinish(this GProxyResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GProxyResolverExterns.g_proxy_resolver_lookup_finish(resolver, result, out error);
	}

	public static GProxyResolverHandle GetDefault()
	{
		return GProxyResolverExterns.g_proxy_resolver_get_default();
	}

}

internal class GProxyResolverExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_proxy_resolver_is_supported(GProxyResolverHandle resolver);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_proxy_resolver_lookup(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_proxy_resolver_lookup_async(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_proxy_resolver_lookup_finish(GProxyResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GProxyResolverHandle g_proxy_resolver_get_default();

}

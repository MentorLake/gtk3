namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GProxyResolver` provides synchronous and asynchronous network proxy
/// resolution. `GProxyResolver` is used within [class@Gio.SocketClient] through
/// the method [method@Gio.SocketConnectable.proxy_enumerate].
/// </para>
/// <para>
/// Implementations of `GProxyResolver` based on
/// [libproxy](https://github.com/libproxy/libproxy) and GNOME settings can be
/// found in [glib-networking](https://gitlab.gnome.org/GNOME/glib-networking).
/// GIO comes with an implementation for use inside Flatpak portals.
/// </para>
/// </summary>

public interface GProxyResolverHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GProxyResolverHandleImpl : BaseSafeHandle, GProxyResolverHandle
{
}

public static class GProxyResolverHandleExtensions
{
/// <summary>
/// <para>
/// Checks if @resolver can be used on this system. (This is used
/// internally; g_proxy_resolver_get_default() will only return a proxy
/// resolver that returns %TRUE for this method.)
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GProxyResolver
/// </param>
/// <return>
/// %TRUE if @resolver is supported.
/// </return>

	public static bool IsSupported(this MentorLake.Gio.GProxyResolverHandle resolver)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		return GProxyResolverHandleExterns.g_proxy_resolver_is_supported(resolver);
	}

/// <summary>
/// <para>
/// Looks into the system proxy configuration to determine what proxy,
/// if any, to use to connect to @uri. The returned proxy URIs are of
/// the form `&amp;lt;protocol&amp;gt;://[user[:password]@]host[:port]` or
/// `direct://`, where `&amp;lt;protocol&amp;gt;` could be http, rtsp, socks
/// or other proxying protocol.
/// </para>
/// <para>
/// If you don&apos;t know what network protocol is being used on the
/// socket, you should use `none` as the URI protocol.
/// In this case, the resolver might still return a generic proxy type
/// (such as SOCKS), but would not return protocol-specific proxy types
/// (such as http).
/// </para>
/// <para>
/// `direct://` is used when no proxy is needed.
/// Direct connection should not be attempted unless it is part of the
/// returned array of proxies.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GProxyResolver
/// </param>
/// <param name="uri">
/// a URI representing the destination to connect to
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// A
///               NULL-terminated array of proxy URIs. Must be freed
///               with g_strfreev().
/// </return>

	public static string[] Lookup(this MentorLake.Gio.GProxyResolverHandle resolver, string uri, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		var externCallResult = GProxyResolverHandleExterns.g_proxy_resolver_lookup(resolver, uri, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronous lookup of proxy. See g_proxy_resolver_lookup() for more
/// details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GProxyResolver
/// </param>
/// <param name="uri">
/// a URI representing the destination to connect to
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupAsync<T>(this T resolver, string uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		GProxyResolverHandleExterns.g_proxy_resolver_lookup_async(resolver, uri, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Call this function to obtain the array of proxy URIs when
/// g_proxy_resolver_lookup_async() is complete. See
/// g_proxy_resolver_lookup() for more details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GProxyResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// A
///               NULL-terminated array of proxy URIs. Must be freed
///               with g_strfreev().
/// </return>

	public static string[] LookupFinish(this MentorLake.Gio.GProxyResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		var externCallResult = GProxyResolverHandleExterns.g_proxy_resolver_lookup_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the default #GProxyResolver for the system.
/// </para>
/// </summary>

/// <return>
/// the default #GProxyResolver, which
///     will be a dummy object if no proxy resolver is available
/// </return>

	public static MentorLake.Gio.GProxyResolverHandle GetDefault()
	{
		return GProxyResolverHandleExterns.g_proxy_resolver_get_default();
	}

}

internal class GProxyResolverHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_proxy_resolver_is_supported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle resolver);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_proxy_resolver_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle resolver, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_proxy_resolver_lookup_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle resolver, string uri, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_proxy_resolver_lookup_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyResolverHandle g_proxy_resolver_get_default();

}

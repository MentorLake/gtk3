namespace MentorLake.Gio;

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
	public static bool IsSupported(this MentorLake.Gio.GProxyResolverHandle resolver)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		return GProxyResolverHandleExterns.g_proxy_resolver_is_supported(resolver);
	}

	public static string[] Lookup(this MentorLake.Gio.GProxyResolverHandle resolver, string uri, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		var externCallResult = GProxyResolverHandleExterns.g_proxy_resolver_lookup(resolver, uri, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupAsync<T>(this T resolver, string uri, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GProxyResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		GProxyResolverHandleExterns.g_proxy_resolver_lookup_async(resolver, uri, cancellable, callback, user_data);
		return resolver;
	}

	public static string[] LookupFinish(this MentorLake.Gio.GProxyResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GProxyResolverHandle)");
		var externCallResult = GProxyResolverHandleExterns.g_proxy_resolver_lookup_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

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

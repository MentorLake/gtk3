namespace MentorLake.Gio;

public interface GProxyHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GProxyHandleImpl : BaseSafeHandle, GProxyHandle
{
}

public static class GProxyHandleExtensions
{
	public static MentorLake.Gio.GIOStreamHandle Connect(this MentorLake.Gio.GProxyHandle proxy, MentorLake.Gio.GIOStreamHandle connection, MentorLake.Gio.GProxyAddressHandle proxy_address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		var externCallResult = GProxyHandleExterns.g_proxy_connect(proxy, connection, proxy_address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectAsync<T>(this T proxy, MentorLake.Gio.GIOStreamHandle connection, MentorLake.Gio.GProxyAddressHandle proxy_address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		GProxyHandleExterns.g_proxy_connect_async(proxy, connection, proxy_address, cancellable, callback, user_data);
		return proxy;
	}

	public static MentorLake.Gio.GIOStreamHandle ConnectFinish(this MentorLake.Gio.GProxyHandle proxy, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		var externCallResult = GProxyHandleExterns.g_proxy_connect_finish(proxy, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool SupportsHostname(this MentorLake.Gio.GProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		return GProxyHandleExterns.g_proxy_supports_hostname(proxy);
	}

	public static MentorLake.Gio.GProxyHandle GetDefaultForProtocol(string protocol)
	{
		return GProxyHandleExterns.g_proxy_get_default_for_protocol(protocol);
	}

}

internal class GProxyHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_proxy_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))] MentorLake.Gio.GProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy_address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_proxy_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))] MentorLake.Gio.GProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyAddressHandle>))] MentorLake.Gio.GProxyAddressHandle proxy_address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_proxy_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))] MentorLake.Gio.GProxyHandle proxy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_proxy_supports_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))] MentorLake.Gio.GProxyHandle proxy);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyHandleImpl>))]
	internal static extern MentorLake.Gio.GProxyHandle g_proxy_get_default_for_protocol(string protocol);

}

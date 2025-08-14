namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GProxy` handles connecting to a remote host via a given type of
/// proxy server. It is implemented by the `gio-proxy` extension point.
/// The extensions are named after their proxy protocol name. As an
/// example, a SOCKS5 proxy implementation can be retrieved with the
/// name `socks5` using the function
/// [method@Gio.IOExtensionPoint.get_extension_by_name].
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Given @connection to communicate with a proxy (eg, a
/// #GSocketConnection that is connected to the proxy server), this
/// does the necessary handshake to connect to @proxy_address, and if
/// required, wraps the #GIOStream to handle proxy payload.
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxy
/// </param>
/// <param name="connection">
/// a #GIOStream
/// </param>
/// <param name="proxy_address">
/// a #GProxyAddress
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <return>
/// a #GIOStream that will replace @connection. This might
///               be the same as @connection, in which case a reference
///               will be added.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle Connect(this MentorLake.Gio.GProxyHandle proxy, MentorLake.Gio.GIOStreamHandle connection, MentorLake.Gio.GProxyAddressHandle proxy_address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		var externCallResult = GProxyHandleExterns.g_proxy_connect(proxy, connection, proxy_address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronous version of g_proxy_connect().
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxy
/// </param>
/// <param name="connection">
/// a #GIOStream
/// </param>
/// <param name="proxy_address">
/// a #GProxyAddress
/// </param>
/// <param name="cancellable">
/// a #GCancellable
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// callback data
/// </param>

	public static T ConnectAsync<T>(this T proxy, MentorLake.Gio.GIOStreamHandle connection, MentorLake.Gio.GProxyAddressHandle proxy_address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GProxyHandle
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		GProxyHandleExterns.g_proxy_connect_async(proxy, connection, proxy_address, cancellable, callback, user_data);
		return proxy;
	}

/// <summary>
/// <para>
/// See g_proxy_connect().
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxy
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GIOStream.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle ConnectFinish(this MentorLake.Gio.GProxyHandle proxy, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		var externCallResult = GProxyHandleExterns.g_proxy_connect_finish(proxy, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Some proxy protocols expect to be passed a hostname, which they
/// will resolve to an IP address themselves. Others, like SOCKS4, do
/// not allow this. This function will return %FALSE if @proxy is
/// implementing such a protocol. When %FALSE is returned, the caller
/// should resolve the destination hostname first, and then pass a
/// #GProxyAddress containing the stringified IP address to
/// g_proxy_connect() or g_proxy_connect_async().
/// </para>
/// </summary>

/// <param name="proxy">
/// a #GProxy
/// </param>
/// <return>
/// %TRUE if hostname resolution is supported.
/// </return>

	public static bool SupportsHostname(this MentorLake.Gio.GProxyHandle proxy)
	{
		if (proxy.IsInvalid) throw new Exception("Invalid handle (GProxyHandle)");
		return GProxyHandleExterns.g_proxy_supports_hostname(proxy);
	}

/// <summary>
/// <para>
/// Find the `gio-proxy` extension point for a proxy implementation that supports
/// the specified protocol.
/// </para>
/// </summary>

/// <param name="protocol">
/// the proxy protocol name (e.g. http, socks, etc)
/// </param>
/// <return>
/// return a #GProxy or NULL if protocol
///               is not supported.
/// </return>

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

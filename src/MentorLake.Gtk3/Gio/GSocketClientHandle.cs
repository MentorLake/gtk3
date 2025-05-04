namespace MentorLake.Gio;

public class GSocketClientHandle : GObjectHandle
{
	public static MentorLake.Gio.GSocketClientHandle New()
	{
		return GSocketClientHandleExterns.g_socket_client_new();
	}

}
public static class GSocketClientHandleSignalExtensions
{

	public static IObservable<GSocketClientHandleSignalStructs.EventSignal> Signal_Event(this GSocketClientHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSocketClientHandleSignalStructs.EventSignal> obs) =>
		{
			GSocketClientHandleSignalDelegates.@event handler = ( MentorLake.Gio.GSocketClientHandle self,  MentorLake.Gio.GSocketClientEvent @event,  MentorLake.Gio.GSocketConnectableHandle connectable,  MentorLake.Gio.GIOStreamHandle connection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketClientHandleSignalStructs.EventSignal()
				{
					Self = self, Event = @event, Connectable = connectable, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSocketClientHandleSignalStructs
{

public class EventSignal
{
	public MentorLake.Gio.GSocketClientHandle Self;
	public MentorLake.Gio.GSocketClientEvent Event;
	public MentorLake.Gio.GSocketConnectableHandle Connectable;
	public MentorLake.Gio.GIOStreamHandle Connection;
	public IntPtr UserData;
}
}

public static class GSocketClientHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle self, MentorLake.Gio.GSocketClientEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle connection, IntPtr user_data);

}


public static class GSocketClientHandleExtensions
{
	public static T AddApplicationProxy<T>(this T client, string protocol) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_add_application_proxy(client, protocol);
		return client;
	}

	public static MentorLake.Gio.GSocketConnectionHandle Connect(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect(client, connectable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectAsync<T>(this T client, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_async(client, connectable, cancellable, callback, user_data);
		return client;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToHost(this MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_host(client, host_and_port, default_port, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectToHostAsync<T>(this T client, string host_and_port, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_host_async(client, host_and_port, default_port, cancellable, callback, user_data);
		return client;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToHostFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_host_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToService(this MentorLake.Gio.GSocketClientHandle client, string domain, string service, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_service(client, domain, service, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectToServiceAsync<T>(this T client, string domain, string service, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_service_async(client, domain, service, cancellable, callback, user_data);
		return client;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToServiceFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_service_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToUri(this MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_uri(client, uri, default_port, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ConnectToUriAsync<T>(this T client, string uri, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_uri_async(client, uri, default_port, cancellable, callback, user_data);
		return client;
	}

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToUriFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_uri_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool GetEnableProxy(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_enable_proxy(client);
	}

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_family(client);
	}

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_local_address(client);
	}

	public static MentorLake.Gio.GSocketProtocol GetProtocol(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_protocol(client);
	}

	public static MentorLake.Gio.GProxyResolverHandle GetProxyResolver(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_proxy_resolver(client);
	}

	public static MentorLake.Gio.GSocketType GetSocketType(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_socket_type(client);
	}

	public static uint GetTimeout(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_timeout(client);
	}

	public static bool GetTls(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_tls(client);
	}

	public static MentorLake.Gio.GTlsCertificateFlags GetTlsValidationFlags(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_tls_validation_flags(client);
	}

	public static T SetEnableProxy<T>(this T client, bool enable) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_enable_proxy(client, enable);
		return client;
	}

	public static T SetFamily<T>(this T client, MentorLake.Gio.GSocketFamily family) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_family(client, family);
		return client;
	}

	public static T SetLocalAddress<T>(this T client, MentorLake.Gio.GSocketAddressHandle address) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_local_address(client, address);
		return client;
	}

	public static T SetProtocol<T>(this T client, MentorLake.Gio.GSocketProtocol protocol) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_protocol(client, protocol);
		return client;
	}

	public static T SetProxyResolver<T>(this T client, MentorLake.Gio.GProxyResolverHandle proxy_resolver) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_proxy_resolver(client, proxy_resolver);
		return client;
	}

	public static T SetSocketType<T>(this T client, MentorLake.Gio.GSocketType type) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_socket_type(client, type);
		return client;
	}

	public static T SetTimeout<T>(this T client, uint timeout) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_timeout(client, timeout);
		return client;
	}

	public static T SetTls<T>(this T client, bool tls) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_tls(client, tls);
		return client;
	}

	public static T SetTlsValidationFlags<T>(this T client, MentorLake.Gio.GTlsCertificateFlags flags) where T : GSocketClientHandle
	{
		if (client.IsInvalid || client.IsClosed) throw new Exception("Invalid or closed handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_tls_validation_flags(client, flags);
		return client;
	}

}

internal class GSocketClientHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketClientHandle g_socket_client_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_add_application_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string protocol);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_host_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_host_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_service([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string domain, string service, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_service_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string domain, string service, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_service_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_uri_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_uri_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_client_get_enable_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_socket_client_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_client_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketProtocol g_socket_client_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GProxyResolverHandle g_socket_client_get_proxy_resolver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketType g_socket_client_get_socket_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_socket_client_get_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_client_get_tls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_socket_client_get_tls_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_enable_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, bool enable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GSocketFamily family);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GSocketProtocol protocol);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_proxy_resolver([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))] MentorLake.Gio.GProxyResolverHandle proxy_resolver);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_socket_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GSocketType type);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, uint timeout);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_tls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, bool tls);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_set_tls_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GTlsCertificateFlags flags);

}

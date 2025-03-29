namespace MentorLake.Gio;

public class GSocketListenerHandle : GObjectHandle
{
	public static MentorLake.Gio.GSocketListenerHandle New()
	{
		return GSocketListenerHandleExterns.g_socket_listener_new();
	}

}
public static class GSocketListenerHandleSignalExtensions
{

	public static IObservable<GSocketListenerHandleSignalStructs.EventSignal> Signal_Event(this GSocketListenerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSocketListenerHandleSignalStructs.EventSignal> obs) =>
		{
			GSocketListenerHandleSignalDelegates.@event handler = ( MentorLake.Gio.GSocketListenerHandle self,  MentorLake.Gio.GSocketListenerEvent @event,  MentorLake.Gio.GSocketHandle socket,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketListenerHandleSignalStructs.EventSignal()
				{
					Self = self, Event = @event, Socket = socket, UserData = user_data
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

public static class GSocketListenerHandleSignalStructs
{

public struct EventSignal
{
	public MentorLake.Gio.GSocketListenerHandle Self;
	public MentorLake.Gio.GSocketListenerEvent Event;
	public MentorLake.Gio.GSocketHandle Socket;
	public IntPtr UserData;
}
}

public static class GSocketListenerHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle self, MentorLake.Gio.GSocketListenerEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, IntPtr user_data);

}


public static class GSocketListenerHandleExtensions
{
	public static MentorLake.Gio.GSocketConnectionHandle Accept(this MentorLake.Gio.GSocketListenerHandle listener, out MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept(listener, out source_object, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T AcceptAsync<T>(this T listener, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketListenerHandle
	{
		GSocketListenerHandleExterns.g_socket_listener_accept_async(listener, cancellable, callback, user_data);
		return listener;
	}

	public static MentorLake.Gio.GSocketConnectionHandle AcceptFinish(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GObject.GObjectHandle source_object)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_finish(listener, result, out source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GSocketHandle AcceptSocket(this MentorLake.Gio.GSocketListenerHandle listener, out MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_socket(listener, out source_object, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T AcceptSocketAsync<T>(this T listener, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketListenerHandle
	{
		GSocketListenerHandleExterns.g_socket_listener_accept_socket_async(listener, cancellable, callback, user_data);
		return listener;
	}

	public static MentorLake.Gio.GSocketHandle AcceptSocketFinish(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GObject.GObjectHandle source_object)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_socket_finish(listener, result, out source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool AddAddress(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol, MentorLake.GObject.GObjectHandle source_object, out MentorLake.Gio.GSocketAddressHandle effective_address)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_address(listener, address, type, protocol, source_object, out effective_address, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static ushort AddAnyInetPort(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.GObject.GObjectHandle source_object)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_any_inet_port(listener, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool AddInetPort(this MentorLake.Gio.GSocketListenerHandle listener, ushort port, MentorLake.GObject.GObjectHandle source_object)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_inet_port(listener, port, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool AddSocket(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GSocketHandle socket, MentorLake.GObject.GObjectHandle source_object)
	{
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_socket(listener, socket, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Close<T>(this T listener) where T : GSocketListenerHandle
	{
		GSocketListenerHandleExterns.g_socket_listener_close(listener);
		return listener;
	}

	public static T SetBacklog<T>(this T listener, int listen_backlog) where T : GSocketListenerHandle
	{
		GSocketListenerHandleExterns.g_socket_listener_set_backlog(listener, listen_backlog);
		return listener;
	}

}

internal class GSocketListenerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketListenerHandle g_socket_listener_new();

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_listener_accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_accept_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_listener_accept_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_listener_accept_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_accept_socket_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_listener_accept_socket_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_listener_add_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] out MentorLake.Gio.GSocketAddressHandle effective_address, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_socket_listener_add_any_inet_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_listener_add_inet_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, ushort port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_listener_add_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_set_backlog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, int listen_backlog);

}

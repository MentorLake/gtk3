namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GSocketListener` is an object that keeps track of a set
/// of server sockets and helps you accept sockets from any of the
/// socket, either sync or async.
/// </para>
/// <para>
/// Add addresses and ports to listen on using
/// [method@Gio.SocketListener.add_address] and
/// [method@Gio.SocketListener.add_inet_port]. These will be listened on until
/// [method@Gio.SocketListener.close] is called. Dropping your final reference to
/// the `GSocketListener` will not cause [method@Gio.SocketListener.close] to be
/// called implicitly, as some references to the `GSocketListener` may be held
/// internally.
/// </para>
/// <para>
/// If you want to implement a network server, also look at
/// [class@Gio.SocketService] and [class@Gio.ThreadedSocketService] which are
/// subclasses of `GSocketListener` that make this even easier.
/// </para>
/// </summary>

public class GSocketListenerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GSocketListener with no sockets to listen for.
/// New listeners can be added with e.g. g_socket_listener_add_address()
/// or g_socket_listener_add_inet_port().
/// </para>
/// </summary>

/// <return>
/// a new #GSocketListener.
/// </return>

	public static MentorLake.Gio.GSocketListenerHandle New()
	{
		return GSocketListenerHandleExterns.g_socket_listener_new();
	}

}
public static class GSocketListenerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @listener's activity on @socket changes state.
/// Note that when @listener is used to listen on both IPv4 and
/// IPv6, a separate set of signals will be emitted for each, and
/// the order they happen in is undefined.
/// </para>
/// </summary>

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

public class EventSignal
{

	public MentorLake.Gio.GSocketListenerHandle Self;
/// <summary>
/// <para>
/// the event that is occurring
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketListenerEvent Event;
/// <summary>
/// <para>
/// the #GSocket the event is occurring on
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketHandle Socket;

	public IntPtr UserData;
}
}

public static class GSocketListenerHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @listener's activity on @socket changes state.
/// Note that when @listener is used to listen on both IPv4 and
/// IPv6, a separate set of signals will be emitted for each, and
/// the order they happen in is undefined.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the event that is occurring
/// </param>
/// <param name="socket">
/// the #GSocket the event is occurring on
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle self, MentorLake.Gio.GSocketListenerEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, IntPtr user_data);

}


public static class GSocketListenerHandleExtensions
{
/// <summary>
/// <para>
/// Blocks waiting for a client to connect to any of the sockets added
/// to the listener. Returns a #GSocketConnection for the socket that was
/// accepted.
/// </para>
/// <para>
/// If @source_object is not %NULL it will be filled out with the source
/// object specified when the corresponding socket or address was added
/// to the listener.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="source_object">
/// location where #GObject pointer will be stored, or %NULL
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle Accept(this MentorLake.Gio.GSocketListenerHandle listener, out MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept(listener, out source_object, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of g_socket_listener_accept().
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_socket_listener_accept_finish()
/// to get the result of the operation.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// user data for the callback
/// </param>

	public static T AcceptAsync<T>(this T listener, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketListenerHandle
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		GSocketListenerHandleExterns.g_socket_listener_accept_async(listener, cancellable, callback, user_data);
		return listener;
	}

/// <summary>
/// <para>
/// Finishes an async accept operation. See g_socket_listener_accept_async()
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle AcceptFinish(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GObject.GObjectHandle source_object)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_finish(listener, result, out source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Blocks waiting for a client to connect to any of the sockets added
/// to the listener. Returns the #GSocket that was accepted.
/// </para>
/// <para>
/// If you want to accept the high-level #GSocketConnection, not a #GSocket,
/// which is often the case, then you should use g_socket_listener_accept()
/// instead.
/// </para>
/// <para>
/// If @source_object is not %NULL it will be filled out with the source
/// object specified when the corresponding socket or address was added
/// to the listener.
/// </para>
/// <para>
/// If @cancellable is not %NULL, then the operation can be cancelled by
/// triggering the cancellable object from another thread. If the operation
/// was cancelled, the error %G_IO_ERROR_CANCELLED will be returned.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="source_object">
/// location where #GObject pointer will be stored, or %NULL.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GSocket on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketHandle AcceptSocket(this MentorLake.Gio.GSocketListenerHandle listener, out MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_socket(listener, out source_object, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of g_socket_listener_accept_socket().
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_socket_listener_accept_socket_finish()
/// to get the result of the operation.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// user data for the callback
/// </param>

	public static T AcceptSocketAsync<T>(this T listener, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketListenerHandle
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		GSocketListenerHandleExterns.g_socket_listener_accept_socket_async(listener, cancellable, callback, user_data);
		return listener;
	}

/// <summary>
/// <para>
/// Finishes an async accept operation. See g_socket_listener_accept_socket_async()
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <return>
/// a #GSocket on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketHandle AcceptSocketFinish(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GObject.GObjectHandle source_object)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_accept_socket_finish(listener, result, out source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a socket of type @type and protocol @protocol, binds
/// it to @address and adds it to the set of sockets we're accepting
/// sockets from.
/// </para>
/// <para>
/// Note that adding an IPv6 address, depending on the platform,
/// may or may not result in a listener that also accepts IPv4
/// connections.  For more deterministic behavior, see
/// g_socket_listener_add_inet_port().
/// </para>
/// <para>
/// @source_object will be passed out in the various calls
/// to accept to identify this particular source, which is
/// useful if you're listening on multiple addresses and do
/// different things depending on what address is connected to.
/// </para>
/// <para>
/// If successful and @effective_address is non-%NULL then it will
/// be set to the address that the binding actually occurred at.  This
/// is helpful for determining the port number that was used for when
/// requesting a binding to port 0 (ie: "any port").  This address, if
/// requested, belongs to the caller and must be freed.
/// </para>
/// <para>
/// Call g_socket_listener_close() to stop listening on @address; this will not
/// be done automatically when you drop your final reference to @listener, as
/// references may be held internally.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="address">
/// a #GSocketAddress
/// </param>
/// <param name="type">
/// a #GSocketType
/// </param>
/// <param name="protocol">
/// a #GSocketProtocol
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <param name="effective_address">
/// location to store the address that was bound to, or %NULL.
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool AddAddress(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GSocketType type, MentorLake.Gio.GSocketProtocol protocol, MentorLake.GObject.GObjectHandle source_object, out MentorLake.Gio.GSocketAddressHandle effective_address)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_address(listener, address, type, protocol, source_object, out effective_address, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Listens for TCP connections on any available port number for both
/// IPv6 and IPv4 (if each is available).
/// </para>
/// <para>
/// This is useful if you need to have a socket for incoming connections
/// but don't care about the specific port number.
/// </para>
/// <para>
/// @source_object will be passed out in the various calls
/// to accept to identify this particular source, which is
/// useful if you're listening on multiple addresses and do
/// different things depending on what address is connected to.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <return>
/// the port number, or 0 in case of failure.
/// </return>

	public static ushort AddAnyInetPort(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.GObject.GObjectHandle source_object)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_any_inet_port(listener, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Helper function for g_socket_listener_add_address() that
/// creates a TCP/IP socket listening on IPv4 and IPv6 (if
/// supported) on the specified port on all interfaces.
/// </para>
/// <para>
/// @source_object will be passed out in the various calls
/// to accept to identify this particular source, which is
/// useful if you're listening on multiple addresses and do
/// different things depending on what address is connected to.
/// </para>
/// <para>
/// Call g_socket_listener_close() to stop listening on @port; this will not
/// be done automatically when you drop your final reference to @listener, as
/// references may be held internally.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="port">
/// an IP port number (non-zero)
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool AddInetPort(this MentorLake.Gio.GSocketListenerHandle listener, ushort port, MentorLake.GObject.GObjectHandle source_object)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_inet_port(listener, port, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Adds @socket to the set of sockets that we try to accept
/// new clients from. The socket must be bound to a local
/// address and listened to.
/// </para>
/// <para>
/// @source_object will be passed out in the various calls
/// to accept to identify this particular source, which is
/// useful if you're listening on multiple addresses and do
/// different things depending on what address is connected to.
/// </para>
/// <para>
/// The @socket will not be automatically closed when the @listener is finalized
/// unless the listener held the final reference to the socket. Before GLib 2.42,
/// the @socket was automatically closed on finalization of the @listener, even
/// if references to it were held elsewhere.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="socket">
/// a listening #GSocket
/// </param>
/// <param name="source_object">
/// Optional #GObject identifying this source
/// </param>
/// <return>
/// %TRUE on success, %FALSE on error.
/// </return>

	public static bool AddSocket(this MentorLake.Gio.GSocketListenerHandle listener, MentorLake.Gio.GSocketHandle socket, MentorLake.GObject.GObjectHandle source_object)
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		var externCallResult = GSocketListenerHandleExterns.g_socket_listener_add_socket(listener, socket, source_object, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Closes all the sockets in the listener.
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>

	public static T Close<T>(this T listener) where T : GSocketListenerHandle
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		GSocketListenerHandleExterns.g_socket_listener_close(listener);
		return listener;
	}

/// <summary>
/// <para>
/// Sets the listen backlog on the sockets in the listener. This must be called
/// before adding any sockets, addresses or ports to the #GSocketListener (for
/// example, by calling g_socket_listener_add_inet_port()) to be effective.
/// </para>
/// <para>
/// See g_socket_set_listen_backlog() for details
/// </para>
/// </summary>

/// <param name="listener">
/// a #GSocketListener
/// </param>
/// <param name="listen_backlog">
/// an integer
/// </param>

	public static T SetBacklog<T>(this T listener, int listen_backlog) where T : GSocketListenerHandle
	{
		if (listener.IsInvalid) throw new Exception("Invalid handle (GSocketListenerHandle)");
		GSocketListenerHandleExterns.g_socket_listener_set_backlog(listener, listen_backlog);
		return listener;
	}

}

internal class GSocketListenerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))]
	internal static extern MentorLake.Gio.GSocketListenerHandle g_socket_listener_new();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_listener_accept([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_accept_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_listener_accept_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_listener_accept_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] out MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_listener_accept_socket_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketListenerHandle>))] MentorLake.Gio.GSocketListenerHandle listener, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
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

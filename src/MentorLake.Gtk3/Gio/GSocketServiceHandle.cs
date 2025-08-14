namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GSocketService` is an object that represents a service that
/// is provided to the network or over local sockets.  When a new
/// connection is made to the service the [signal@Gio.SocketService::incoming]
/// signal is emitted.
/// </para>
/// <para>
/// A `GSocketService` is a subclass of [class@Gio.SocketListener] and you need
/// to add the addresses you want to accept connections on with the
/// [class@Gio.SocketListener] APIs.
/// </para>
/// <para>
/// There are two options for implementing a network service based on
/// `GSocketService`. The first is to create the service using
/// [ctor@Gio.SocketService.new] and to connect to the
/// [signal@Gio.SocketService::incoming] signal. The second is to subclass
/// `GSocketService` and override the default signal handler implementation.
/// </para>
/// <para>
/// In either case, the handler must immediately return, or else it
/// will block additional incoming connections from being serviced.
/// If you are interested in writing connection handlers that contain
/// blocking code then see [class@Gio.ThreadedSocketService].
/// </para>
/// <para>
/// The socket service runs on the main loop of the
/// thread-default context (see
/// [method@GLib.MainContext.push_thread_default]) of the thread it is
/// created in, and is not threadsafe in general. However, the calls to start and
/// stop the service are thread-safe so these can be used from threads that
/// handle incoming clients.
/// </para>
/// </summary>

public class GSocketServiceHandle : GSocketListenerHandle
{
/// <summary>
/// <para>
/// Creates a new #GSocketService with no sockets to listen for.
/// New listeners can be added with e.g. g_socket_listener_add_address()
/// or g_socket_listener_add_inet_port().
/// </para>
/// <para>
/// New services are created active, there is no need to call
/// g_socket_service_start(), unless g_socket_service_stop() has been
/// called before.
/// </para>
/// </summary>

/// <return>
/// a new #GSocketService.
/// </return>

	public static MentorLake.Gio.GSocketServiceHandle New()
	{
		return GSocketServiceHandleExterns.g_socket_service_new();
	}

}
public static class GSocketServiceHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::incoming signal is emitted when a new incoming connection
/// to @service needs to be handled. The handler must initiate the
/// handling of @connection, but may not block; in essence,
/// asynchronous operations must be used.
/// </para>
/// <para>
/// @connection will be unreffed once the signal handler returns,
/// so you need to ref it yourself if you are planning to use it.
/// </para>
/// </summary>

	public static IObservable<GSocketServiceHandleSignalStructs.IncomingSignal> Signal_Incoming(this GSocketServiceHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSocketServiceHandleSignalStructs.IncomingSignal> obs) =>
		{
			GSocketServiceHandleSignalDelegates.incoming handler = ( MentorLake.Gio.GSocketServiceHandle self,  MentorLake.Gio.GSocketConnectionHandle connection,  MentorLake.GObject.GObjectHandle source_object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSocketServiceHandleSignalStructs.IncomingSignal()
				{
					Self = self, Connection = connection, SourceObject = source_object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "incoming", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSocketServiceHandleSignalStructs
{

public class IncomingSignal
{

	public MentorLake.Gio.GSocketServiceHandle Self;
/// <summary>
/// <para>
/// a new #GSocketConnection object
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketConnectionHandle Connection;
/// <summary>
/// <para>
/// the source_object passed to
///     g_socket_listener_add_address()
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle SourceObject;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being called
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GSocketServiceHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::incoming signal is emitted when a new incoming connection
/// to @service needs to be handled. The handler must initiate the
/// handling of @connection, but may not block; in essence,
/// asynchronous operations must be used.
/// </para>
/// <para>
/// @connection will be unreffed once the signal handler returns,
/// so you need to ref it yourself if you are planning to use it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="connection">
/// a new #GSocketConnection object
/// </param>
/// <param name="source_object">
/// the source_object passed to
///     g_socket_listener_add_address()
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being called
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool incoming([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, IntPtr user_data);

}


public static class GSocketServiceHandleExtensions
{
/// <summary>
/// <para>
/// Check whether the service is active or not. An active
/// service will accept new clients that connect, while
/// a non-active service will let connecting clients queue
/// up until the service is started.
/// </para>
/// </summary>

/// <param name="service">
/// a #GSocketService
/// </param>
/// <return>
/// %TRUE if the service is active, %FALSE otherwise
/// </return>

	public static bool IsActive(this MentorLake.Gio.GSocketServiceHandle service)
	{
		if (service.IsInvalid) throw new Exception("Invalid handle (GSocketServiceHandle)");
		return GSocketServiceHandleExterns.g_socket_service_is_active(service);
	}

/// <summary>
/// <para>
/// Restarts the service, i.e. start accepting connections
/// from the added sockets when the mainloop runs. This only needs
/// to be called after the service has been stopped from
/// g_socket_service_stop().
/// </para>
/// <para>
/// This call is thread-safe, so it may be called from a thread
/// handling an incoming client request.
/// </para>
/// </summary>

/// <param name="service">
/// a #GSocketService
/// </param>

	public static T Start<T>(this T service) where T : GSocketServiceHandle
	{
		if (service.IsInvalid) throw new Exception("Invalid handle (GSocketServiceHandle)");
		GSocketServiceHandleExterns.g_socket_service_start(service);
		return service;
	}

/// <summary>
/// <para>
/// Stops the service, i.e. stops accepting connections
/// from the added sockets when the mainloop runs.
/// </para>
/// <para>
/// This call is thread-safe, so it may be called from a thread
/// handling an incoming client request.
/// </para>
/// <para>
/// Note that this only stops accepting new connections; it does not
/// close the listening sockets, and you can call
/// g_socket_service_start() again later to begin listening again. To
/// close the listening sockets, call g_socket_listener_close(). (This
/// will happen automatically when the #GSocketService is finalized.)
/// </para>
/// <para>
/// This must be called before calling g_socket_listener_close() as
/// the socket service will start accepting connections immediately
/// when a new socket is added.
/// </para>
/// </summary>

/// <param name="service">
/// a #GSocketService
/// </param>

	public static T Stop<T>(this T service) where T : GSocketServiceHandle
	{
		if (service.IsInvalid) throw new Exception("Invalid handle (GSocketServiceHandle)");
		GSocketServiceHandleExterns.g_socket_service_stop(service);
		return service;
	}

}

internal class GSocketServiceHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))]
	internal static extern MentorLake.Gio.GSocketServiceHandle g_socket_service_new();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_service_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_service_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_service_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketServiceHandle>))] MentorLake.Gio.GSocketServiceHandle service);

}

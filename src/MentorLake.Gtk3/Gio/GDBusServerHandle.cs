namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusServer` is a helper for listening to and accepting D-Bus
/// connections. This can be used to create a new D-Bus server, allowing two
/// peers to use the D-Bus protocol for their own specialized communication.
/// A server instance provided in this way will not perform message routing or
/// implement the
/// [`org.freedesktop.DBus` interface](https://dbus.freedesktop.org/doc/dbus-specification.html#message-bus-messages).
/// </para>
/// <para>
/// To just export an object on a well-known name on a message bus, such as the
/// session or system bus, you should instead use [func@Gio.bus_own_name].
/// </para>
/// <para>
/// An example of peer-to-peer communication with GDBus can be found
/// in [gdbus-example-peer.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-peer.c).
/// </para>
/// <para>
/// Note that a minimal `GDBusServer` will accept connections from any
/// peer. In many use-cases it will be necessary to add a
/// [class@Gio.DBusAuthObserver] that only accepts connections that have
/// successfully authenticated as the same user that is running the
/// `GDBusServer`. Since GLib 2.68 this can be achieved more simply by passing
/// the `G_DBUS_SERVER_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER` flag to the
/// server.
/// </para>
/// </summary>

public class GDBusServerHandle : GObjectHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Creates a new D-Bus server that listens on the first address in
/// @address that works.
/// </para>
/// <para>
/// Once constructed, you can use g_dbus_server_get_client_address() to
/// get a D-Bus address string that clients can use to connect.
/// </para>
/// <para>
/// To have control over the available authentication mechanisms and
/// the users that are authorized to connect, it is strongly recommended
/// to provide a non-%NULL #GDBusAuthObserver.
/// </para>
/// <para>
/// Connect to the #GDBusServer::new-connection signal to handle
/// incoming connections.
/// </para>
/// <para>
/// The returned #GDBusServer isn't active - you have to start it with
/// g_dbus_server_start().
/// </para>
/// <para>
/// #GDBusServer is used in this [example][gdbus-peer-to-peer].
/// </para>
/// <para>
/// This is a synchronous failable constructor. There is currently no
/// asynchronous version.
/// </para>
/// </summary>

/// <param name="address">
/// A D-Bus address.
/// </param>
/// <param name="flags">
/// Flags from the #GDBusServerFlags enumeration.
/// </param>
/// <param name="guid">
/// A D-Bus GUID.
/// </param>
/// <param name="observer">
/// A #GDBusAuthObserver or %NULL.
/// </param>
/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <return>
/// A #GDBusServer or %NULL if @error is set. Free with
/// g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusServerHandle NewSync(string address, MentorLake.Gio.GDBusServerFlags flags, string guid, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusServerHandleExterns.g_dbus_server_new_sync(address, flags, guid, observer, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
public static class GDBusServerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a new authenticated connection has been made. Use
/// g_dbus_connection_get_peer_credentials() to figure out what
/// identity (if any), was authenticated.
/// </para>
/// <para>
/// If you want to accept the connection, take a reference to the
/// @connection object and return %TRUE. When you are done with the
/// connection call g_dbus_connection_close() and give up your
/// reference. Note that the other peer may disconnect at any time -
/// a typical thing to do when accepting a connection is to listen to
/// the #GDBusConnection::closed signal.
/// </para>
/// <para>
/// If #GDBusServer:flags contains %G_DBUS_SERVER_FLAGS_RUN_IN_THREAD
/// then the signal is emitted in a new thread dedicated to the
/// connection. Otherwise the signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread that @server was constructed in.
/// </para>
/// <para>
/// You are guaranteed that signal handlers for this signal runs
/// before incoming messages on @connection are processed. This means
/// that it's suitable to call g_dbus_connection_register_object() or
/// similar from the signal handler.
/// </para>
/// </summary>

	public static IObservable<GDBusServerHandleSignalStructs.NewConnectionSignal> Signal_NewConnection(this GDBusServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusServerHandleSignalStructs.NewConnectionSignal> obs) =>
		{
			GDBusServerHandleSignalDelegates.new_connection handler = ( MentorLake.Gio.GDBusServerHandle self,  MentorLake.Gio.GDBusConnectionHandle connection,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusServerHandleSignalStructs.NewConnectionSignal()
				{
					Self = self, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "new-connection", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusServerHandleSignalStructs
{

public class NewConnectionSignal
{

	public MentorLake.Gio.GDBusServerHandle Self;
/// <summary>
/// <para>
/// A #GDBusConnection for the new connection.
/// </para>
/// </summary>

	public MentorLake.Gio.GDBusConnectionHandle Connection;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to claim @connection, %FALSE to let other handlers
/// run.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GDBusServerHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a new authenticated connection has been made. Use
/// g_dbus_connection_get_peer_credentials() to figure out what
/// identity (if any), was authenticated.
/// </para>
/// <para>
/// If you want to accept the connection, take a reference to the
/// @connection object and return %TRUE. When you are done with the
/// connection call g_dbus_connection_close() and give up your
/// reference. Note that the other peer may disconnect at any time -
/// a typical thing to do when accepting a connection is to listen to
/// the #GDBusConnection::closed signal.
/// </para>
/// <para>
/// If #GDBusServer:flags contains %G_DBUS_SERVER_FLAGS_RUN_IN_THREAD
/// then the signal is emitted in a new thread dedicated to the
/// connection. Otherwise the signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread that @server was constructed in.
/// </para>
/// <para>
/// You are guaranteed that signal handlers for this signal runs
/// before incoming messages on @connection are processed. This means
/// that it's suitable to call g_dbus_connection_register_object() or
/// similar from the signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="connection">
/// A #GDBusConnection for the new connection.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to claim @connection, %FALSE to let other handlers
/// run.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool new_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, IntPtr user_data);

}


public static class GDBusServerHandleExtensions
{
/// <summary>
/// <para>
/// Gets a
/// [D-Bus address](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses)
/// string that can be used by clients to connect to @server.
/// </para>
/// <para>
/// This is valid and non-empty if initializing the #GDBusServer succeeded.
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>
/// <return>
/// A D-Bus address string. Do not free, the string is owned
/// by @server.
/// </return>

	public static string GetClientAddress(this MentorLake.Gio.GDBusServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		return GDBusServerHandleExterns.g_dbus_server_get_client_address(server);
	}

/// <summary>
/// <para>
/// Gets the flags for @server.
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>
/// <return>
/// A set of flags from the #GDBusServerFlags enumeration.
/// </return>

	public static MentorLake.Gio.GDBusServerFlags GetFlags(this MentorLake.Gio.GDBusServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		return GDBusServerHandleExterns.g_dbus_server_get_flags(server);
	}

/// <summary>
/// <para>
/// Gets the GUID for @server, as provided to g_dbus_server_new_sync().
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>
/// <return>
/// A D-Bus GUID. Do not free this string, it is owned by @server.
/// </return>

	public static string GetGuid(this MentorLake.Gio.GDBusServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		return GDBusServerHandleExterns.g_dbus_server_get_guid(server);
	}

/// <summary>
/// <para>
/// Gets whether @server is active.
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>
/// <return>
/// %TRUE if server is active, %FALSE otherwise.
/// </return>

	public static bool IsActive(this MentorLake.Gio.GDBusServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		return GDBusServerHandleExterns.g_dbus_server_is_active(server);
	}

/// <summary>
/// <para>
/// Starts @server.
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>

	public static T Start<T>(this T server) where T : GDBusServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		GDBusServerHandleExterns.g_dbus_server_start(server);
		return server;
	}

/// <summary>
/// <para>
/// Stops @server.
/// </para>
/// </summary>

/// <param name="server">
/// A #GDBusServer.
/// </param>

	public static T Stop<T>(this T server) where T : GDBusServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (GDBusServerHandle)");
		GDBusServerHandleExterns.g_dbus_server_stop(server);
		return server;
	}

}

internal class GDBusServerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))]
	internal static extern MentorLake.Gio.GDBusServerHandle g_dbus_server_new_sync(string address, MentorLake.Gio.GDBusServerFlags flags, string guid, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_server_get_client_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusServerFlags g_dbus_server_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_server_get_guid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_server_is_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_server_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_server_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusServerHandle>))] MentorLake.Gio.GDBusServerHandle server);

}

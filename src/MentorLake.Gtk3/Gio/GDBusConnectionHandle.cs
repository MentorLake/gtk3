namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GDBusConnection` type is used for D-Bus connections to remote
/// peers such as a message buses.
/// </para>
/// <para>
/// It is a low-level API that offers a lot of flexibility. For instance,
/// it lets you establish a connection over any transport that can by represented
/// as a [class@Gio.IOStream].
/// </para>
/// <para>
/// This class is rarely used directly in D-Bus clients. If you are writing
/// a D-Bus client, it is often easier to use the [func@Gio.bus_own_name],
/// [func@Gio.bus_watch_name] or [func@Gio.DBusProxy.new_for_bus] APIs.
/// </para>
/// <para>
/// As an exception to the usual GLib rule that a particular object must not
/// be used by two threads at the same time, `GDBusConnection`s methods may be
/// called from any thread. This is so that [func@Gio.bus_get] and
/// [func@Gio.bus_get_sync] can safely return the same `GDBusConnection` when
/// called from any thread.
/// </para>
/// <para>
/// Most of the ways to obtain a `GDBusConnection` automatically initialize it
/// (i.e. connect to D-Bus): for instance, [func@Gio.DBusConnection.new] and
/// [func@Gio.bus_get], and the synchronous versions of those methods, give you
/// an initialized connection. Language bindings for GIO should use
/// [func@Gio.Initable.new] or [func@Gio.AsyncInitable.new_async], which also
/// initialize the connection.
/// </para>
/// <para>
/// If you construct an uninitialized `GDBusConnection`, such as via
/// [ctor@GObject.Object.new], you must initialize it via [method@Gio.Initable.init] or
/// [method@Gio.AsyncInitable.init_async] before using its methods or properties.
/// Calling methods or accessing properties on a `GDBusConnection` that has not
/// completed initialization successfully is considered to be invalid, and leads
/// to undefined behaviour. In particular, if initialization fails with a
/// `GError`, the only valid thing you can do with that `GDBusConnection` is to
/// free it with [method@GObject.Object.unref].
/// </para>
/// <para>
/// ## An example D-Bus server
/// </para>
/// <para>
/// Here is an example for a D-Bus server:
/// [gdbus-example-server.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-server.c)
/// </para>
/// <para>
/// ## An example for exporting a subtree
/// </para>
/// <para>
/// Here is an example for exporting a subtree:
/// [gdbus-example-subtree.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-subtree.c)
/// </para>
/// <para>
/// ## An example for file descriptor passing
/// </para>
/// <para>
/// Here is an example for passing UNIX file descriptors:
/// [gdbus-unix-fd-client.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-unix-fd-client.c)
/// </para>
/// <para>
/// ## An example for exporting a GObject
/// </para>
/// <para>
/// Here is an example for exporting a #GObject:
/// [gdbus-example-export.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-example-export.c)
/// </para>
/// </summary>

public class GDBusConnectionHandle : GObjectHandle, GAsyncInitableHandle, GInitableHandle
{
/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_new().
/// </para>
/// </summary>

/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback
///     passed to g_dbus_connection_new().
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set. Free
///     with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle NewFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_new_for_address().
/// </para>
/// </summary>

/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed
///     to g_dbus_connection_new()
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle NewForAddressFinish(MentorLake.Gio.GAsyncResultHandle res)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_for_address_finish(res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously connects and sets up a D-Bus client connection for
/// exchanging D-Bus messages with an endpoint specified by @address
/// which must be in the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// <para>
/// This constructor can only be used to initiate client-side
/// connections - use g_dbus_connection_new_sync() if you need to act
/// as the server. In particular, @flags cannot contain the
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_SERVER,
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS or
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER flags.
/// </para>
/// <para>
/// This is a synchronous failable constructor. See
/// g_dbus_connection_new_for_address() for the asynchronous version.
/// </para>
/// <para>
/// If @observer is not %NULL it may be used to control the
/// authentication process.
/// </para>
/// </summary>

/// <param name="address">
/// a D-Bus address
/// </param>
/// <param name="flags">
/// flags describing how to make the connection
/// </param>
/// <param name="observer">
/// a #GDBusAuthObserver or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle NewForAddressSync(string address, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_for_address_sync(address, flags, observer, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously sets up a D-Bus connection for exchanging D-Bus messages
/// with the end represented by @stream.
/// </para>
/// <para>
/// If @stream is a #GSocketConnection, then the corresponding #GSocket
/// will be put into non-blocking mode.
/// </para>
/// <para>
/// The D-Bus connection will interact with @stream from a worker thread.
/// As a result, the caller should not interact with @stream after this
/// method has been called, except by calling g_object_unref() on it.
/// </para>
/// <para>
/// If @observer is not %NULL it may be used to control the
/// authentication process.
/// </para>
/// <para>
/// This is a synchronous failable constructor. See
/// g_dbus_connection_new() for the asynchronous version.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="guid">
/// the GUID to use if authenticating as a server or %NULL
/// </param>
/// <param name="flags">
/// flags describing how to make the connection
/// </param>
/// <param name="observer">
/// a #GDBusAuthObserver or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// a #GDBusConnection or %NULL if @error is set.
///     Free with g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle NewSync(MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_new_sync(stream, guid, flags, observer, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sets up a D-Bus connection for exchanging D-Bus messages
/// with the end represented by @stream.
/// </para>
/// <para>
/// If @stream is a #GSocketConnection, then the corresponding #GSocket
/// will be put into non-blocking mode.
/// </para>
/// <para>
/// The D-Bus connection will interact with @stream from a worker thread.
/// As a result, the caller should not interact with @stream after this
/// method has been called, except by calling g_object_unref() on it.
/// </para>
/// <para>
/// If @observer is not %NULL it may be used to control the
/// authentication process.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked. You can
/// then call g_dbus_connection_new_finish() to get the result of the
/// operation.
/// </para>
/// <para>
/// This is an asynchronous failable constructor. See
/// g_dbus_connection_new_sync() for the synchronous
/// version.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="guid">
/// the GUID to use if authenticating as a server or %NULL
/// </param>
/// <param name="flags">
/// flags describing how to make the connection
/// </param>
/// <param name="observer">
/// a #GDBusAuthObserver or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to @callback
/// </param>

	public static void New(MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionHandleExterns.g_dbus_connection_new(stream, guid, flags, observer, cancellable, callback, user_data);
	}

/// <summary>
/// <para>
/// Asynchronously connects and sets up a D-Bus client connection for
/// exchanging D-Bus messages with an endpoint specified by @address
/// which must be in the
/// [D-Bus address format](https://dbus.freedesktop.org/doc/dbus-specification.html#addresses).
/// </para>
/// <para>
/// This constructor can only be used to initiate client-side
/// connections - use g_dbus_connection_new() if you need to act as the
/// server. In particular, @flags cannot contain the
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_SERVER,
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS or
/// %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER flags.
/// </para>
/// <para>
/// When the operation is finished, @callback will be invoked. You can
/// then call g_dbus_connection_new_for_address_finish() to get the result of
/// the operation.
/// </para>
/// <para>
/// If @observer is not %NULL it may be used to control the
/// authentication process.
/// </para>
/// <para>
/// This is an asynchronous failable constructor. See
/// g_dbus_connection_new_for_address_sync() for the synchronous
/// version.
/// </para>
/// </summary>

/// <param name="address">
/// a D-Bus address
/// </param>
/// <param name="flags">
/// flags describing how to make the connection
/// </param>
/// <param name="observer">
/// a #GDBusAuthObserver or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to @callback
/// </param>

	public static void NewForAddress(string address, MentorLake.Gio.GDBusConnectionFlags flags, MentorLake.Gio.GDBusAuthObserverHandle observer, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDBusConnectionHandleExterns.g_dbus_connection_new_for_address(address, flags, observer, cancellable, callback, user_data);
	}

}
public static class GDBusConnectionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the connection is closed.
/// </para>
/// <para>
/// The cause of this event can be
/// </para>
/// <para>
/// - If g_dbus_connection_close() is called. In this case
///   @remote_peer_vanished is set to %FALSE and @error is %NULL.
/// </para>
/// <para>
/// - If the remote peer closes the connection. In this case
///   @remote_peer_vanished is set to %TRUE and @error is set.
/// </para>
/// <para>
/// - If the remote peer sends invalid or malformed data. In this
///   case @remote_peer_vanished is set to %FALSE and @error is set.
/// </para>
/// <para>
/// Upon receiving this signal, you should give up your reference to
/// @connection. You are guaranteed that this signal is emitted only
/// once.
/// </para>
/// </summary>

	public static IObservable<GDBusConnectionHandleSignalStructs.ClosedSignal> Signal_Closed(this GDBusConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GDBusConnectionHandleSignalStructs.ClosedSignal> obs) =>
		{
			GDBusConnectionHandleSignalDelegates.closed handler = ( MentorLake.Gio.GDBusConnectionHandle self,  bool remote_peer_vanished,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusConnectionHandleSignalStructs.ClosedSignal()
				{
					Self = self, RemotePeerVanished = remote_peer_vanished, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GDBusConnectionHandleSignalStructs
{

public class ClosedSignal
{

	public MentorLake.Gio.GDBusConnectionHandle Self;
/// <summary>
/// <para>
/// %TRUE if @connection is closed because the
///     remote peer closed its end of the connection
/// </para>
/// </summary>

	public bool RemotePeerVanished;
/// <summary>
/// <para>
/// a #GError with more details about the event or %NULL
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}
}

public static class GDBusConnectionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the connection is closed.
/// </para>
/// <para>
/// The cause of this event can be
/// </para>
/// <para>
/// - If g_dbus_connection_close() is called. In this case
///   @remote_peer_vanished is set to %FALSE and @error is %NULL.
/// </para>
/// <para>
/// - If the remote peer closes the connection. In this case
///   @remote_peer_vanished is set to %TRUE and @error is set.
/// </para>
/// <para>
/// - If the remote peer sends invalid or malformed data. In this
///   case @remote_peer_vanished is set to %FALSE and @error is set.
/// </para>
/// <para>
/// Upon receiving this signal, you should give up your reference to
/// @connection. You are guaranteed that this signal is emitted only
/// once.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="remote_peer_vanished">
/// %TRUE if @connection is closed because the
///     remote peer closed its end of the connection
/// </param>
/// <param name="error">
/// a #GError with more details about the event or %NULL
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle self, bool remote_peer_vanished, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);

}


public static class GDBusConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Adds a message filter. Filters are handlers that are run on all
/// incoming and outgoing messages, prior to standard dispatch. Filters
/// are run in the order that they were added.  The same handler can be
/// added as a filter more than once, in which case it will be run more
/// than once.  Filters added during a filter callback won&apos;t be run on
/// the message being processed. Filter functions are allowed to modify
/// and even drop messages.
/// </para>
/// <para>
/// Note that filters are run in a dedicated message handling thread so
/// they can&apos;t block and, generally, can&apos;t do anything but signal a
/// worker thread. Also note that filters are rarely needed - use API
/// such as g_dbus_connection_send_message_with_reply(),
/// g_dbus_connection_signal_subscribe() or g_dbus_connection_call() instead.
/// </para>
/// <para>
/// If a filter consumes an incoming message the message is not
/// dispatched anywhere else - not even the standard dispatch machinery
/// (that API such as g_dbus_connection_signal_subscribe() and
/// g_dbus_connection_send_message_with_reply() relies on) will see the
/// message. Similarly, if a filter consumes an outgoing message, the
/// message will not be sent to the other peer.
/// </para>
/// <para>
/// If @user_data_free_func is non-%NULL, it will be called (in the
/// thread-default main context of the thread you are calling this
/// method from) at some point after @user_data is no longer
/// needed. (It is not guaranteed to be called synchronously when the
/// filter is removed, and may be called after @connection has been
/// destroyed.)
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="filter_function">
/// a filter function
/// </param>
/// <param name="user_data">
/// user data to pass to @filter_function
/// </param>
/// <param name="user_data_free_func">
/// function to free @user_data with when filter
///     is removed or %NULL
/// </param>
/// <return>
/// a filter identifier that can be used with
///     g_dbus_connection_remove_filter()
/// </return>

	public static uint AddFilter(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageFilterFunction filter_function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_add_filter(connection, filter_function, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Asynchronously invokes the @method_name method on the
/// @interface_name D-Bus interface on the remote object at
/// @object_path owned by @bus_name.
/// </para>
/// <para>
/// If @connection is closed then the operation will fail with
/// %G_IO_ERROR_CLOSED. If @cancellable is canceled, the operation will
/// fail with %G_IO_ERROR_CANCELLED. If @parameters contains a value
/// not compatible with the D-Bus protocol, the operation fails with
/// %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// If @reply_type is non-%NULL then the reply will be checked for having this type and an
/// error will be raised if it does not match.  Said another way, if you give a @reply_type
/// then any non-%NULL return value will be of this type. Unless it’s
/// %G_VARIANT_TYPE_UNIT, the @reply_type will be a tuple containing one or more
/// values.
/// </para>
/// <para>
/// If the @parameters #GVariant is floating, it is consumed. This allows
/// convenient &apos;inline&apos; use of g_variant_new(), e.g.:
/// <code>
///  g_dbus_connection_call (connection,
///  g_dbus_connection_call (connection,
///                          &quot;org.freedesktop.StringThings&quot;,
///                          &quot;/org/freedesktop/StringThings&quot;,
///                          &quot;org.freedesktop.StringThings&quot;,
///                          &quot;TwoStrings&quot;,
///                          g_variant_new (&quot;(ss)&quot;,
///                                         &quot;Thing One&quot;,
///                                         &quot;Thing Two&quot;),
///                          NULL,
///                          G_DBUS_CALL_FLAGS_NONE,
///                          -1,
///                          NULL,
///                          (GAsyncReadyCallback) two_strings_done,
///                          NULL);
/// </code>
/// This is an asynchronous method. When the operation is finished,
/// @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can then call
/// g_dbus_connection_call_finish() to get the result of the operation.
/// See g_dbus_connection_call_sync() for the synchronous version of this
/// function.
/// </para>
/// <para>
/// If @callback is %NULL then the D-Bus method call message will be sent with
/// the %G_DBUS_MESSAGE_FLAGS_NO_REPLY_EXPECTED flag set.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="bus_name">
/// a unique or well-known bus name or %NULL if
///     @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// path of remote object
/// </param>
/// <param name="interface_name">
/// D-Bus interface to invoke method on
/// </param>
/// <param name="method_name">
/// the name of the method to invoke
/// </param>
/// <param name="parameters">
/// a #GVariant tuple with parameters for the method
///     or %NULL if not passing parameters
/// </param>
/// <param name="reply_type">
/// the expected type of the reply (which will be a
///     tuple), or %NULL
/// </param>
/// <param name="flags">
/// flags from the #GDBusCallFlags enumeration
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request
///     is satisfied or %NULL if you don&apos;t care about the result of the
///     method invocation
/// </param>
/// <param name="user_data">
/// the data to pass to @callback
/// </param>

	public static T Call<T>(this T connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_call(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_call().
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed to g_dbus_connection_call()
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a non-floating
///     #GVariant tuple with return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously invokes the @method_name method on the
/// @interface_name D-Bus interface on the remote object at
/// @object_path owned by @bus_name.
/// </para>
/// <para>
/// If @connection is closed then the operation will fail with
/// %G_IO_ERROR_CLOSED. If @cancellable is canceled, the
/// operation will fail with %G_IO_ERROR_CANCELLED. If @parameters
/// contains a value not compatible with the D-Bus protocol, the operation
/// fails with %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// If @reply_type is non-%NULL then the reply will be checked for having
/// this type and an error will be raised if it does not match.  Said
/// another way, if you give a @reply_type then any non-%NULL return
/// value will be of this type.
/// </para>
/// <para>
/// If the @parameters #GVariant is floating, it is consumed.
/// This allows convenient &apos;inline&apos; use of g_variant_new(), e.g.:
/// <code>
///  g_dbus_connection_call_sync (connection,
///  g_dbus_connection_call_sync (connection,
///                               &quot;org.freedesktop.StringThings&quot;,
///                               &quot;/org/freedesktop/StringThings&quot;,
///                               &quot;org.freedesktop.StringThings&quot;,
///                               &quot;TwoStrings&quot;,
///                               g_variant_new (&quot;(ss)&quot;,
///                                              &quot;Thing One&quot;,
///                                              &quot;Thing Two&quot;),
///                               NULL,
///                               G_DBUS_CALL_FLAGS_NONE,
///                               -1,
///                               NULL,
///                               &amp;error);
/// </code>
/// The calling thread is blocked until a reply is received. See
/// g_dbus_connection_call() for the asynchronous version of
/// this method.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="bus_name">
/// a unique or well-known bus name or %NULL if
///     @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// path of remote object
/// </param>
/// <param name="interface_name">
/// D-Bus interface to invoke method on
/// </param>
/// <param name="method_name">
/// the name of the method to invoke
/// </param>
/// <param name="parameters">
/// a #GVariant tuple with parameters for the method
///     or %NULL if not passing parameters
/// </param>
/// <param name="reply_type">
/// the expected type of the reply, or %NULL
/// </param>
/// <param name="flags">
/// flags from the #GDBusCallFlags enumeration
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a non-floating
///     #GVariant tuple with return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallSync(this MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_connection_call() but also takes a #GUnixFDList object.
/// </para>
/// <para>
/// The file descriptors normally correspond to %G_VARIANT_TYPE_HANDLE
/// values in the body of the message. For example, if a message contains
/// two file descriptors, @fd_list would have length 2, and
/// `g_variant_new_handle (0)` and `g_variant_new_handle (1)` would appear
/// somewhere in the body of the message (not necessarily in that order!)
/// to represent the file descriptors at indexes 0 and 1 respectively.
/// </para>
/// <para>
/// When designing D-Bus APIs that are intended to be interoperable,
/// please note that non-GDBus implementations of D-Bus can usually only
/// access file descriptors if they are referenced in this way by a
/// value of type %G_VARIANT_TYPE_HANDLE in the body of the message.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="bus_name">
/// a unique or well-known bus name or %NULL if
///     @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// path of remote object
/// </param>
/// <param name="interface_name">
/// D-Bus interface to invoke method on
/// </param>
/// <param name="method_name">
/// the name of the method to invoke
/// </param>
/// <param name="parameters">
/// a #GVariant tuple with parameters for the method
///     or %NULL if not passing parameters
/// </param>
/// <param name="reply_type">
/// the expected type of the reply, or %NULL
/// </param>
/// <param name="flags">
/// flags from the #GDBusCallFlags enumeration
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="fd_list">
/// a #GUnixFDList or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is
///     satisfied or %NULL if you don&apos;t * care about the result of the
///     method invocation
/// </param>
/// <param name="user_data">
/// The data to pass to @callback.
/// </param>

	public static T CallWithUnixFdList<T>(this T connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_call_with_unix_fd_list().
/// </para>
/// <para>
/// The file descriptors normally correspond to %G_VARIANT_TYPE_HANDLE
/// values in the body of the message. For example,
/// if g_variant_get_handle() returns 5, that is intended to be a reference
/// to the file descriptor that can be accessed by
/// `g_unix_fd_list_get (*out_fd_list, 5, ...)`.
/// </para>
/// <para>
/// When designing D-Bus APIs that are intended to be interoperable,
/// please note that non-GDBus implementations of D-Bus can usually only
/// access file descriptors if they are referenced in this way by a
/// value of type %G_VARIANT_TYPE_HANDLE in the body of the message.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="out_fd_list">
/// return location for a #GUnixFDList or %NULL
/// </param>
/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed to
///     g_dbus_connection_call_with_unix_fd_list()
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a non-floating
///     #GVariant tuple with return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListFinish(this MentorLake.Gio.GDBusConnectionHandle connection, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list_finish(connection, out out_fd_list, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like g_dbus_connection_call_sync() but also takes and returns #GUnixFDList objects.
/// See g_dbus_connection_call_with_unix_fd_list() and
/// g_dbus_connection_call_with_unix_fd_list_finish() for more details.
/// </para>
/// <para>
/// This method is only available on UNIX.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="bus_name">
/// a unique or well-known bus name or %NULL
///     if @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// path of remote object
/// </param>
/// <param name="interface_name">
/// D-Bus interface to invoke method on
/// </param>
/// <param name="method_name">
/// the name of the method to invoke
/// </param>
/// <param name="parameters">
/// a #GVariant tuple with parameters for
///     the method or %NULL if not passing parameters
/// </param>
/// <param name="reply_type">
/// the expected type of the reply, or %NULL
/// </param>
/// <param name="flags">
/// flags from the #GDBusCallFlags enumeration
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="fd_list">
/// a #GUnixFDList or %NULL
/// </param>
/// <param name="out_fd_list">
/// return location for a #GUnixFDList or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %NULL if @error is set. Otherwise a non-floating
///     #GVariant tuple with return values. Free with g_variant_unref().
/// </return>

	public static MentorLake.GLib.GVariantHandle CallWithUnixFdListSync(this MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, MentorLake.GLib.GVariantHandle parameters, MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, MentorLake.Gio.GUnixFDListHandle fd_list, out MentorLake.Gio.GUnixFDListHandle out_fd_list, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_call_with_unix_fd_list_sync(connection, bus_name, object_path, interface_name, method_name, parameters, reply_type, flags, timeout_msec, fd_list, out out_fd_list, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Closes @connection. Note that this never causes the process to
/// exit (this might only happen if the other end of a shared message
/// bus connection disconnects, see #GDBusConnection:exit-on-close).
/// </para>
/// <para>
/// Once the connection is closed, operations such as sending a message
/// will return with the error %G_IO_ERROR_CLOSED. Closing a connection
/// will not automatically flush the connection so queued messages may
/// be lost. Use g_dbus_connection_flush() if you need such guarantees.
/// </para>
/// <para>
/// If @connection is already closed, this method fails with
/// %G_IO_ERROR_CLOSED.
/// </para>
/// <para>
/// When @connection has been closed, the #GDBusConnection::closed
/// signal is emitted in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread that @connection was constructed in.
/// </para>
/// <para>
/// This is an asynchronous method. When the operation is finished,
/// @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can
/// then call g_dbus_connection_close_finish() to get the result of the
/// operation. See g_dbus_connection_close_sync() for the synchronous
/// version.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request is
///     satisfied or %NULL if you don&apos;t care about the result
/// </param>
/// <param name="user_data">
/// The data to pass to @callback
/// </param>

	public static T Close<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_close(connection, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_close().
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed
///     to g_dbus_connection_close()
/// </param>
/// <return>
/// %TRUE if the operation succeeded, %FALSE if @error is set
/// </return>

	public static bool CloseFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_close_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously closes @connection. The calling thread is blocked
/// until this is done. See g_dbus_connection_close() for the
/// asynchronous version of this method and more details about what it
/// does.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if the operation succeeded, %FALSE if @error is set
/// </return>

	public static bool CloseSync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_close_sync(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Emits a signal.
/// </para>
/// <para>
/// If the parameters GVariant is floating, it is consumed.
/// </para>
/// <para>
/// This can only fail if @parameters is not compatible with the D-Bus protocol
/// (%G_IO_ERROR_INVALID_ARGUMENT), or if @connection has been closed
/// (%G_IO_ERROR_CLOSED).
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="destination_bus_name">
/// the unique bus name for the destination
///     for the signal or %NULL to emit to all listeners
/// </param>
/// <param name="object_path">
/// path of remote object
/// </param>
/// <param name="interface_name">
/// D-Bus interface to emit a signal on
/// </param>
/// <param name="signal_name">
/// the name of the signal to emit
/// </param>
/// <param name="parameters">
/// a #GVariant tuple with parameters for the signal
///              or %NULL if not passing parameters
/// </param>
/// <return>
/// %TRUE unless @error is set
/// </return>

	public static bool EmitSignal(this MentorLake.Gio.GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, MentorLake.GLib.GVariantHandle parameters)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_emit_signal(connection, destination_bus_name, object_path, interface_name, signal_name, parameters, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Exports @action_group on @connection at @object_path.
/// </para>
/// <para>
/// The implemented D-Bus API should be considered private.  It is
/// subject to change in the future.
/// </para>
/// <para>
/// A given object path can only have one action group exported on it.
/// If this constraint is violated, the export will fail and 0 will be
/// returned (with @error set accordingly).
/// </para>
/// <para>
/// You can unexport the action group using
/// [method@Gio.DBusConnection.unexport_action_group] with the return value of
/// this function.
/// </para>
/// <para>
/// The thread default main context is taken at the time of this call.
/// All incoming action activations and state change requests are
/// reported from this context.  Any changes on the action group that
/// cause it to emit signals must also come from this same context.
/// Since incoming action activations and state change requests are
/// rather likely to cause changes on the action group, this effectively
/// limits a given action group to being exported from only one main
/// context.
/// </para>
/// </summary>

/// <param name="connection">
/// the D-Bus connection
/// </param>
/// <param name="object_path">
/// a D-Bus object path
/// </param>
/// <param name="action_group">
/// an action group
/// </param>
/// <return>
/// the ID of the export (never zero), or 0 in case of failure
/// </return>

	public static uint ExportActionGroup(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GActionGroupHandle action_group)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_export_action_group(connection, object_path, action_group, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Exports @menu on @connection at @object_path.
/// </para>
/// <para>
/// The implemented D-Bus API should be considered private.
/// It is subject to change in the future.
/// </para>
/// <para>
/// An object path can only have one menu model exported on it. If this
/// constraint is violated, the export will fail and 0 will be
/// returned (with @error set accordingly).
/// </para>
/// <para>
/// Exporting menus with sections containing more than
/// %G_MENU_EXPORTER_MAX_SECTION_SIZE items is not supported and results in
/// undefined behavior.
/// </para>
/// <para>
/// You can unexport the menu model using
/// g_dbus_connection_unexport_menu_model() with the return value of
/// this function.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="object_path">
/// a D-Bus object path
/// </param>
/// <param name="menu">
/// a #GMenuModel
/// </param>
/// <return>
/// the ID of the export (never zero), or 0 in case of failure
/// </return>

	public static uint ExportMenuModel(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GMenuModelHandle menu)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_export_menu_model(connection, object_path, menu, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously flushes @connection, that is, writes all queued
/// outgoing message to the transport and then flushes the transport
/// (using g_output_stream_flush_async()). This is useful in programs
/// that wants to emit a D-Bus signal and then exit immediately. Without
/// flushing the connection, there is no guaranteed that the message has
/// been sent to the networking buffers in the OS kernel.
/// </para>
/// <para>
/// This is an asynchronous method. When the operation is finished,
/// @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can
/// then call g_dbus_connection_flush_finish() to get the result of the
/// operation. See g_dbus_connection_flush_sync() for the synchronous
/// version.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the
///     request is satisfied or %NULL if you don&apos;t care about the result
/// </param>
/// <param name="user_data">
/// The data to pass to @callback
/// </param>

	public static T Flush<T>(this T connection, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_flush(connection, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_flush().
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed
///     to g_dbus_connection_flush()
/// </param>
/// <return>
/// %TRUE if the operation succeeded, %FALSE if @error is set
/// </return>

	public static bool FlushFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_flush_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously flushes @connection. The calling thread is blocked
/// until this is done. See g_dbus_connection_flush() for the
/// asynchronous version of this method and more details about what it
/// does.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if the operation succeeded, %FALSE if @error is set
/// </return>

	public static bool FlushSync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_flush_sync(connection, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the capabilities negotiated with the remote peer
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// zero or more flags from the #GDBusCapabilityFlags enumeration
/// </return>

	public static MentorLake.Gio.GDBusCapabilityFlags GetCapabilities(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_capabilities(connection);
	}

/// <summary>
/// <para>
/// Gets whether the process is terminated when @connection is
/// closed by the remote peer. See
/// #GDBusConnection:exit-on-close for more details.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// whether the process is terminated when @connection is
///     closed by the remote peer
/// </return>

	public static bool GetExitOnClose(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_exit_on_close(connection);
	}

/// <summary>
/// <para>
/// Gets the flags used to construct this connection
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// zero or more flags from the #GDBusConnectionFlags enumeration
/// </return>

	public static MentorLake.Gio.GDBusConnectionFlags GetFlags(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_flags(connection);
	}

/// <summary>
/// <para>
/// The GUID of the peer performing the role of server when
/// authenticating. See #GDBusConnection:guid for more details.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// The GUID. Do not free this string, it is owned by
///     @connection.
/// </return>

	public static string GetGuid(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_guid(connection);
	}

/// <summary>
/// <para>
/// Retrieves the last serial number assigned to a #GDBusMessage on
/// the current thread. This includes messages sent via both low-level
/// API such as g_dbus_connection_send_message() as well as
/// high-level API such as g_dbus_connection_emit_signal(),
/// g_dbus_connection_call() or g_dbus_proxy_call().
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// the last used serial or zero when no message has been sent
///     within the current thread
/// </return>

	public static uint GetLastSerial(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_last_serial(connection);
	}

/// <summary>
/// <para>
/// Gets the credentials of the authenticated peer. This will always
/// return %NULL unless @connection acted as a server
/// (e.g. %G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_SERVER was passed)
/// when set up and the client passed credentials as part of the
/// authentication process.
/// </para>
/// <para>
/// In a message bus setup, the message bus is always the server and
/// each application is a client. So this method will always return
/// %NULL for message bus clients.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// a #GCredentials or %NULL if not
///     available. Do not free this object, it is owned by @connection.
/// </return>

	public static MentorLake.Gio.GCredentialsHandle GetPeerCredentials(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_peer_credentials(connection);
	}

/// <summary>
/// <para>
/// Gets the underlying stream used for IO.
/// </para>
/// <para>
/// While the #GDBusConnection is active, it will interact with this
/// stream from a worker thread, so it is not safe to interact with
/// the stream directly.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// the stream used for IO
/// </return>

	public static MentorLake.Gio.GIOStreamHandle GetStream(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_stream(connection);
	}

/// <summary>
/// <para>
/// Gets the unique name of @connection as assigned by the message
/// bus. This can also be used to figure out if @connection is a
/// message bus connection.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// the unique name or %NULL if @connection is not a message
///     bus connection. Do not free this string, it is owned by
///     @connection.
/// </return>

	public static string GetUniqueName(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_get_unique_name(connection);
	}

/// <summary>
/// <para>
/// Gets whether @connection is closed.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <return>
/// %TRUE if the connection is closed, %FALSE otherwise
/// </return>

	public static bool IsClosed(this MentorLake.Gio.GDBusConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_is_closed(connection);
	}

/// <summary>
/// <para>
/// Registers callbacks for exported objects at @object_path with the
/// D-Bus interface that is described in @interface_info.
/// </para>
/// <para>
/// Calls to functions in @vtable (and @user_data_free_func) will happen
/// in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from.
/// </para>
/// <para>
/// Note that all #GVariant values passed to functions in @vtable will match
/// the signature given in @interface_info - if a remote caller passes
/// incorrect values, the `org.freedesktop.DBus.Error.InvalidArgs`
/// is returned to the remote caller.
/// </para>
/// <para>
/// Additionally, if the remote caller attempts to invoke methods or
/// access properties not mentioned in @interface_info the
/// `org.freedesktop.DBus.Error.UnknownMethod` resp.
/// `org.freedesktop.DBus.Error.InvalidArgs` errors
/// are returned to the caller.
/// </para>
/// <para>
/// It is considered a programming error if the
/// #GDBusInterfaceGetPropertyFunc function in @vtable returns a
/// #GVariant of incorrect type.
/// </para>
/// <para>
/// If an existing callback is already registered at @object_path and
/// @interface_name, then @error is set to %G_IO_ERROR_EXISTS.
/// </para>
/// <para>
/// GDBus automatically implements the standard D-Bus interfaces
/// org.freedesktop.DBus.Properties, org.freedesktop.DBus.Introspectable
/// and org.freedesktop.Peer, so you don&apos;t have to implement those for the
/// objects you export. You can implement org.freedesktop.DBus.Properties
/// yourself, e.g. to handle getting and setting of properties asynchronously.
/// </para>
/// <para>
/// Note that the reference count on @interface_info will be
/// incremented by 1 (unless allocated statically, e.g. if the
/// reference count is -1, see g_dbus_interface_info_ref()) for as long
/// as the object is exported. Also note that @vtable will be copied.
/// </para>
/// <para>
/// See this [server][gdbus-server] for an example of how to use this method.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="object_path">
/// the object path to register at
/// </param>
/// <param name="interface_info">
/// introspection data for the interface
/// </param>
/// <param name="vtable">
/// a #GDBusInterfaceVTable to call into or %NULL
/// </param>
/// <param name="user_data">
/// data to pass to functions in @vtable
/// </param>
/// <param name="user_data_free_func">
/// function to call when the object path is unregistered
/// </param>
/// <return>
/// 0 if @error is set, otherwise a registration id (never 0)
///     that can be used with g_dbus_connection_unregister_object()
/// </return>

	public static uint RegisterObject(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, MentorLake.Gio.GDBusInterfaceVTableHandle vtable, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_object(connection, object_path, interface_info, vtable, user_data, user_data_free_func, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Version of g_dbus_connection_register_object() using closures instead of a
/// #GDBusInterfaceVTable for easier binding in other languages.
/// </para>
/// <para>
/// Note that the reference counting semantics of the function wrapped by
/// @method_call_closure are the same as those of
/// [callback@Gio.DBusInterfaceMethodCallFunc]: ownership of a reference to the
/// [class@Gio.DBusMethodInvocation] is transferred to the function.
/// </para>
/// </summary>

/// <param name="connection">
/// A #GDBusConnection.
/// </param>
/// <param name="object_path">
/// The object path to register at.
/// </param>
/// <param name="interface_info">
/// Introspection data for the interface.
/// </param>
/// <param name="method_call_closure">
/// #GClosure for handling incoming method calls.
/// </param>
/// <param name="get_property_closure">
/// #GClosure for getting a property.
/// </param>
/// <param name="set_property_closure">
/// #GClosure for setting a property.
/// </param>
/// <return>
/// 0 if @error is set, otherwise a registration ID (never 0)
/// that can be used with g_dbus_connection_unregister_object() .
/// </return>

	public static uint RegisterObjectWithClosures(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, MentorLake.GObject.GClosureHandle method_call_closure, MentorLake.GObject.GClosureHandle get_property_closure, MentorLake.GObject.GClosureHandle set_property_closure)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_object_with_closures(connection, object_path, interface_info, method_call_closure, get_property_closure, set_property_closure, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Registers a whole subtree of dynamic objects.
/// </para>
/// <para>
/// The @enumerate and @introspection functions in @vtable are used to
/// convey, to remote callers, what nodes exist in the subtree rooted
/// by @object_path.
/// </para>
/// <para>
/// When handling remote calls into any node in the subtree, first the
/// @enumerate function is used to check if the node exists. If the node exists
/// or the %G_DBUS_SUBTREE_FLAGS_DISPATCH_TO_UNENUMERATED_NODES flag is set
/// the @introspection function is used to check if the node supports the
/// requested method. If so, the @dispatch function is used to determine
/// where to dispatch the call. The collected #GDBusInterfaceVTable and
/// #gpointer will be used to call into the interface vtable for processing
/// the request.
/// </para>
/// <para>
/// All calls into user-provided code will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from.
/// </para>
/// <para>
/// If an existing subtree is already registered at @object_path or
/// then @error is set to %G_IO_ERROR_EXISTS.
/// </para>
/// <para>
/// Note that it is valid to register regular objects (using
/// g_dbus_connection_register_object()) in a subtree registered with
/// g_dbus_connection_register_subtree() - if so, the subtree handler
/// is tried as the last resort. One way to think about a subtree
/// handler is to consider it a fallback handler for object paths not
/// registered via g_dbus_connection_register_object() or other bindings.
/// </para>
/// <para>
/// Note that @vtable will be copied so you cannot change it after
/// registration.
/// </para>
/// <para>
/// See this [server][gdbus-subtree-server] for an example of how to use
/// this method.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="object_path">
/// the object path to register the subtree at
/// </param>
/// <param name="vtable">
/// a #GDBusSubtreeVTable to enumerate, introspect and
///     dispatch nodes in the subtree
/// </param>
/// <param name="flags">
/// flags used to fine tune the behavior of the subtree
/// </param>
/// <param name="user_data">
/// data to pass to functions in @vtable
/// </param>
/// <param name="user_data_free_func">
/// function to call when the subtree is unregistered
/// </param>
/// <return>
/// 0 if @error is set, otherwise a subtree registration ID (never 0)
/// that can be used with g_dbus_connection_unregister_subtree()
/// </return>

	public static uint RegisterSubtree(this MentorLake.Gio.GDBusConnectionHandle connection, string object_path, MentorLake.Gio.GDBusSubtreeVTableHandle vtable, MentorLake.Gio.GDBusSubtreeFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_register_subtree(connection, object_path, vtable, flags, user_data, user_data_free_func, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes a filter.
/// </para>
/// <para>
/// Note that since filters run in a different thread, there is a race
/// condition where it is possible that the filter will be running even
/// after calling g_dbus_connection_remove_filter(), so you cannot just
/// free data that the filter might be using. Instead, you should pass
/// a #GDestroyNotify to g_dbus_connection_add_filter(), which will be
/// called when it is guaranteed that the data is no longer needed.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="filter_id">
/// an identifier obtained from g_dbus_connection_add_filter()
/// </param>

	public static T RemoveFilter<T>(this T connection, uint filter_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_remove_filter(connection, filter_id);
		return connection;
	}

/// <summary>
/// <para>
/// Asynchronously sends @message to the peer represented by @connection.
/// </para>
/// <para>
/// Unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag, the serial number
/// will be assigned by @connection and set on @message via
/// g_dbus_message_set_serial(). If @out_serial is not %NULL, then the
/// serial number used will be written to this location prior to
/// submitting the message to the underlying transport. While it has a `volatile`
/// qualifier, this is a historical artifact and the argument passed to it should
/// not be `volatile`.
/// </para>
/// <para>
/// If @connection is closed then the operation will fail with
/// %G_IO_ERROR_CLOSED. If @message is not well-formed,
/// the operation fails with %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// See this [server][gdbus-server] and [client][gdbus-unix-fd-client]
/// for an example of how to use this low-level API to send and receive
/// UNIX file descriptors.
/// </para>
/// <para>
/// Note that @message must be unlocked, unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="message">
/// a #GDBusMessage
/// </param>
/// <param name="flags">
/// flags affecting how the message is sent
/// </param>
/// <param name="out_serial">
/// return location for serial number assigned
///     to @message when sending it or %NULL
/// </param>
/// <return>
/// %TRUE if the message was well-formed and queued for
///     transmission, %FALSE if @error is set
/// </return>

	public static bool SendMessage(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, out uint out_serial)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message(connection, message, flags, out out_serial, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously sends @message to the peer represented by @connection.
/// </para>
/// <para>
/// Unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag, the serial number
/// will be assigned by @connection and set on @message via
/// g_dbus_message_set_serial(). If @out_serial is not %NULL, then the
/// serial number used will be written to this location prior to
/// submitting the message to the underlying transport. While it has a `volatile`
/// qualifier, this is a historical artifact and the argument passed to it should
/// not be `volatile`.
/// </para>
/// <para>
/// If @connection is closed then the operation will fail with
/// %G_IO_ERROR_CLOSED. If @cancellable is canceled, the operation will
/// fail with %G_IO_ERROR_CANCELLED. If @message is not well-formed,
/// the operation fails with %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// This is an asynchronous method. When the operation is finished, @callback
/// will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from. You can then call
/// g_dbus_connection_send_message_with_reply_finish() to get the result of the operation.
/// See g_dbus_connection_send_message_with_reply_sync() for the synchronous version.
/// </para>
/// <para>
/// Note that @message must be unlocked, unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag.
/// </para>
/// <para>
/// See this [server][gdbus-server] and [client][gdbus-unix-fd-client]
/// for an example of how to use this low-level API to send and receive
/// UNIX file descriptors.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="message">
/// a #GDBusMessage
/// </param>
/// <param name="flags">
/// flags affecting how the message is sent
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="out_serial">
/// return location for serial number assigned
///     to @message when sending it or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call when the request
///     is satisfied or %NULL if you don&apos;t care about the result
/// </param>
/// <param name="user_data">
/// The data to pass to @callback
/// </param>

	public static T SendMessageWithReply<T>(this T connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply(connection, message, flags, timeout_msec, out out_serial, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Finishes an operation started with g_dbus_connection_send_message_with_reply().
/// </para>
/// <para>
/// Note that @error is only set if a local in-process error
/// occurred. That is to say that the returned #GDBusMessage object may
/// be of type %G_DBUS_MESSAGE_TYPE_ERROR. Use
/// g_dbus_message_to_gerror() to transcode this to a #GError.
/// </para>
/// <para>
/// See this [server][gdbus-server] and [client][gdbus-unix-fd-client]
/// for an example of how to use this low-level API to send and receive
/// UNIX file descriptors.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="res">
/// a #GAsyncResult obtained from the #GAsyncReadyCallback passed to
///     g_dbus_connection_send_message_with_reply()
/// </param>
/// <return>
/// a locked #GDBusMessage or %NULL if @error is set
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle SendMessageWithReplyFinish(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply_finish(connection, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously sends @message to the peer represented by @connection
/// and blocks the calling thread until a reply is received or the
/// timeout is reached. See g_dbus_connection_send_message_with_reply()
/// for the asynchronous version of this method.
/// </para>
/// <para>
/// Unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag, the serial number
/// will be assigned by @connection and set on @message via
/// g_dbus_message_set_serial(). If @out_serial is not %NULL, then the
/// serial number used will be written to this location prior to
/// submitting the message to the underlying transport. While it has a `volatile`
/// qualifier, this is a historical artifact and the argument passed to it should
/// not be `volatile`.
/// </para>
/// <para>
/// If @connection is closed then the operation will fail with
/// %G_IO_ERROR_CLOSED. If @cancellable is canceled, the operation will
/// fail with %G_IO_ERROR_CANCELLED. If @message is not well-formed,
/// the operation fails with %G_IO_ERROR_INVALID_ARGUMENT.
/// </para>
/// <para>
/// Note that @error is only set if a local in-process error
/// occurred. That is to say that the returned #GDBusMessage object may
/// be of type %G_DBUS_MESSAGE_TYPE_ERROR. Use
/// g_dbus_message_to_gerror() to transcode this to a #GError.
/// </para>
/// <para>
/// See this [server][gdbus-server] and [client][gdbus-unix-fd-client]
/// for an example of how to use this low-level API to send and receive
/// UNIX file descriptors.
/// </para>
/// <para>
/// Note that @message must be unlocked, unless @flags contain the
/// %G_DBUS_SEND_MESSAGE_FLAGS_PRESERVE_SERIAL flag.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="message">
/// a #GDBusMessage
/// </param>
/// <param name="flags">
/// flags affecting how the message is sent.
/// </param>
/// <param name="timeout_msec">
/// the timeout in milliseconds, -1 to use the default
///     timeout or %G_MAXINT for no timeout
/// </param>
/// <param name="out_serial">
/// return location for serial number
///     assigned to @message when sending it or %NULL
/// </param>
/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// a locked #GDBusMessage that is the reply
///     to @message or %NULL if @error is set
/// </return>

	public static MentorLake.Gio.GDBusMessageHandle SendMessageWithReplySync(this MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		var externCallResult = GDBusConnectionHandleExterns.g_dbus_connection_send_message_with_reply_sync(connection, message, flags, timeout_msec, out out_serial, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets whether the process should be terminated when @connection is
/// closed by the remote peer. See #GDBusConnection:exit-on-close for
/// more details.
/// </para>
/// <para>
/// Note that this function should be used with care. Most modern UNIX
/// desktops tie the notion of a user session with the session bus, and expect
/// all of a user&apos;s applications to quit when their bus connection goes away.
/// If you are setting @exit_on_close to %FALSE for the shared session
/// bus connection, you should make sure that your application exits
/// when the user session ends.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="exit_on_close">
/// whether the process should be terminated
///     when @connection is closed by the remote peer
/// </param>

	public static T SetExitOnClose<T>(this T connection, bool exit_on_close) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_set_exit_on_close(connection, exit_on_close);
		return connection;
	}

/// <summary>
/// <para>
/// Subscribes to signals on @connection and invokes @callback whenever
/// the signal is received. Note that @callback will be invoked in the
/// [thread-default main context][g-main-context-push-thread-default]
/// of the thread you are calling this method from.
/// </para>
/// <para>
/// If @connection is not a message bus connection, @sender must be
/// %NULL.
/// </para>
/// <para>
/// If @sender is a well-known name note that @callback is invoked with
/// the unique name for the owner of @sender, not the well-known name
/// as one would expect. This is because the message bus rewrites the
/// name. As such, to avoid certain race conditions, users should be
/// tracking the name owner of the well-known name and use that when
/// processing the received signal.
/// </para>
/// <para>
/// If one of %G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_NAMESPACE or
/// %G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_PATH are given, @arg0 is
/// interpreted as part of a namespace or path.  The first argument
/// of a signal is matched against that part as specified by D-Bus.
/// </para>
/// <para>
/// If @user_data_free_func is non-%NULL, it will be called (in the
/// thread-default main context of the thread you are calling this
/// method from) at some point after @user_data is no longer
/// needed. (It is not guaranteed to be called synchronously when the
/// signal is unsubscribed from, and may be called after @connection
/// has been destroyed.)
/// </para>
/// <para>
/// As @callback is potentially invoked in a different thread from where it’s
/// emitted, it’s possible for this to happen after
/// g_dbus_connection_signal_unsubscribe() has been called in another thread.
/// Due to this, @user_data should have a strong reference which is freed with
/// @user_data_free_func, rather than pointing to data whose lifecycle is tied
/// to the signal subscription. For example, if a #GObject is used to store the
/// subscription ID from g_dbus_connection_signal_subscribe(), a strong reference
/// to that #GObject must be passed to @user_data, and g_object_unref() passed to
/// @user_data_free_func. You are responsible for breaking the resulting
/// reference count cycle by explicitly unsubscribing from the signal when
/// dropping the last external reference to the #GObject. Alternatively, a weak
/// reference may be used.
/// </para>
/// <para>
/// It is guaranteed that if you unsubscribe from a signal using
/// g_dbus_connection_signal_unsubscribe() from the same thread which made the
/// corresponding g_dbus_connection_signal_subscribe() call, @callback will not
/// be invoked after g_dbus_connection_signal_unsubscribe() returns.
/// </para>
/// <para>
/// The returned subscription identifier is an opaque value which is guaranteed
/// to never be zero.
/// </para>
/// <para>
/// This function can never fail.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="sender">
/// sender name to match on (unique or well-known name)
///     or %NULL to listen from all senders
/// </param>
/// <param name="interface_name">
/// D-Bus interface name to match on or %NULL to
///     match on all interfaces
/// </param>
/// <param name="member">
/// D-Bus signal name to match on or %NULL to match on
///     all signals
/// </param>
/// <param name="object_path">
/// object path to match on or %NULL to match on
///     all object paths
/// </param>
/// <param name="arg0">
/// contents of first string argument to match on or %NULL
///     to match on all kinds of arguments
/// </param>
/// <param name="flags">
/// #GDBusSignalFlags describing how arg0 is used in subscribing to the
///     signal
/// </param>
/// <param name="callback">
/// callback to invoke when there is a signal matching the requested data
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="user_data_free_func">
/// function to free @user_data with when
///     subscription is removed or %NULL
/// </param>
/// <return>
/// a subscription identifier that can be used with g_dbus_connection_signal_unsubscribe()
/// </return>

	public static uint SignalSubscribe(this MentorLake.Gio.GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, MentorLake.Gio.GDBusSignalFlags flags, MentorLake.Gio.GDBusSignalCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_signal_subscribe(connection, sender, interface_name, member, object_path, arg0, flags, callback, user_data, user_data_free_func);
	}

/// <summary>
/// <para>
/// Unsubscribes from signals.
/// </para>
/// <para>
/// Note that there may still be D-Bus traffic to process (relating to this
/// signal subscription) in the current thread-default #GMainContext after this
/// function has returned. You should continue to iterate the #GMainContext
/// until the #GDestroyNotify function passed to
/// g_dbus_connection_signal_subscribe() is called, in order to avoid memory
/// leaks through callbacks queued on the #GMainContext after it’s stopped being
/// iterated.
/// Alternatively, any idle source with a priority lower than %G_PRIORITY_DEFAULT
/// that was scheduled after unsubscription, also indicates that all resources
/// of this subscription are released.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="subscription_id">
/// a subscription id obtained from
///     g_dbus_connection_signal_subscribe()
/// </param>

	public static T SignalUnsubscribe<T>(this T connection, uint subscription_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_signal_unsubscribe(connection, subscription_id);
		return connection;
	}

/// <summary>
/// <para>
/// If @connection was created with
/// %G_DBUS_CONNECTION_FLAGS_DELAY_MESSAGE_PROCESSING, this method
/// starts processing messages. Does nothing on if @connection wasn&apos;t
/// created with this flag or if the method has already been called.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>

	public static T StartMessageProcessing<T>(this T connection) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_start_message_processing(connection);
		return connection;
	}

/// <summary>
/// <para>
/// Reverses the effect of a previous call to
/// [method@Gio.DBusConnection.export_action_group].
/// </para>
/// <para>
/// It is an error to call this function with an ID that wasn’t returned from
/// [method@Gio.DBusConnection.export_action_group] or to call it with the same
/// ID more than once.
/// </para>
/// </summary>

/// <param name="connection">
/// the D-Bus connection
/// </param>
/// <param name="export_id">
/// the ID from [method@Gio.DBusConnection.export_action_group]
/// </param>

	public static T UnexportActionGroup<T>(this T connection, uint export_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_unexport_action_group(connection, export_id);
		return connection;
	}

/// <summary>
/// <para>
/// Reverses the effect of a previous call to
/// g_dbus_connection_export_menu_model().
/// </para>
/// <para>
/// It is an error to call this function with an ID that wasn&apos;t returned
/// from g_dbus_connection_export_menu_model() or to call it with the
/// same ID more than once.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="export_id">
/// the ID from g_dbus_connection_export_menu_model()
/// </param>

	public static T UnexportMenuModel<T>(this T connection, uint export_id) where T : GDBusConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		GDBusConnectionHandleExterns.g_dbus_connection_unexport_menu_model(connection, export_id);
		return connection;
	}

/// <summary>
/// <para>
/// Unregisters an object.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="registration_id">
/// a registration id obtained from
///     g_dbus_connection_register_object()
/// </param>
/// <return>
/// %TRUE if the object was unregistered, %FALSE otherwise
/// </return>

	public static bool UnregisterObject(this MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_unregister_object(connection, registration_id);
	}

/// <summary>
/// <para>
/// Unregisters a subtree.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="registration_id">
/// a subtree registration id obtained from
///     g_dbus_connection_register_subtree()
/// </param>
/// <return>
/// %TRUE if the subtree was unregistered, %FALSE otherwise
/// </return>

	public static bool UnregisterSubtree(this MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GDBusConnectionHandle)");
		return GDBusConnectionHandleExterns.g_dbus_connection_unregister_subtree(connection, registration_id);
	}

}

internal class GDBusConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_for_address_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_for_address_sync(string address, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_connection_new_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_add_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, MentorLake.Gio.GDBusMessageFilterFunction filter_function, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_call_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_with_unix_fd_list_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_connection_call_with_unix_fd_list_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle reply_type, MentorLake.Gio.GDBusCallFlags flags, int timeout_msec, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] out MentorLake.Gio.GUnixFDListHandle out_fd_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_close_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_emit_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_export_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_export_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle menu, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_flush([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_flush_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_flush_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusCapabilityFlags g_dbus_connection_get_capabilities([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_get_exit_on_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionFlags g_dbus_connection_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_connection_get_guid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_get_last_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCredentialsHandle>))]
	internal static extern MentorLake.Gio.GCredentialsHandle g_dbus_connection_get_peer_credentials([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_dbus_connection_get_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_connection_get_unique_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_is_closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceVTableHandle>))] MentorLake.Gio.GDBusInterfaceVTableHandle vtable, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_object_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusInterfaceInfoHandle>))] MentorLake.Gio.GDBusInterfaceInfoHandle interface_info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle method_call_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle get_property_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle set_property_closure, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_register_subtree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string object_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusSubtreeVTableHandle>))] MentorLake.Gio.GDBusSubtreeVTableHandle vtable, MentorLake.Gio.GDBusSubtreeFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_remove_filter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint filter_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_send_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, out uint out_serial, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_send_message_with_reply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_connection_send_message_with_reply_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_connection_send_message_with_reply_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMessageHandle>))] MentorLake.Gio.GDBusMessageHandle message, MentorLake.Gio.GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_set_exit_on_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, bool exit_on_close);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_dbus_connection_signal_subscribe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, MentorLake.Gio.GDBusSignalFlags flags, MentorLake.Gio.GDBusSignalCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_signal_unsubscribe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint subscription_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_start_message_processing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_unexport_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint export_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_unexport_menu_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint export_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_unregister_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_connection_unregister_subtree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, uint registration_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, string guid, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_connection_new_for_address(string address, MentorLake.Gio.GDBusConnectionFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusAuthObserverHandle>))] MentorLake.Gio.GDBusAuthObserverHandle observer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}

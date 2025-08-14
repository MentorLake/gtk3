namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSocketConnection` is a [class@Gio.IOStream] for a connected socket. They
/// can be created either by [class@Gio.SocketClient] when connecting to a host,
/// or by [class@Gio.SocketListener] when accepting a new client.
/// </para>
/// <para>
/// The type of the `GSocketConnection` object returned from these calls
/// depends on the type of the underlying socket that is in use. For
/// instance, for a TCP/IP connection it will be a [class@Gio.TcpConnection].
/// </para>
/// <para>
/// Choosing what type of object to construct is done with the socket
/// connection factory, and it is possible for third parties to register
/// custom socket connection types for specific combination of socket
/// family/type/protocol using [func@Gio.SocketConnection.factory_register_type].
/// </para>
/// <para>
/// To close a `GSocketConnection`, use [method@Gio.IOStream.close]. Closing both
/// substreams of the [class@Gio.IOStream] separately will not close the
/// underlying [class@Gio.Socket].
/// </para>
/// </summary>

public class GSocketConnectionHandle : GIOStreamHandle
{
/// <summary>
/// <para>
/// Looks up the #GType to be used when creating socket connections on
/// sockets with the specified @family, @type and @protocol_id.
/// </para>
/// <para>
/// If no type is registered, the #GSocketConnection base type is returned.
/// </para>
/// </summary>

/// <param name="family">
/// a #GSocketFamily
/// </param>
/// <param name="type">
/// a #GSocketType
/// </param>
/// <param name="protocol_id">
/// a protocol id
/// </param>
/// <return>
/// a #GType
/// </return>

	public static MentorLake.GObject.GType FactoryLookupType(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol_id)
	{
		return GSocketConnectionHandleExterns.g_socket_connection_factory_lookup_type(family, type, protocol_id);
	}

/// <summary>
/// <para>
/// Looks up the #GType to be used when creating socket connections on
/// sockets with the specified @family, @type and @protocol.
/// </para>
/// <para>
/// If no type is registered, the #GSocketConnection base type is returned.
/// </para>
/// </summary>

/// <param name="g_type">
/// a #GType, inheriting from %G_TYPE_SOCKET_CONNECTION
/// </param>
/// <param name="family">
/// a #GSocketFamily
/// </param>
/// <param name="type">
/// a #GSocketType
/// </param>
/// <param name="protocol">
/// a protocol id
/// </param>

	public static void FactoryRegisterType(MentorLake.GObject.GType g_type, MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol)
	{
		GSocketConnectionHandleExterns.g_socket_connection_factory_register_type(g_type, family, type, protocol);
	}

}

public static class GSocketConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Connect @connection to the specified remote address.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <param name="address">
/// a #GSocketAddress specifying the remote address.
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if the connection succeeded, %FALSE on error
/// </return>

	public static bool Connect(this MentorLake.Gio.GSocketConnectionHandle connection, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_connect(connection, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously connect @connection to the specified remote address.
/// </para>
/// <para>
/// This clears the #GSocket:blocking flag on @connection's underlying
/// socket if it is currently set.
/// </para>
/// <para>
/// If #GSocket:timeout is set, the operation will time out and return
/// %G_IO_ERROR_TIMED_OUT after that period. Otherwise, it will continue
/// indefinitely until operating system timeouts (if any) are hit.
/// </para>
/// <para>
/// Use g_socket_connection_connect_finish() to retrieve the result.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <param name="address">
/// a #GSocketAddress specifying the remote address.
/// </param>
/// <param name="cancellable">
/// a %GCancellable or %NULL
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
/// </param>
/// <param name="user_data">
/// user data for the callback
/// </param>

	public static T ConnectAsync<T>(this T connection, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketConnectionHandle
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		GSocketConnectionHandleExterns.g_socket_connection_connect_async(connection, address, cancellable, callback, user_data);
		return connection;
	}

/// <summary>
/// <para>
/// Gets the result of a g_socket_connection_connect_async() call.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <param name="result">
/// the #GAsyncResult
/// </param>
/// <return>
/// %TRUE if the connection succeeded, %FALSE on error
/// </return>

	public static bool ConnectFinish(this MentorLake.Gio.GSocketConnectionHandle connection, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_connect_finish(connection, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Try to get the local address of a socket connection.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <return>
/// a #GSocketAddress or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_get_local_address(connection, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Try to get the remote address of a socket connection.
/// </para>
/// <para>
/// Since GLib 2.40, when used with g_socket_client_connect() or
/// g_socket_client_connect_async(), during emission of
/// %G_SOCKET_CLIENT_CONNECTING, this function will return the remote
/// address that will be used for the connection.  This allows
/// applications to print e.g. "Connecting to example.com
/// (10.42.77.3)...".
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <return>
/// a #GSocketAddress or %NULL on error.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		var externCallResult = GSocketConnectionHandleExterns.g_socket_connection_get_remote_address(connection, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the underlying #GSocket object of the connection.
/// This can be useful if you want to do something unusual on it
/// not supported by the #GSocketConnection APIs.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <return>
/// a #GSocket or %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketHandle GetSocket(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		return GSocketConnectionHandleExterns.g_socket_connection_get_socket(connection);
	}

/// <summary>
/// <para>
/// Checks if @connection is connected. This is equivalent to calling
/// g_socket_is_connected() on @connection's underlying #GSocket.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GSocketConnection
/// </param>
/// <return>
/// whether @connection is connected
/// </return>

	public static bool IsConnected(this MentorLake.Gio.GSocketConnectionHandle connection)
	{
		if (connection.IsInvalid) throw new Exception("Invalid handle (GSocketConnectionHandle)");
		return GSocketConnectionHandleExterns.g_socket_connection_is_connected(connection);
	}

}

internal class GSocketConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_connection_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_connection_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_connection_get_remote_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle g_socket_connection_get_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_connection_is_connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))] MentorLake.Gio.GSocketConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_socket_connection_factory_lookup_type(MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_connection_factory_register_type(MentorLake.GObject.GType g_type, MentorLake.Gio.GSocketFamily family, MentorLake.Gio.GSocketType type, int protocol);

}

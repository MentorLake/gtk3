namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSocketClient` is a lightweight high-level utility class for connecting to
/// a network host using a connection oriented socket type.
/// </para>
/// <para>
/// You create a `GSocketClient` object, set any options you want, and then
/// call a sync or async connect operation, which returns a
/// [class@Gio.SocketConnection] subclass on success.
/// </para>
/// <para>
/// The type of the [class@Gio.SocketConnection] object returned depends on the
/// type of the underlying socket that is in use. For instance, for a TCP/IP
/// connection it will be a [class@Gio.TcpConnection].
/// </para>
/// <para>
/// As `GSocketClient` is a lightweight object, you don't need to cache it. You
/// can just create a new one any time you need one.
/// </para>
/// </summary>

public class GSocketClientHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GSocketClient with the default options.
/// </para>
/// </summary>

/// <return>
/// a #GSocketClient.
///     Free the returned object with g_object_unref().
/// </return>

	public static MentorLake.Gio.GSocketClientHandle New()
	{
		return GSocketClientHandleExterns.g_socket_client_new();
	}

}
public static class GSocketClientHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @client's activity on @connectable changes state.
/// Among other things, this can be used to provide progress
/// information about a network connection in the UI. The meanings of
/// the different @event values are as follows:
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_RESOLVING: @client is about to look up @connectable
///   in DNS. @connection will be %NULL.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_RESOLVED:  @client has successfully resolved
///   @connectable in DNS. @connection will be %NULL.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_CONNECTING: @client is about to make a connection
///   to a remote host; either a proxy server or the destination server
///   itself. @connection is the #GSocketConnection, which is not yet
///   connected.  Since GLib 2.40, you can access the remote
///   address via g_socket_connection_get_remote_address().
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_CONNECTED: @client has successfully connected
///   to a remote host. @connection is the connected #GSocketConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_PROXY_NEGOTIATING: @client is about to negotiate
///   with a proxy to get it to connect to @connectable. @connection is
///   the #GSocketConnection to the proxy server.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_PROXY_NEGOTIATED: @client has negotiated a
///   connection to @connectable through a proxy server. @connection is
///   the stream returned from g_proxy_connect(), which may or may not
///   be a #GSocketConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_TLS_HANDSHAKING: @client is about to begin a TLS
///   handshake. @connection is a #GTlsClientConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_TLS_HANDSHAKED: @client has successfully completed
///   the TLS handshake. @connection is a #GTlsClientConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_COMPLETE: @client has either successfully connected
///   to @connectable (in which case @connection is the #GSocketConnection
///   that it will be returning to the caller) or has failed (in which
///   case @connection is %NULL and the client is about to return an error).
/// </para>
/// <para>
/// Each event except %G_SOCKET_CLIENT_COMPLETE may be emitted
/// multiple times (or not at all) for a given connectable (in
/// particular, if @client ends up attempting to connect to more than
/// one address). However, if @client emits the #GSocketClient::event
/// signal at all for a given connectable, then it will always emit
/// it with %G_SOCKET_CLIENT_COMPLETE when it is done.
/// </para>
/// <para>
/// Note that there may be additional #GSocketClientEvent values in
/// the future; unrecognized @event values should be ignored.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the event that is occurring
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketClientEvent Event;
/// <summary>
/// <para>
/// the #GSocketConnectable that @event is occurring on
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketConnectableHandle Connectable;
/// <summary>
/// <para>
/// the current representation of the connection
/// </para>
/// </summary>

	public MentorLake.Gio.GIOStreamHandle Connection;

	public IntPtr UserData;
}
}

public static class GSocketClientHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @client's activity on @connectable changes state.
/// Among other things, this can be used to provide progress
/// information about a network connection in the UI. The meanings of
/// the different @event values are as follows:
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_RESOLVING: @client is about to look up @connectable
///   in DNS. @connection will be %NULL.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_RESOLVED:  @client has successfully resolved
///   @connectable in DNS. @connection will be %NULL.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_CONNECTING: @client is about to make a connection
///   to a remote host; either a proxy server or the destination server
///   itself. @connection is the #GSocketConnection, which is not yet
///   connected.  Since GLib 2.40, you can access the remote
///   address via g_socket_connection_get_remote_address().
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_CONNECTED: @client has successfully connected
///   to a remote host. @connection is the connected #GSocketConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_PROXY_NEGOTIATING: @client is about to negotiate
///   with a proxy to get it to connect to @connectable. @connection is
///   the #GSocketConnection to the proxy server.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_PROXY_NEGOTIATED: @client has negotiated a
///   connection to @connectable through a proxy server. @connection is
///   the stream returned from g_proxy_connect(), which may or may not
///   be a #GSocketConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_TLS_HANDSHAKING: @client is about to begin a TLS
///   handshake. @connection is a #GTlsClientConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_TLS_HANDSHAKED: @client has successfully completed
///   the TLS handshake. @connection is a #GTlsClientConnection.
/// </para>
/// <para>
/// - %G_SOCKET_CLIENT_COMPLETE: @client has either successfully connected
///   to @connectable (in which case @connection is the #GSocketConnection
///   that it will be returning to the caller) or has failed (in which
///   case @connection is %NULL and the client is about to return an error).
/// </para>
/// <para>
/// Each event except %G_SOCKET_CLIENT_COMPLETE may be emitted
/// multiple times (or not at all) for a given connectable (in
/// particular, if @client ends up attempting to connect to more than
/// one address). However, if @client emits the #GSocketClient::event
/// signal at all for a given connectable, then it will always emit
/// it with %G_SOCKET_CLIENT_COMPLETE when it is done.
/// </para>
/// <para>
/// Note that there may be additional #GSocketClientEvent values in
/// the future; unrecognized @event values should be ignored.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the event that is occurring
/// </param>
/// <param name="connectable">
/// the #GSocketConnectable that @event is occurring on
/// </param>
/// <param name="connection">
/// the current representation of the connection
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle self, MentorLake.Gio.GSocketClientEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle connection, IntPtr user_data);

}


public static class GSocketClientHandleExtensions
{
/// <summary>
/// <para>
/// Enable proxy protocols to be handled by the application. When the
/// indicated proxy protocol is returned by the #GProxyResolver,
/// #GSocketClient will consider this protocol as supported but will
/// not try to find a #GProxy instance to handle handshaking. The
/// application must check for this case by calling
/// g_socket_connection_get_remote_address() on the returned
/// #GSocketConnection, and seeing if it's a #GProxyAddress of the
/// appropriate type, to determine whether or not it needs to handle
/// the proxy handshaking itself.
/// </para>
/// <para>
/// This should be used for proxy protocols that are dialects of
/// another protocol such as HTTP proxy. It also allows cohabitation of
/// proxy protocols that are reused between protocols. A good example
/// is HTTP. It can be used to proxy HTTP, FTP and Gopher and can also
/// be use as generic socket proxy through the HTTP CONNECT method.
/// </para>
/// <para>
/// When the proxy is detected as being an application proxy, TLS handshake
/// will be skipped. This is required to let the application do the proxy
/// specific handshake.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="protocol">
/// The proxy protocol
/// </param>

	public static T AddApplicationProxy<T>(this T client, string protocol) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_add_application_proxy(client, protocol);
		return client;
	}

/// <summary>
/// <para>
/// Tries to resolve the @connectable and make a network connection to it.
/// </para>
/// <para>
/// Upon a successful connection, a new #GSocketConnection is constructed
/// and returned.  The caller owns this new object and must drop their
/// reference to it when finished with it.
/// </para>
/// <para>
/// The type of the #GSocketConnection object returned depends on the type of
/// the underlying socket that is used. For instance, for a TCP/IP connection
/// it will be a #GTcpConnection.
/// </para>
/// <para>
/// The socket created will be the same family as the address that the
/// @connectable resolves to, unless family is set with g_socket_client_set_family()
/// or indirectly via g_socket_client_set_local_address(). The socket type
/// defaults to %G_SOCKET_TYPE_STREAM but can be set with
/// g_socket_client_set_socket_type().
/// </para>
/// <para>
/// If a local address is specified with g_socket_client_set_local_address() the
/// socket will be bound to this address before connecting.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="connectable">
/// a #GSocketConnectable specifying the remote address.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle Connect(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect(client, connectable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of g_socket_client_connect().
/// </para>
/// <para>
/// You may wish to prefer the asynchronous version even in synchronous
/// command line programs because, since 2.60, it implements
/// [RFC 8305](https://tools.ietf.org/html/rfc8305) "Happy Eyeballs"
/// recommendations to work around long connection timeouts in networks
/// where IPv6 is broken by performing an IPv4 connection simultaneously
/// without waiting for IPv6 to time out, which is not supported by the
/// synchronous call. (This is not an API guarantee, and may change in
/// the future.)
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_socket_client_connect_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="connectable">
/// a #GSocketConnectable specifying the remote address.
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

	public static T ConnectAsync<T>(this T client, MentorLake.Gio.GSocketConnectableHandle connectable, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_async(client, connectable, cancellable, callback, user_data);
		return client;
	}

/// <summary>
/// <para>
/// Finishes an async connect operation. See g_socket_client_connect_async()
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is a helper function for g_socket_client_connect().
/// </para>
/// <para>
/// Attempts to create a TCP connection to the named host.
/// </para>
/// <para>
/// @host_and_port may be in any of a number of recognized formats; an IPv6
/// address, an IPv4 address, or a domain name (in which case a DNS
/// lookup is performed).  Quoting with [] is supported for all address
/// types.  A port override may be specified in the usual way with a
/// colon.  Ports may be given as decimal numbers or symbolic names (in
/// which case an /etc/services lookup is performed).
/// </para>
/// <para>
/// If no port override is given in @host_and_port then @default_port will be
/// used as the port number to connect to.
/// </para>
/// <para>
/// In general, @host_and_port is expected to be provided by the user (allowing
/// them to give the hostname, and a port override if necessary) and
/// @default_port is expected to be provided by the application.
/// </para>
/// <para>
/// In the case that an IP address is given, a single connection
/// attempt is made.  In the case that a name is given, multiple
/// connection attempts may be made, in turn and according to the
/// number of address records in DNS, until a connection succeeds.
/// </para>
/// <para>
/// Upon a successful connection, a new #GSocketConnection is constructed
/// and returned.  The caller owns this new object and must drop their
/// reference to it when finished with it.
/// </para>
/// <para>
/// In the event of any failure (DNS error, service not found, no hosts
/// connectable) %NULL is returned and @error (if non-%NULL) is set
/// accordingly.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="host_and_port">
/// the name and optionally port of the host to connect to
/// </param>
/// <param name="default_port">
/// the default port to connect to
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToHost(this MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_host(client, host_and_port, default_port, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of g_socket_client_connect_to_host().
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_socket_client_connect_to_host_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="host_and_port">
/// the name and optionally the port of the host to connect to
/// </param>
/// <param name="default_port">
/// the default port to connect to
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

	public static T ConnectToHostAsync<T>(this T client, string host_and_port, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_host_async(client, host_and_port, default_port, cancellable, callback, user_data);
		return client;
	}

/// <summary>
/// <para>
/// Finishes an async connect operation. See g_socket_client_connect_to_host_async()
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToHostFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_host_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to create a TCP connection to a service.
/// </para>
/// <para>
/// This call looks up the SRV record for @service at @domain for the
/// "tcp" protocol.  It then attempts to connect, in turn, to each of
/// the hosts providing the service until either a connection succeeds
/// or there are no hosts remaining.
/// </para>
/// <para>
/// Upon a successful connection, a new #GSocketConnection is constructed
/// and returned.  The caller owns this new object and must drop their
/// reference to it when finished with it.
/// </para>
/// <para>
/// In the event of any failure (DNS error, service not found, no hosts
/// connectable) %NULL is returned and @error (if non-%NULL) is set
/// accordingly.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketConnection
/// </param>
/// <param name="domain">
/// a domain name
/// </param>
/// <param name="service">
/// the name of the service to connect to
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a #GSocketConnection if successful, or %NULL on error
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToService(this MentorLake.Gio.GSocketClientHandle client, string domain, string service, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_service(client, domain, service, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of
/// g_socket_client_connect_to_service().
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="domain">
/// a domain name
/// </param>
/// <param name="service">
/// the name of the service to connect to
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

	public static T ConnectToServiceAsync<T>(this T client, string domain, string service, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_service_async(client, domain, service, cancellable, callback, user_data);
		return client;
	}

/// <summary>
/// <para>
/// Finishes an async connect operation. See g_socket_client_connect_to_service_async()
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToServiceFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_service_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is a helper function for g_socket_client_connect().
/// </para>
/// <para>
/// Attempts to create a TCP connection with a network URI.
/// </para>
/// <para>
/// @uri may be any valid URI containing an "authority" (hostname/port)
/// component. If a port is not specified in the URI, @default_port
/// will be used. TLS will be negotiated if #GSocketClient:tls is %TRUE.
/// (#GSocketClient does not know to automatically assume TLS for
/// certain URI schemes.)
/// </para>
/// <para>
/// Using this rather than g_socket_client_connect() or
/// g_socket_client_connect_to_host() allows #GSocketClient to
/// determine when to use application-specific proxy protocols.
/// </para>
/// <para>
/// Upon a successful connection, a new #GSocketConnection is constructed
/// and returned.  The caller owns this new object and must drop their
/// reference to it when finished with it.
/// </para>
/// <para>
/// In the event of any failure (DNS error, service not found, no hosts
/// connectable) %NULL is returned and @error (if non-%NULL) is set
/// accordingly.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="uri">
/// A network URI
/// </param>
/// <param name="default_port">
/// the default port to connect to
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToUri(this MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_uri(client, uri, default_port, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This is the asynchronous version of g_socket_client_connect_to_uri().
/// </para>
/// <para>
/// When the operation is finished @callback will be
/// called. You can then call g_socket_client_connect_to_uri_finish() to get
/// the result of the operation.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <param name="uri">
/// a network uri
/// </param>
/// <param name="default_port">
/// the default port to connect to
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

	public static T ConnectToUriAsync<T>(this T client, string uri, ushort default_port, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_connect_to_uri_async(client, uri, default_port, cancellable, callback, user_data);
		return client;
	}

/// <summary>
/// <para>
/// Finishes an async connect operation. See g_socket_client_connect_to_uri_async()
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// a #GSocketConnection on success, %NULL on error.
/// </return>

	public static MentorLake.Gio.GSocketConnectionHandle ConnectToUriFinish(this MentorLake.Gio.GSocketClientHandle client, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		var externCallResult = GSocketClientHandleExterns.g_socket_client_connect_to_uri_finish(client, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the proxy enable state; see g_socket_client_set_enable_proxy()
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// whether proxying is enabled
/// </return>

	public static bool GetEnableProxy(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_enable_proxy(client);
	}

/// <summary>
/// <para>
/// Gets the socket family of the socket client.
/// </para>
/// <para>
/// See g_socket_client_set_family() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// a #GSocketFamily
/// </return>

	public static MentorLake.Gio.GSocketFamily GetFamily(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_family(client);
	}

/// <summary>
/// <para>
/// Gets the local address of the socket client.
/// </para>
/// <para>
/// See g_socket_client_set_local_address() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// a #GSocketAddress or %NULL. Do not free.
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_local_address(client);
	}

/// <summary>
/// <para>
/// Gets the protocol name type of the socket client.
/// </para>
/// <para>
/// See g_socket_client_set_protocol() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <return>
/// a #GSocketProtocol
/// </return>

	public static MentorLake.Gio.GSocketProtocol GetProtocol(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_protocol(client);
	}

/// <summary>
/// <para>
/// Gets the #GProxyResolver being used by @client. Normally, this will
/// be the resolver returned by g_proxy_resolver_get_default(), but you
/// can override it with g_socket_client_set_proxy_resolver().
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// The #GProxyResolver being used by
///   @client.
/// </return>

	public static MentorLake.Gio.GProxyResolverHandle GetProxyResolver(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_proxy_resolver(client);
	}

/// <summary>
/// <para>
/// Gets the socket type of the socket client.
/// </para>
/// <para>
/// See g_socket_client_set_socket_type() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// a #GSocketFamily
/// </return>

	public static MentorLake.Gio.GSocketType GetSocketType(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_socket_type(client);
	}

/// <summary>
/// <para>
/// Gets the I/O timeout time for sockets created by @client.
/// </para>
/// <para>
/// See g_socket_client_set_timeout() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient
/// </param>
/// <return>
/// the timeout in seconds
/// </return>

	public static uint GetTimeout(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_timeout(client);
	}

/// <summary>
/// <para>
/// Gets whether @client creates TLS connections. See
/// g_socket_client_set_tls() for details.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// whether @client uses TLS
/// </return>

	public static bool GetTls(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_tls(client);
	}

/// <summary>
/// <para>
/// Gets the TLS validation flags used creating TLS connections via
/// @client.
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GSocketClient:tls-validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <return>
/// the TLS validation flags
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetTlsValidationFlags(this MentorLake.Gio.GSocketClientHandle client)
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		return GSocketClientHandleExterns.g_socket_client_get_tls_validation_flags(client);
	}

/// <summary>
/// <para>
/// Sets whether or not @client attempts to make connections via a
/// proxy server. When enabled (the default), #GSocketClient will use a
/// #GProxyResolver to determine if a proxy protocol such as SOCKS is
/// needed, and automatically do the necessary proxy negotiation.
/// </para>
/// <para>
/// See also g_socket_client_set_proxy_resolver().
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="enable">
/// whether to enable proxies
/// </param>

	public static T SetEnableProxy<T>(this T client, bool enable) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_enable_proxy(client, enable);
		return client;
	}

/// <summary>
/// <para>
/// Sets the socket family of the socket client.
/// If this is set to something other than %G_SOCKET_FAMILY_INVALID
/// then the sockets created by this object will be of the specified
/// family.
/// </para>
/// <para>
/// This might be useful for instance if you want to force the local
/// connection to be an ipv4 socket, even though the address might
/// be an ipv6 mapped to ipv4 address.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="family">
/// a #GSocketFamily
/// </param>

	public static T SetFamily<T>(this T client, MentorLake.Gio.GSocketFamily family) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_family(client, family);
		return client;
	}

/// <summary>
/// <para>
/// Sets the local address of the socket client.
/// The sockets created by this object will bound to the
/// specified address (if not %NULL) before connecting.
/// </para>
/// <para>
/// This is useful if you want to ensure that the local
/// side of the connection is on a specific port, or on
/// a specific interface.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="address">
/// a #GSocketAddress, or %NULL
/// </param>

	public static T SetLocalAddress<T>(this T client, MentorLake.Gio.GSocketAddressHandle address) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_local_address(client, address);
		return client;
	}

/// <summary>
/// <para>
/// Sets the protocol of the socket client.
/// The sockets created by this object will use of the specified
/// protocol.
/// </para>
/// <para>
/// If @protocol is %G_SOCKET_PROTOCOL_DEFAULT that means to use the default
/// protocol for the socket family and type.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="protocol">
/// a #GSocketProtocol
/// </param>

	public static T SetProtocol<T>(this T client, MentorLake.Gio.GSocketProtocol protocol) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_protocol(client, protocol);
		return client;
	}

/// <summary>
/// <para>
/// Overrides the #GProxyResolver used by @client. You can call this if
/// you want to use specific proxies, rather than using the system
/// default proxy settings.
/// </para>
/// <para>
/// Note that whether or not the proxy resolver is actually used
/// depends on the setting of #GSocketClient:enable-proxy, which is not
/// changed by this function (but which is %TRUE by default)
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="proxy_resolver">
/// a #GProxyResolver, or %NULL for the
///   default.
/// </param>

	public static T SetProxyResolver<T>(this T client, MentorLake.Gio.GProxyResolverHandle proxy_resolver) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_proxy_resolver(client, proxy_resolver);
		return client;
	}

/// <summary>
/// <para>
/// Sets the socket type of the socket client.
/// The sockets created by this object will be of the specified
/// type.
/// </para>
/// <para>
/// It doesn't make sense to specify a type of %G_SOCKET_TYPE_DATAGRAM,
/// as GSocketClient is used for connection oriented services.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="type">
/// a #GSocketType
/// </param>

	public static T SetSocketType<T>(this T client, MentorLake.Gio.GSocketType type) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_socket_type(client, type);
		return client;
	}

/// <summary>
/// <para>
/// Sets the I/O timeout for sockets created by @client. @timeout is a
/// time in seconds, or 0 for no timeout (the default).
/// </para>
/// <para>
/// The timeout value affects the initial connection attempt as well,
/// so setting this may cause calls to g_socket_client_connect(), etc,
/// to fail with %G_IO_ERROR_TIMED_OUT.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="timeout">
/// the timeout
/// </param>

	public static T SetTimeout<T>(this T client, uint timeout) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_timeout(client, timeout);
		return client;
	}

/// <summary>
/// <para>
/// Sets whether @client creates TLS (aka SSL) connections. If @tls is
/// %TRUE, @client will wrap its connections in a #GTlsClientConnection
/// and perform a TLS handshake when connecting.
/// </para>
/// <para>
/// Note that since #GSocketClient must return a #GSocketConnection,
/// but #GTlsClientConnection is not a #GSocketConnection, this
/// actually wraps the resulting #GTlsClientConnection in a
/// #GTcpWrapperConnection when returning it. You can use
/// g_tcp_wrapper_connection_get_base_io_stream() on the return value
/// to extract the #GTlsClientConnection.
/// </para>
/// <para>
/// If you need to modify the behavior of the TLS handshake (eg, by
/// setting a client-side certificate to use, or connecting to the
/// #GTlsConnection::accept-certificate signal), you can connect to
/// @client's #GSocketClient::event signal and wait for it to be
/// emitted with %G_SOCKET_CLIENT_TLS_HANDSHAKING, which will give you
/// a chance to see the #GTlsClientConnection before the handshake
/// starts.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="tls">
/// whether to use TLS
/// </param>

	public static T SetTls<T>(this T client, bool tls) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_tls(client, tls);
		return client;
	}

/// <summary>
/// <para>
/// Sets the TLS validation flags used when creating TLS connections
/// via @client. The default value is %G_TLS_CERTIFICATE_VALIDATE_ALL.
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GSocketClient:tls-validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="client">
/// a #GSocketClient.
/// </param>
/// <param name="flags">
/// the validation flags
/// </param>

	public static T SetTlsValidationFlags<T>(this T client, MentorLake.Gio.GTlsCertificateFlags flags) where T : GSocketClientHandle
	{
		if (client.IsInvalid) throw new Exception("Invalid handle (GSocketClientHandle)");
		GSocketClientHandleExterns.g_socket_client_set_tls_validation_flags(client, flags);
		return client;
	}

}

internal class GSocketClientHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))]
	internal static extern MentorLake.Gio.GSocketClientHandle g_socket_client_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_add_application_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string protocol);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle connectable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_host_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string host_and_port, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_host_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_service([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string domain, string service, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_service_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string domain, string service, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_service_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_client_connect_to_uri_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, string uri, ushort default_port, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketConnectionHandle>))]
	internal static extern MentorLake.Gio.GSocketConnectionHandle g_socket_client_connect_to_uri_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_socket_client_get_enable_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketFamily g_socket_client_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_client_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketProtocol g_socket_client_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketClientHandle>))] MentorLake.Gio.GSocketClientHandle client);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GProxyResolverHandleImpl>))]
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

namespace MentorLake.Soup;

/// <summary>
/// <para>
/// [class@Server] provides a basic implementation of an HTTP server. The
/// recommended usage of this server is for internal use, tasks like
/// a mock server for tests, a private service for IPC, etc. It is not
/// recommended to be exposed to untrusted clients as it may be vulnerable
/// to denial of service attacks or other exploits.
/// </para>
/// <para>
/// To begin, create a server using [ctor@Server.new]. Add at least one
/// handler by calling [method@Server.add_handler] or
/// [method@Server.add_early_handler]; the handler will be called to
/// process any requests underneath the path you pass. (If you want all
/// requests to go to the same handler, just pass &quot;/&quot; (or %NULL) for
/// the path.)
/// </para>
/// <para>
/// When a new connection is accepted (or a new request is started on
/// an existing persistent connection), the [class@Server] will emit
/// [signal@Server::request-started] and then begin processing the request
/// as described below, but note that once the message is assigned a
/// status-code, then callbacks after that point will be
/// skipped. Note also that it is not defined when the callbacks happen
/// relative to various [class@ServerMessage] signals.
/// </para>
/// <para>
/// Once the headers have been read, [class@Server] will check if there is
/// a [class@AuthDomain] `(qv)` covering the Request-URI; if so, and if the
/// message does not contain suitable authorization, then the
/// [class@AuthDomain] will set a status of %SOUP_STATUS_UNAUTHORIZED on
/// the message.
/// </para>
/// <para>
/// After checking for authorization, [class@Server] will look for &quot;early&quot;
/// handlers (added with [method@Server.add_early_handler]) matching the
/// Request-URI. If one is found, it will be run; in particular, this
/// can be used to connect to signals to do a streaming read of the
/// request body.
/// </para>
/// <para>
/// (At this point, if the request headers contain `Expect:
/// 100-continue`, and a status code has been set, then
/// [class@Server] will skip the remaining steps and return the response.
/// If the request headers contain `Expect:
/// 100-continue` and no status code has been set,
/// [class@Server] will return a %SOUP_STATUS_CONTINUE status before
/// continuing.)
/// </para>
/// <para>
/// The server will then read in the response body (if present). At
/// this point, if there are no handlers at all defined for the
/// Request-URI, then the server will return %SOUP_STATUS_NOT_FOUND to
/// the client.
/// </para>
/// <para>
/// Otherwise (assuming no previous step assigned a status to the
/// message) any &quot;normal&quot; handlers (added with
/// [method@Server.add_handler]) for the message&apos;s Request-URI will be
/// run.
/// </para>
/// <para>
/// Then, if the path has a WebSocket handler registered (and has
/// not yet been assigned a status), [class@Server] will attempt to
/// validate the WebSocket handshake, filling in the response and
/// setting a status of %SOUP_STATUS_SWITCHING_PROTOCOLS or
/// %SOUP_STATUS_BAD_REQUEST accordingly.
/// </para>
/// <para>
/// If the message still has no status code at this point (and has not
/// been paused with [method@ServerMessage.pause]), then it will be
/// given a status of %SOUP_STATUS_INTERNAL_SERVER_ERROR (because at
/// least one handler ran, but returned without assigning a status).
/// </para>
/// <para>
/// Finally, the server will emit [signal@Server::request-finished] (or
/// [signal@Server::request-aborted] if an I/O error occurred before
/// handling was completed).
/// </para>
/// <para>
/// If you want to handle the special &quot;*&quot; URI (eg, &quot;OPTIONS *&quot;), you
/// must explicitly register a handler for &quot;*&quot;; the default handler
/// will not be used for that case.
/// </para>
/// <para>
/// If you want to process https connections in addition to (or instead
/// of) http connections, you can set the [property@Server:tls-certificate]
/// property.
/// </para>
/// <para>
/// Once the server is set up, make one or more calls to
/// [method@Server.listen], [method@Server.listen_local], or
/// [method@Server.listen_all] to tell it where to listen for
/// connections. (All ports on a [class@Server] use the same handlers; if
/// you need to handle some ports differently, such as returning
/// different data for http and https, you&apos;ll need to create multiple
/// [class@Server]s, or else check the passed-in URI in the handler
/// function.).
/// </para>
/// <para>
/// [class@Server] will begin processing connections as soon as you return
/// to (or start) the main loop for the current thread-default
/// [struct@GLib.MainContext].
/// </para>
/// </summary>

public class SoupServerHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new [class@Server].
/// </para>
/// <para>
/// This is exactly equivalent to calling [ctor@GObject.Object.new] and
/// specifying %SOUP_TYPE_SERVER as the type.
/// </para>
/// </summary>

/// <param name="optname1">
/// name of first property to set
/// </param>
/// <param name="@__arglist">
/// value of @optname1, followed by additional property/value pairs
/// </param>
/// <return>
/// a new #SoupServer. If you are using
///   certain legacy properties, this may also return %NULL if an error
///   occurs.
/// </return>

	public static MentorLake.Soup.SoupServerHandle New(string optname1, IntPtr @__arglist)
	{
		return SoupServerHandleExterns.soup_server_new(optname1, @__arglist);
	}

}
public static class SoupServerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when processing has failed for a message.
/// </para>
/// <para>
/// This could mean either that it could not be read (if
/// [signal@Server::request-read] has not been emitted for it yet), or that
/// the response could not be written back (if [signal@Server::request-read]
/// has been emitted but [signal@Server::request-finished] has not been).
/// </para>
/// <para>
/// @message is in an undefined state when this signal is
/// emitted; the signal exists primarily to allow the server to
/// free any state that it may have allocated in
/// [signal@Server::request-started].
/// </para>
/// </summary>

	public static IObservable<SoupServerHandleSignalStructs.RequestAbortedSignal> Signal_RequestAborted(this SoupServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerHandleSignalStructs.RequestAbortedSignal> obs) =>
		{
			SoupServerHandleSignalDelegates.request_aborted handler = ( MentorLake.Soup.SoupServerHandle self,  MentorLake.Soup.SoupServerMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerHandleSignalStructs.RequestAbortedSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-aborted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when the server has finished writing a response to
/// a request.
/// </para>
/// </summary>

	public static IObservable<SoupServerHandleSignalStructs.RequestFinishedSignal> Signal_RequestFinished(this SoupServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerHandleSignalStructs.RequestFinishedSignal> obs) =>
		{
			SoupServerHandleSignalDelegates.request_finished handler = ( MentorLake.Soup.SoupServerHandle self,  MentorLake.Soup.SoupServerMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerHandleSignalStructs.RequestFinishedSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when the server has successfully read a request.
/// </para>
/// <para>
/// @message will have all of its request-side information
/// filled in, and if the message was authenticated, @client
/// will have information about that. This signal is emitted
/// before any (non-early) handlers are called for the message,
/// and if it sets the message&apos;s #status_code, then normal
/// handler processing will be skipped.
/// </para>
/// </summary>

	public static IObservable<SoupServerHandleSignalStructs.RequestReadSignal> Signal_RequestRead(this SoupServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerHandleSignalStructs.RequestReadSignal> obs) =>
		{
			SoupServerHandleSignalDelegates.request_read handler = ( MentorLake.Soup.SoupServerHandle self,  MentorLake.Soup.SoupServerMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerHandleSignalStructs.RequestReadSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-read", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Emitted when the server has started reading a new request.
/// </para>
/// <para>
/// @message will be completely blank; not even the
/// Request-Line will have been read yet. About the only thing
/// you can usefully do with it is connect to its signals.
/// </para>
/// <para>
/// If the request is read successfully, this will eventually
/// be followed by a [signal@Server::request_read signal]. If a
/// response is then sent, the request processing will end with
/// a [signal@Server::request-finished] signal. If a network error
/// occurs, the processing will instead end with
/// [signal@Server::request-aborted].
/// </para>
/// </summary>

	public static IObservable<SoupServerHandleSignalStructs.RequestStartedSignal> Signal_RequestStarted(this SoupServerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerHandleSignalStructs.RequestStartedSignal> obs) =>
		{
			SoupServerHandleSignalDelegates.request_started handler = ( MentorLake.Soup.SoupServerHandle self,  MentorLake.Soup.SoupServerMessageHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerHandleSignalStructs.RequestStartedSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class SoupServerHandleSignalStructs
{

public class RequestAbortedSignal
{

	public MentorLake.Soup.SoupServerHandle Self;
/// <summary>
/// <para>
/// the message
/// </para>
/// </summary>

	public MentorLake.Soup.SoupServerMessageHandle Message;

	public IntPtr UserData;
}

public class RequestFinishedSignal
{

	public MentorLake.Soup.SoupServerHandle Self;
/// <summary>
/// <para>
/// the message
/// </para>
/// </summary>

	public MentorLake.Soup.SoupServerMessageHandle Message;

	public IntPtr UserData;
}

public class RequestReadSignal
{

	public MentorLake.Soup.SoupServerHandle Self;
/// <summary>
/// <para>
/// the message
/// </para>
/// </summary>

	public MentorLake.Soup.SoupServerMessageHandle Message;

	public IntPtr UserData;
}

public class RequestStartedSignal
{

	public MentorLake.Soup.SoupServerHandle Self;
/// <summary>
/// <para>
/// the new message
/// </para>
/// </summary>

	public MentorLake.Soup.SoupServerMessageHandle Message;

	public IntPtr UserData;
}
}

public static class SoupServerHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when processing has failed for a message.
/// </para>
/// <para>
/// This could mean either that it could not be read (if
/// [signal@Server::request-read] has not been emitted for it yet), or that
/// the response could not be written back (if [signal@Server::request-read]
/// has been emitted but [signal@Server::request-finished] has not been).
/// </para>
/// <para>
/// @message is in an undefined state when this signal is
/// emitted; the signal exists primarily to allow the server to
/// free any state that it may have allocated in
/// [signal@Server::request-started].
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the message
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_aborted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle message, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the server has finished writing a response to
/// a request.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the message
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle message, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the server has successfully read a request.
/// </para>
/// <para>
/// @message will have all of its request-side information
/// filled in, and if the message was authenticated, @client
/// will have information about that. This signal is emitted
/// before any (non-early) handlers are called for the message,
/// and if it sets the message&apos;s #status_code, then normal
/// handler processing will be skipped.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the message
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_read([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle message, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the server has started reading a new request.
/// </para>
/// <para>
/// @message will be completely blank; not even the
/// Request-Line will have been read yet. About the only thing
/// you can usefully do with it is connect to its signals.
/// </para>
/// <para>
/// If the request is read successfully, this will eventually
/// be followed by a [signal@Server::request_read signal]. If a
/// response is then sent, the request processing will end with
/// a [signal@Server::request-finished] signal. If a network error
/// occurs, the processing will instead end with
/// [signal@Server::request-aborted].
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the new message
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_started([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle message, IntPtr user_data);

}


public static class SoupServerHandleExtensions
{
/// <summary>
/// <para>
/// Adds a new client stream to the @server.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="stream">
/// a #GIOStream
/// </param>
/// <param name="local_addr">
/// the local #GSocketAddress associated with the
///   @stream
/// </param>
/// <param name="remote_addr">
/// the remote #GSocketAddress associated with the
///   @stream
/// </param>
/// <return>
/// %TRUE on success, %FALSE if the stream could not be
///   accepted or any other error occurred (in which case @error will be
///   set).
/// </return>

	public static bool AcceptIostream(this MentorLake.Soup.SoupServerHandle server, MentorLake.Gio.GIOStreamHandle stream, MentorLake.Gio.GSocketAddressHandle local_addr, MentorLake.Gio.GSocketAddressHandle remote_addr)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		var externCallResult = SoupServerHandleExterns.soup_server_accept_iostream(server, stream, local_addr, remote_addr, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Adds an authentication domain to @server.
/// </para>
/// <para>
/// Each auth domain will have the chance to require authentication for each
/// request that comes in; normally auth domains will require authentication for
/// requests on certain paths that they have been set up to watch, or that meet
/// other criteria set by the caller. If an auth domain determines that a request
/// requires authentication (and the request doesn&apos;t contain authentication),
/// @server will automatically reject the request with an appropriate status (401
/// Unauthorized or 407 Proxy Authentication Required). If the request used the
/// SoupServer:100-continue Expectation, @server will reject it before the
/// request body is sent.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="auth_domain">
/// a #SoupAuthDomain
/// </param>

	public static T AddAuthDomain<T>(this T server, MentorLake.Soup.SoupAuthDomainHandle auth_domain) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_add_auth_domain(server, auth_domain);
		return server;
	}

/// <summary>
/// <para>
/// Adds an &quot;early&quot; handler to @server for requests prefixed by @path.
/// </para>
/// <para>
/// Note that &quot;normal&quot; and &quot;early&quot; handlers are matched up together, so if you
/// add a normal handler for &quot;/foo&quot; and an early handler for &quot;/foo/bar&quot;, then a
/// request to &quot;/foo/bar&quot; (or any path below it) will run only the early handler.
/// (But if you add both handlers at the same path, then both will get run.)
/// </para>
/// <para>
/// For requests under @path (that have not already been assigned a
/// status code by a [class@AuthDomain] or a signal handler), @callback
/// will be invoked after receiving the request headers, but before
/// receiving the request body; the message&apos;s method and
/// request-headers properties will be set.
/// </para>
/// <para>
/// Early handlers are generally used for processing requests with request bodies
/// in a streaming fashion. If you determine that the request will contain a
/// message body, normally you would call [method@MessageBody.set_accumulate] on
/// the message&apos;s request-body to turn off request-body accumulation, and connect
/// to the message&apos;s [signal@ServerMessage::got-chunk] signal to process each
/// chunk as it comes in.
/// </para>
/// <para>
/// To complete the message processing after the full message body has
/// been read, you can either also connect to [signal@ServerMessage::got-body],
/// or else you can register a non-early handler for @path as well. As
/// long as you have not set the status-code by the time
/// [signal@ServerMessage::got-body] is emitted, the non-early handler will be
/// run as well.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="path">
/// the toplevel path for the handler
/// </param>
/// <param name="callback">
/// callback to invoke for
///   requests under @path
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>
/// <param name="destroy">
/// destroy notifier to free @user_data
/// </param>

	public static T AddEarlyHandler<T>(this T server, string path, MentorLake.Soup.SoupServerCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_add_early_handler(server, path, callback, user_data, destroy);
		return server;
	}

/// <summary>
/// <para>
/// Adds a handler to @server for requests prefixed by @path.
/// </para>
/// <para>
/// If @path is %NULL or &quot;/&quot;, then this will be the default handler for all
/// requests that don&apos;t have a more specific handler. (Note though that if you
/// want to handle requests to the special &quot;*&quot; URI, you must explicitly register
/// a handler for &quot;*&quot;; the default handler will not be used for that case.)
/// </para>
/// <para>
/// For requests under @path (that have not already been assigned a
/// status code by a [class@AuthDomain], an early server handler, or a
/// signal handler), @callback will be invoked after receiving the
/// request body; the [class@ServerMessage]&apos;s method, request-headers,
/// and request-body properties will be set.
/// </para>
/// <para>
/// After determining what to do with the request, the callback must at a minimum
/// call [method@ServerMessage.set_status] on the message to set the response
/// status code. Additionally, it may set response headers and/or fill in the
/// response body.
/// </para>
/// <para>
/// If the callback cannot fully fill in the response before returning
/// (eg, if it needs to wait for information from a database, or
/// another network server), it should call [method@ServerMessage.pause]
/// to tell @server to not send the response right away. When the
/// response is ready, call [method@ServerMessage.unpause] to cause it
/// to be sent.
/// </para>
/// <para>
/// To send the response body a bit at a time using &quot;chunked&quot; encoding, first
/// call [method@MessageHeaders.set_encoding] to set %SOUP_ENCODING_CHUNKED on
/// the response-headers. Then call [method@MessageBody.append] (or
/// [method@MessageBody.append_bytes])) to append each chunk as it becomes ready,
/// and [method@ServerMessage.unpause] to make sure it&apos;s running. (The server
/// will automatically pause the message if it is using chunked encoding but no
/// more chunks are available.) When you are done, call
/// [method@MessageBody.complete] to indicate that no more chunks are coming.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="path">
/// the toplevel path for the handler
/// </param>
/// <param name="callback">
/// callback to invoke for
///   requests under @path
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>
/// <param name="destroy">
/// destroy notifier to free @user_data
/// </param>

	public static T AddHandler<T>(this T server, string path, MentorLake.Soup.SoupServerCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_add_handler(server, path, callback, user_data, destroy);
		return server;
	}

/// <summary>
/// <para>
/// Add support for a WebSocket extension of the given @extension_type.
/// </para>
/// <para>
/// When a WebSocket client requests an extension of @extension_type,
/// a new [class@WebsocketExtension] of type @extension_type will be created
/// to handle the request.
/// </para>
/// <para>
/// Note that [class@WebsocketExtensionDeflate] is supported by default, use
/// [method@Server.remove_websocket_extension] if you want to disable it.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="extension_type">
/// a #GType
/// </param>

	public static T AddWebsocketExtension<T>(this T server, MentorLake.GObject.GType extension_type) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_add_websocket_extension(server, extension_type);
		return server;
	}

/// <summary>
/// <para>
/// Adds a WebSocket handler to @server for requests prefixed by @path.
/// </para>
/// <para>
/// If @path is %NULL or &quot;/&quot;, then this will be the default handler for all
/// requests that don&apos;t have a more specific handler.
/// </para>
/// <para>
/// When a path has a WebSocket handler registered, @server will check
/// incoming requests for WebSocket handshakes after all other handlers
/// have run (unless some earlier handler has already set a status code
/// on the message), and update the request&apos;s status, response headers,
/// and response body accordingly.
/// </para>
/// <para>
/// If @origin is non-%NULL, then only requests containing a matching
/// &quot;Origin&quot; header will be accepted. If @protocols is non-%NULL, then
/// only requests containing a compatible &quot;Sec-WebSocket-Protocols&quot;
/// header will be accepted. More complicated requirements can be
/// handled by adding a normal handler to @path, and having it perform
/// whatever checks are needed and
/// setting a failure status code if the handshake should be rejected.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="path">
/// the toplevel path for the handler
/// </param>
/// <param name="origin">
/// the origin of the connection
/// </param>
/// <param name="protocols">
/// the protocols
///   supported by this handler
/// </param>
/// <param name="callback">
/// callback to invoke for
///   successful WebSocket requests under @path
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>
/// <param name="destroy">
/// destroy notifier to free @user_data
/// </param>

	public static T AddWebsocketHandler<T>(this T server, string path, string origin, string[] protocols, MentorLake.Soup.SoupServerWebsocketCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_add_websocket_handler(server, path, origin, protocols, callback, user_data, destroy);
		return server;
	}

/// <summary>
/// <para>
/// Closes and frees @server&apos;s listening sockets.
/// </para>
/// <para>
/// Note that if there are currently requests in progress on @server, that they
/// will continue to be processed if @server&apos;s [struct@GLib.MainContext] is still
/// running.
/// </para>
/// <para>
/// You can call [method@Server.listen], etc, after calling this function
/// if you want to start listening again.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>

	public static T Disconnect<T>(this T server) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_disconnect(server);
		return server;
	}

/// <summary>
/// <para>
/// Gets @server&apos;s list of listening sockets.
/// </para>
/// <para>
/// You should treat these sockets as read-only; writing to or
/// modifiying any of these sockets may cause @server to malfunction.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// a
///   list of listening sockets.
/// </return>

	public static MentorLake.GLib.GSListHandle GetListeners(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_get_listeners(server);
	}

/// <summary>
/// <para>
/// Gets the @server SSL/TLS client authentication mode.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// a #GTlsAuthenticationMode
/// </return>

	public static MentorLake.Gio.GTlsAuthenticationMode GetTlsAuthMode(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_get_tls_auth_mode(server);
	}

/// <summary>
/// <para>
/// Gets the @server SSL/TLS certificate.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// a #GTlsCertificate or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetTlsCertificate(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_get_tls_certificate(server);
	}

/// <summary>
/// <para>
/// Gets the @server SSL/TLS database.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// a #GTlsDatabase
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle GetTlsDatabase(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_get_tls_database(server);
	}

/// <summary>
/// <para>
/// Gets a list of URIs corresponding to the interfaces @server is
/// listening on.
/// </para>
/// <para>
/// These will contain IP addresses, not hostnames, and will also indicate
/// whether the given listener is http or https.
/// </para>
/// <para>
/// Note that if you used [method@Server.listen_all] the returned URIs will use
/// the addresses `0.0.0.0` and `::`, rather than actually returning separate
/// URIs for each interface on the system.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// a list of [struct@GLib.Uri], which you
///   must free with each element with [method@GLib.Uri.unref] when you are done with it.
/// </return>

	public static MentorLake.GLib.GSListHandle GetUris(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_get_uris(server);
	}

/// <summary>
/// <para>
/// Checks whether @server is capable of https.
/// </para>
/// <para>
/// In order for a server to run https, you must call
/// [method@Server.set_tls_certificate], or set the
/// [property@Server:tls-certificate] property, to provide it with a
/// certificate to use.
/// </para>
/// <para>
/// If you are using the deprecated single-listener APIs, then a return value of
/// %TRUE indicates that the [class@Server] serves https exclusively. If you are
/// using [method@Server.listen], etc, then a %TRUE return value merely indicates
/// that the server is *able* to do https, regardless of whether it actually
/// currently is or not. Use [method@Server.get_uris] to see if it currently has
/// any https listeners.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <return>
/// %TRUE if @server is configured to serve https.
/// </return>

	public static bool IsHttps(this MentorLake.Soup.SoupServerHandle server)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		return SoupServerHandleExterns.soup_server_is_https(server);
	}

/// <summary>
/// <para>
/// Attempts to set up @server to listen for connections on @address.
/// </para>
/// <para>
/// If @options includes %SOUP_SERVER_LISTEN_HTTPS, and @server has
/// been configured for TLS, then @server will listen for https
/// connections on this port. Otherwise it will listen for plain http.
/// </para>
/// <para>
/// You may call this method (along with the other &quot;listen&quot; methods)
/// any number of times on a server, if you want to listen on multiple
/// ports, or set up both http and https service.
/// </para>
/// <para>
/// After calling this method, @server will begin accepting and processing
/// connections as soon as the appropriate [struct@GLib.MainContext] is run.
/// </para>
/// <para>
/// Note that this API does not make use of dual IPv4/IPv6 sockets; if
/// @address is an IPv6 address, it will only accept IPv6 connections.
/// You must configure IPv4 listening separately.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="address">
/// the address of the interface to listen on
/// </param>
/// <param name="options">
/// listening options for this server
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @address could not be
///   bound or any other error occurred (in which case @error will be
///   set).
/// </return>

	public static bool Listen(this MentorLake.Soup.SoupServerHandle server, MentorLake.Gio.GSocketAddressHandle address, MentorLake.Soup.SoupServerListenOptions options)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		var externCallResult = SoupServerHandleExterns.soup_server_listen(server, address, options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to set up @server to listen for connections on all interfaces
/// on the system.
/// </para>
/// <para>
/// That is, it listens on the addresses `0.0.0.0` and/or `::`, depending on
/// whether @options includes %SOUP_SERVER_LISTEN_IPV4_ONLY,
/// %SOUP_SERVER_LISTEN_IPV6_ONLY, or neither.) If @port is specified, @server
/// will listen on that port. If it is 0, @server will find an unused port to
/// listen on. (In that case, you can use [method@Server.get_uris] to find out
/// what port it ended up choosing.
/// </para>
/// <para>
/// See [method@Server.listen] for more details.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="port">
/// the port to listen on, or 0
/// </param>
/// <param name="options">
/// listening options for this server
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @port could not be bound
///   or any other error occurred (in which case @error will be set).
/// </return>

	public static bool ListenAll(this MentorLake.Soup.SoupServerHandle server, uint port, MentorLake.Soup.SoupServerListenOptions options)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		var externCallResult = SoupServerHandleExterns.soup_server_listen_all(server, port, options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to set up @server to listen for connections on &quot;localhost&quot;.
/// </para>
/// <para>
/// That is, `127.0.0.1` and/or `::1`, depending on whether @options includes
/// %SOUP_SERVER_LISTEN_IPV4_ONLY, %SOUP_SERVER_LISTEN_IPV6_ONLY, or neither). If
/// @port is specified, @server will listen on that port. If it is 0, @server
/// will find an unused port to listen on. (In that case, you can use
/// [method@Server.get_uris] to find out what port it ended up choosing.
/// </para>
/// <para>
/// See [method@Server.listen] for more details.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="port">
/// the port to listen on, or 0
/// </param>
/// <param name="options">
/// listening options for this server
/// </param>
/// <return>
/// %TRUE on success, %FALSE if @port could not be bound
///   or any other error occurred (in which case @error will be set).
/// </return>

	public static bool ListenLocal(this MentorLake.Soup.SoupServerHandle server, uint port, MentorLake.Soup.SoupServerListenOptions options)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		var externCallResult = SoupServerHandleExterns.soup_server_listen_local(server, port, options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Attempts to set up @server to listen for connections on @socket.
/// </para>
/// <para>
/// See [method@Server.listen] for more details.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="socket">
/// a listening #GSocket
/// </param>
/// <param name="options">
/// listening options for this server
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred (in
///   which case @error will be set).
/// </return>

	public static bool ListenSocket(this MentorLake.Soup.SoupServerHandle server, MentorLake.Gio.GSocketHandle socket, MentorLake.Soup.SoupServerListenOptions options)
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		var externCallResult = SoupServerHandleExterns.soup_server_listen_socket(server, socket, options, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Pauses I/O on @msg.
/// </para>
/// <para>
/// This can be used when you need to return from the server handler without
/// having the full response ready yet. Use [method@Server.unpause_message] to
/// resume I/O.
/// </para>
/// <para>
/// This must only be called on a [class@ServerMessage] which was created by the
/// [class@Server] and are currently doing I/O, such as those passed into a
/// [callback@ServerCallback] or emitted in a [signal@Server::request-read]
/// signal.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="msg">
/// a #SoupServerMessage associated with @server.
/// </param>

	public static T PauseMessage<T>(this T server, MentorLake.Soup.SoupServerMessageHandle msg) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_pause_message(server, msg);
		return server;
	}

/// <summary>
/// <para>
/// Removes @auth_domain from @server.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="auth_domain">
/// a #SoupAuthDomain
/// </param>

	public static T RemoveAuthDomain<T>(this T server, MentorLake.Soup.SoupAuthDomainHandle auth_domain) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_remove_auth_domain(server, auth_domain);
		return server;
	}

/// <summary>
/// <para>
/// Removes all handlers (early and normal) registered at @path.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="path">
/// the toplevel path for the handler
/// </param>

	public static T RemoveHandler<T>(this T server, string path) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_remove_handler(server, path);
		return server;
	}

/// <summary>
/// <para>
/// Removes support for WebSocket extension of type @extension_type (or any subclass of
/// @extension_type) from @server.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="extension_type">
/// a #GType
/// </param>

	public static T RemoveWebsocketExtension<T>(this T server, MentorLake.GObject.GType extension_type) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_remove_websocket_extension(server, extension_type);
		return server;
	}

/// <summary>
/// <para>
/// Sets @server&apos;s #GTlsAuthenticationMode to use for SSL/TLS client authentication.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="mode">
/// a #GTlsAuthenticationMode
/// </param>

	public static T SetTlsAuthMode<T>(this T server, MentorLake.Gio.GTlsAuthenticationMode mode) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_set_tls_auth_mode(server, mode);
		return server;
	}

/// <summary>
/// <para>
/// Sets @server up to do https, using the given SSL/TLS @certificate.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="certificate">
/// a #GTlsCertificate
/// </param>

	public static T SetTlsCertificate<T>(this T server, MentorLake.Gio.GTlsCertificateHandle certificate) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_set_tls_certificate(server, certificate);
		return server;
	}

/// <summary>
/// <para>
/// Sets @server&apos;s #GTlsDatabase to use for validating SSL/TLS client certificates.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="tls_database">
/// a #GTlsDatabase
/// </param>

	public static T SetTlsDatabase<T>(this T server, MentorLake.Gio.GTlsDatabaseHandle tls_database) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_set_tls_database(server, tls_database);
		return server;
	}

/// <summary>
/// <para>
/// Resumes I/O on @msg.
/// </para>
/// <para>
/// Use this to resume after calling [method@Server.pause_message], or after
/// adding a new chunk to a chunked response.
/// </para>
/// <para>
/// I/O won&apos;t actually resume until you return to the main loop.
/// </para>
/// <para>
/// This must only be called on a [class@ServerMessage] which was created by the
/// [class@Server] and are currently doing I/O, such as those passed into a
/// [callback@ServerCallback] or emitted in a [signal@Server::request-read]
/// signal.
/// </para>
/// </summary>

/// <param name="server">
/// a #SoupServer
/// </param>
/// <param name="msg">
/// a #SoupServerMessage associated with @server.
/// </param>

	public static T UnpauseMessage<T>(this T server, MentorLake.Soup.SoupServerMessageHandle msg) where T : SoupServerHandle
	{
		if (server.IsInvalid) throw new Exception("Invalid handle (SoupServerHandle)");
		SoupServerHandleExterns.soup_server_unpause_message(server, msg);
		return server;
	}

}

internal class SoupServerHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))]
	internal static extern MentorLake.Soup.SoupServerHandle soup_server_new(string optname1, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_accept_iostream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle local_addr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle remote_addr, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_add_auth_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle auth_domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_add_early_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, string path, MentorLake.Soup.SoupServerCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_add_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, string path, MentorLake.Soup.SoupServerCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_add_websocket_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, MentorLake.GObject.GType extension_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_add_websocket_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, string path, string origin, string[] protocols, MentorLake.Soup.SoupServerWebsocketCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_server_get_listeners([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsAuthenticationMode soup_server_get_tls_auth_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle soup_server_get_tls_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle soup_server_get_tls_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_server_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_is_https([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_listen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))] MentorLake.Gio.GSocketAddressHandle address, MentorLake.Soup.SoupServerListenOptions options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_listen_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, uint port, MentorLake.Soup.SoupServerListenOptions options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_listen_local([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, uint port, MentorLake.Soup.SoupServerListenOptions options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_listen_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))] MentorLake.Gio.GSocketHandle socket, MentorLake.Soup.SoupServerListenOptions options, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_pause_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_remove_auth_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthDomainHandle>))] MentorLake.Soup.SoupAuthDomainHandle auth_domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_remove_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, string path);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_remove_websocket_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, MentorLake.GObject.GType extension_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_set_tls_auth_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, MentorLake.Gio.GTlsAuthenticationMode mode);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_set_tls_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_set_tls_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle tls_database);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_unpause_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerHandle>))] MentorLake.Soup.SoupServerHandle server, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

}

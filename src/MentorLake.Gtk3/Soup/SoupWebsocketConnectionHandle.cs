namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The WebSocket Protocol
/// </para>
/// <para>
/// Provides support for the [WebSocket](http://tools.ietf.org/html/rfc6455)
/// protocol.
/// </para>
/// <para>
/// To connect to a WebSocket server, create a [class@Session] and call
/// [method@Session.websocket_connect_async]. To accept WebSocket
/// connections, create a [class@Server] and add a handler to it with
/// [method@Server.add_websocket_handler].
/// </para>
/// <para>
/// (Lower-level support is available via
/// [func@websocket_client_prepare_handshake] and
/// [func@websocket_client_verify_handshake], for handling the client side of the
/// WebSocket handshake, and [func@websocket_server_process_handshake] for
/// handling the server side.)
/// </para>
/// <para>
/// [class@WebsocketConnection] handles the details of WebSocket communication. You
/// can use [method@WebsocketConnection.send_text] and
/// [method@WebsocketConnection.send_binary] to send data, and the
/// [signal@WebsocketConnection::message] signal to receive data.
/// ([class@WebsocketConnection] currently only supports asynchronous I/O.)
/// </para>
/// </summary>

public class SoupWebsocketConnectionHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a [class@WebsocketConnection] on @stream with the given active @extensions.
/// </para>
/// <para>
/// This should be called after completing the handshake to begin using the WebSocket
/// protocol.
/// </para>
/// </summary>

/// <param name="stream">
/// a #GIOStream connected to the WebSocket server
/// </param>
/// <param name="uri">
/// the URI of the connection
/// </param>
/// <param name="type">
/// the type of connection (client/side)
/// </param>
/// <param name="origin">
/// the Origin of the client
/// </param>
/// <param name="protocol">
/// the subprotocol in use
/// </param>
/// <param name="extensions">
/// a #GList of #SoupWebsocketExtension objects
/// </param>
/// <return>
/// a new #SoupWebsocketConnection
/// </return>

	public static MentorLake.Soup.SoupWebsocketConnectionHandle New(MentorLake.Gio.GIOStreamHandle stream, MentorLake.GLib.GUriHandle uri, MentorLake.Soup.SoupWebsocketConnectionType type, string origin, string protocol, MentorLake.GLib.GListHandle extensions)
	{
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_new(stream, uri, type, origin, protocol, extensions);
	}

}
public static class SoupWebsocketConnectionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the connection has completely closed.
/// </para>
/// <para>
/// This happens either due to an orderly close from the peer, one
/// initiated via [method@WebsocketConnection.close] or a fatal error
/// condition that caused a close.
/// </para>
/// <para>
/// This signal will be emitted once.
/// </para>
/// </summary>

	public static IObservable<SoupWebsocketConnectionHandleSignalStructs.ClosedSignal> Signal_Closed(this SoupWebsocketConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupWebsocketConnectionHandleSignalStructs.ClosedSignal> obs) =>
		{
			SoupWebsocketConnectionHandleSignalDelegates.closed handler = ( MentorLake.Soup.SoupWebsocketConnectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupWebsocketConnectionHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
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
/// <summary>
/// <para>
/// This signal will be emitted during an orderly close.
/// </para>
/// </summary>

	public static IObservable<SoupWebsocketConnectionHandleSignalStructs.ClosingSignal> Signal_Closing(this SoupWebsocketConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupWebsocketConnectionHandleSignalStructs.ClosingSignal> obs) =>
		{
			SoupWebsocketConnectionHandleSignalDelegates.closing handler = ( MentorLake.Soup.SoupWebsocketConnectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupWebsocketConnectionHandleSignalStructs.ClosingSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closing", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when an error occurred on the WebSocket.
/// </para>
/// <para>
/// This may be fired multiple times. Fatal errors will be followed by
/// the [signal@WebsocketConnection::closed] signal being emitted.
/// </para>
/// </summary>

	public static IObservable<SoupWebsocketConnectionHandleSignalStructs.ErrorSignal> Signal_Error(this SoupWebsocketConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupWebsocketConnectionHandleSignalStructs.ErrorSignal> obs) =>
		{
			SoupWebsocketConnectionHandleSignalDelegates.error handler = ( MentorLake.Soup.SoupWebsocketConnectionHandle self,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupWebsocketConnectionHandleSignalStructs.ErrorSignal()
				{
					Self = self, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "error", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when we receive a message from the peer.
/// </para>
/// <para>
/// As a convenience, the @message data will always be
/// %NULL-terminated, but the NUL byte will not be included in
/// the length count.
/// </para>
/// </summary>

	public static IObservable<SoupWebsocketConnectionHandleSignalStructs.MessageSignal> Signal_Message(this SoupWebsocketConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupWebsocketConnectionHandleSignalStructs.MessageSignal> obs) =>
		{
			SoupWebsocketConnectionHandleSignalDelegates.message handler = ( MentorLake.Soup.SoupWebsocketConnectionHandle self,  int type,  MentorLake.GLib.GBytesHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupWebsocketConnectionHandleSignalStructs.MessageSignal()
				{
					Self = self, Type = type, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "message", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when we receive a Pong frame (solicited or
/// unsolicited) from the peer.
/// </para>
/// <para>
/// As a convenience, the @message data will always be
/// %NULL-terminated, but the NUL byte will not be included in
/// the length count.
/// </para>
/// </summary>

	public static IObservable<SoupWebsocketConnectionHandleSignalStructs.PongSignal> Signal_Pong(this SoupWebsocketConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupWebsocketConnectionHandleSignalStructs.PongSignal> obs) =>
		{
			SoupWebsocketConnectionHandleSignalDelegates.pong handler = ( MentorLake.Soup.SoupWebsocketConnectionHandle self,  MentorLake.GLib.GBytesHandle message,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupWebsocketConnectionHandleSignalStructs.PongSignal()
				{
					Self = self, Message = message, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pong", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class SoupWebsocketConnectionHandleSignalStructs
{

public class ClosedSignal
{

	public MentorLake.Soup.SoupWebsocketConnectionHandle Self;

	public IntPtr UserData;
}

public class ClosingSignal
{

	public MentorLake.Soup.SoupWebsocketConnectionHandle Self;

	public IntPtr UserData;
}

public class ErrorSignal
{

	public MentorLake.Soup.SoupWebsocketConnectionHandle Self;
/// <summary>
/// <para>
/// the error that occured
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}

public class MessageSignal
{

	public MentorLake.Soup.SoupWebsocketConnectionHandle Self;
/// <summary>
/// <para>
/// the type of message contents
/// </para>
/// </summary>

	public int Type;
/// <summary>
/// <para>
/// the message data
/// </para>
/// </summary>

	public MentorLake.GLib.GBytesHandle Message;

	public IntPtr UserData;
}

public class PongSignal
{

	public MentorLake.Soup.SoupWebsocketConnectionHandle Self;
/// <summary>
/// <para>
/// the application data (if any)
/// </para>
/// </summary>

	public MentorLake.GLib.GBytesHandle Message;

	public IntPtr UserData;
}
}

public static class SoupWebsocketConnectionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the connection has completely closed.
/// </para>
/// <para>
/// This happens either due to an orderly close from the peer, one
/// initiated via [method@WebsocketConnection.close] or a fatal error
/// condition that caused a close.
/// </para>
/// <para>
/// This signal will be emitted once.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal will be emitted during an orderly close.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an error occurred on the WebSocket.
/// </para>
/// <para>
/// This may be fired multiple times. Fatal errors will be followed by
/// the [signal@WebsocketConnection::closed] signal being emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="error">
/// the error that occured
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when we receive a message from the peer.
/// </para>
/// <para>
/// As a convenience, the @message data will always be
/// %NULL-terminated, but the NUL byte will not be included in
/// the length count.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="type">
/// the type of message contents
/// </param>
/// <param name="message">
/// the message data
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, int type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle message, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when we receive a Pong frame (solicited or
/// unsolicited) from the peer.
/// </para>
/// <para>
/// As a convenience, the @message data will always be
/// %NULL-terminated, but the NUL byte will not be included in
/// the length count.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="message">
/// the application data (if any)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pong([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle message, IntPtr user_data);

}


public static class SoupWebsocketConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Close the connection in an orderly fashion.
/// </para>
/// <para>
/// Note that until the [signal@WebsocketConnection::closed] signal fires, the connection
/// is not yet completely closed. The close message is not even sent until the
/// main loop runs.
/// </para>
/// <para>
/// The @code and @data are sent to the peer along with the close request.
/// If @code is %SOUP_WEBSOCKET_CLOSE_NO_STATUS a close message with no body
/// (without code and data) is sent.
/// Note that the @data must be UTF-8 valid.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="code">
/// close code
/// </param>
/// <param name="data">
/// close data
/// </param>

	public static T Close<T>(this T self, ushort code, string data) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_close(self, code, data);
		return self;
	}

/// <summary>
/// <para>
/// Get the close code received from the WebSocket peer.
/// </para>
/// <para>
/// This only becomes valid once the WebSocket is in the
/// %SOUP_WEBSOCKET_STATE_CLOSED state. The value will often be in the
/// [enum@WebsocketCloseCode] enumeration, but may also be an application
/// defined close code.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the close code or zero.
/// </return>

	public static ushort GetCloseCode(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_close_code(self);
	}

/// <summary>
/// <para>
/// Get the close data received from the WebSocket peer.
/// </para>
/// <para>
/// This only becomes valid once the WebSocket is in the
/// %SOUP_WEBSOCKET_STATE_CLOSED state. The data may be freed once
/// the main loop is run, so copy it if you need to keep it around.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the close data or %NULL
/// </return>

	public static string GetCloseData(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_close_data(self);
	}

/// <summary>
/// <para>
/// Get the connection type (client/server) of the connection.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the connection type
/// </return>

	public static MentorLake.Soup.SoupWebsocketConnectionType GetConnectionType(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_connection_type(self);
	}

/// <summary>
/// <para>
/// Get the extensions chosen via negotiation with the peer.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// a #GList of #SoupWebsocketExtension objects
/// </return>

	public static MentorLake.GLib.GListHandle GetExtensions(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_extensions(self);
	}

/// <summary>
/// <para>
/// Get the I/O stream the WebSocket is communicating over.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the WebSocket&apos;s I/O stream.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle GetIoStream(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_io_stream(self);
	}

/// <summary>
/// <para>
/// Gets the keepalive interval in seconds or 0 if disabled.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the keepalive interval.
/// </return>

	public static uint GetKeepaliveInterval(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_keepalive_interval(self);
	}

/// <summary>
/// <para>
/// Gets the keepalive pong timeout in seconds or 0 if disabled.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the keepalive pong timeout.
/// </return>

	public static uint GetKeepalivePongTimeout(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_keepalive_pong_timeout(self);
	}

/// <summary>
/// <para>
/// Gets the maximum payload size allowed for incoming packets.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the maximum payload size.
/// </return>

	public static ulong GetMaxIncomingPayloadSize(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_max_incoming_payload_size(self);
	}

/// <summary>
/// <para>
/// Get the origin of the WebSocket.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the origin
/// </return>

	public static string GetOrigin(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_origin(self);
	}

/// <summary>
/// <para>
/// Get the protocol chosen via negotiation with the peer.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the chosen protocol
/// </return>

	public static string GetProtocol(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_protocol(self);
	}

/// <summary>
/// <para>
/// Get the current state of the WebSocket.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the state
/// </return>

	public static MentorLake.Soup.SoupWebsocketState GetState(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_state(self);
	}

/// <summary>
/// <para>
/// Get the URI of the WebSocket.
/// </para>
/// <para>
/// For servers this represents the address of the WebSocket, and
/// for clients it is the address connected to.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <return>
/// the URI
/// </return>

	public static MentorLake.GLib.GUriHandle GetUri(this MentorLake.Soup.SoupWebsocketConnectionHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		return SoupWebsocketConnectionHandleExterns.soup_websocket_connection_get_uri(self);
	}

/// <summary>
/// <para>
/// Send a binary message to the peer.
/// </para>
/// <para>
/// If @length is 0, @data may be %NULL.
/// </para>
/// <para>
/// The message is queued to be sent and will be sent when the main loop
/// is run.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="data">
/// the message contents
/// </param>
/// <param name="length">
/// the length of @data
/// </param>

	public static T SendBinary<T>(this T self, byte[] data, UIntPtr length) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_send_binary(self, data, length);
		return self;
	}

/// <summary>
/// <para>
/// Send a message of the given @type to the peer. Note that this method,
/// allows to send text messages containing %NULL characters.
/// </para>
/// <para>
/// The message is queued to be sent and will be sent when the main loop
/// is run.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="type">
/// the type of message contents
/// </param>
/// <param name="message">
/// the message data as #GBytes
/// </param>

	public static T SendMessage<T>(this T self, MentorLake.Soup.SoupWebsocketDataType type, MentorLake.GLib.GBytesHandle message) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_send_message(self, type, message);
		return self;
	}

/// <summary>
/// <para>
/// Send a %NULL-terminated text (UTF-8) message to the peer.
/// </para>
/// <para>
/// If you need to send text messages containing %NULL characters use
/// [method@WebsocketConnection.send_message] instead.
/// </para>
/// <para>
/// The message is queued to be sent and will be sent when the main loop
/// is run.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="text">
/// the message contents
/// </param>

	public static T SendText<T>(this T self, string text) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_send_text(self, text);
		return self;
	}

/// <summary>
/// <para>
/// Sets the interval in seconds on when to send a ping message which will serve
/// as a keepalive message.
/// </para>
/// <para>
/// If set to 0 the keepalive message is disabled.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="interval">
/// the interval to send a ping message or 0 to disable it
/// </param>

	public static T SetKeepaliveInterval<T>(this T self, uint interval) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_set_keepalive_interval(self, interval);
		return self;
	}

/// <summary>
/// <para>
/// Set the timeout in seconds for when the absence of a pong from a keepalive
/// ping is assumed to be caused by a faulty connection.
/// </para>
/// <para>
/// If set to 0 then the absence of pongs from keepalive pings is ignored.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="pong_timeout">
/// the timeout in seconds
/// </param>

	public static T SetKeepalivePongTimeout<T>(this T self, uint pong_timeout) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_set_keepalive_pong_timeout(self, pong_timeout);
		return self;
	}

/// <summary>
/// <para>
/// Sets the maximum payload size allowed for incoming packets.
/// </para>
/// <para>
/// It does not limit the outgoing packet size.
/// </para>
/// </summary>

/// <param name="self">
/// the WebSocket
/// </param>
/// <param name="max_incoming_payload_size">
/// the maximum payload size
/// </param>

	public static T SetMaxIncomingPayloadSize<T>(this T self, ulong max_incoming_payload_size) where T : SoupWebsocketConnectionHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (SoupWebsocketConnectionHandle)");
		SoupWebsocketConnectionHandleExterns.soup_websocket_connection_set_max_incoming_payload_size(self, max_incoming_payload_size);
		return self;
	}

}

internal class SoupWebsocketConnectionHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))]
	internal static extern MentorLake.Soup.SoupWebsocketConnectionHandle soup_websocket_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, MentorLake.Soup.SoupWebsocketConnectionType type, string origin, string protocol, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle extensions);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, ushort code, string data);

	[DllImport(SoupLibrary.Name)]
	internal static extern ushort soup_websocket_connection_get_close_code([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_websocket_connection_get_close_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupWebsocketConnectionType soup_websocket_connection_get_connection_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle soup_websocket_connection_get_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle soup_websocket_connection_get_io_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_websocket_connection_get_keepalive_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_websocket_connection_get_keepalive_pong_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_websocket_connection_get_max_incoming_payload_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_websocket_connection_get_origin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_websocket_connection_get_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupWebsocketState soup_websocket_connection_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_websocket_connection_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_send_binary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, byte[] data, UIntPtr length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_send_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, MentorLake.Soup.SoupWebsocketDataType type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle message);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_send_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, string text);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_set_keepalive_interval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, uint interval);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_set_keepalive_pong_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, uint pong_timeout);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_connection_set_max_incoming_payload_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupWebsocketConnectionHandle>))] MentorLake.Soup.SoupWebsocketConnectionHandle self, ulong max_incoming_payload_size);

}

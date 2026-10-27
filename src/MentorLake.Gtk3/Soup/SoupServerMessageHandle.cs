namespace MentorLake.Soup;

/// <summary>
/// <para>
/// An HTTP server request and response pair.
/// </para>
/// <para>
/// A [class@ServerMessage] represents an HTTP message that is being sent or
/// received on a [class@Server].
/// </para>
/// <para>
/// [class@Server] will create [class@ServerMessage]s automatically for
/// incoming requests, which your application will receive via handlers.
/// </para>
/// <para>
/// Note that libsoup&apos;s terminology here does not quite match the HTTP
/// specification: in RFC 2616, an &quot;HTTP-message&quot; is *either* a Request, *or* a
/// Response. In libsoup, a [class@ServerMessage] combines both the request and the
/// response.
/// </para>
/// </summary>

public class SoupServerMessageHandle : GObjectHandle
{
}
public static class SoupServerMessageHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake
/// after client TLS certificate has been received.
/// You can return %TRUE to accept @tls_certificate despite
/// @tls_errors.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.AcceptCertificateSignal> Signal_AcceptCertificate(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.AcceptCertificateSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.accept_certificate handler = ( MentorLake.Soup.SoupServerMessageHandle self,  MentorLake.Gio.GTlsCertificateHandle tls_peer_certificate,  MentorLake.Gio.GTlsCertificateFlags tls_peer_errors,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.AcceptCertificateSignal()
				{
					Self = self, TlsPeerCertificate = tls_peer_certificate, TlsPeerErrors = tls_peer_errors, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accept-certificate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the @msg&apos;s socket is connected and the TLS handshake completed.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.ConnectedSignal> Signal_Connected(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.ConnectedSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.connected handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.ConnectedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "connected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the @msg&apos;s socket is disconnected.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.DisconnectedSignal> Signal_Disconnected(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.DisconnectedSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.disconnected handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.DisconnectedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "disconnected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when all HTTP processing is finished for a message.
/// (After [signal@ServerMessage::wrote-body]).
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.FinishedSignal> Signal_Finished(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.FinishedSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.finished handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.FinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after receiving the complete request body.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.GotBodySignal> Signal_GotBody(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.GotBodySignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.got_body handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.GotBodySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-body", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after receiving a chunk of a message body.
/// </para>
/// <para>
/// Note that &quot;chunk&quot; in this context means any subpiece of the body, not
/// necessarily the specific HTTP 1.1 chunks sent by the other side.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.GotChunkSignal> Signal_GotChunk(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.GotChunkSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.got_chunk handler = ( MentorLake.Soup.SoupServerMessageHandle self,  MentorLake.GLib.GBytesHandle chunk,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.GotChunkSignal()
				{
					Self = self, Chunk = chunk, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-chunk", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after receiving the Request-Line and request headers.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.GotHeadersSignal> Signal_GotHeaders(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.GotHeadersSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.got_headers handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.GotHeadersSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-headers", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing the complete response body for a
/// message.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.WroteBodySignal> Signal_WroteBody(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.WroteBodySignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.wrote_body handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.WroteBodySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrote-body", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing a portion of the message
/// body to the network.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.WroteBodyDataSignal> Signal_WroteBodyData(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.WroteBodyDataSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.wrote_body_data handler = ( MentorLake.Soup.SoupServerMessageHandle self,  uint chunk_size,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.WroteBodyDataSignal()
				{
					Self = self, ChunkSize = chunk_size, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrote-body-data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing a body chunk for a message.
/// </para>
/// <para>
/// Note that this signal is not parallel to
/// [signal@ServerMessage::got-chunk]; it is emitted only when a complete
/// chunk (added with [method@MessageBody.append] or
/// [method@MessageBody.append_bytes] has been written. To get
/// more useful continuous progress information, use
/// [signal@ServerMessage::wrote-body-data].
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.WroteChunkSignal> Signal_WroteChunk(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.WroteChunkSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.wrote_chunk handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.WroteChunkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrote-chunk", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing the response headers for a
/// message.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.WroteHeadersSignal> Signal_WroteHeaders(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.WroteHeadersSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.wrote_headers handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.WroteHeadersSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrote-headers", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing a 1xx (Informational) response.
/// </para>
/// </summary>

	public static IObservable<SoupServerMessageHandleSignalStructs.WroteInformationalSignal> Signal_WroteInformational(this SoupServerMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupServerMessageHandleSignalStructs.WroteInformationalSignal> obs) =>
		{
			SoupServerMessageHandleSignalDelegates.wrote_informational handler = ( MentorLake.Soup.SoupServerMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupServerMessageHandleSignalStructs.WroteInformationalSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrote-informational", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class SoupServerMessageHandleSignalStructs
{

public class AcceptCertificateSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;
/// <summary>
/// <para>
/// the peer&apos;s #GTlsCertificate
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateHandle TlsPeerCertificate;
/// <summary>
/// <para>
/// the tls errors of @tls_certificate
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateFlags TlsPeerErrors;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to accept the TLS certificate and stop other
///   handlers from being invoked, or %FALSE to propagate the
///   event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ConnectedSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class DisconnectedSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class FinishedSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class GotBodySignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class GotChunkSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;
/// <summary>
/// <para>
/// the just-read chunk
/// </para>
/// </summary>

	public MentorLake.GLib.GBytesHandle Chunk;

	public IntPtr UserData;
}

public class GotHeadersSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class WroteBodySignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class WroteBodyDataSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;
/// <summary>
/// <para>
/// the number of bytes written
/// </para>
/// </summary>

	public uint ChunkSize;

	public IntPtr UserData;
}

public class WroteChunkSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class WroteHeadersSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}

public class WroteInformationalSignal
{

	public MentorLake.Soup.SoupServerMessageHandle Self;

	public IntPtr UserData;
}
}

public static class SoupServerMessageHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake
/// after client TLS certificate has been received.
/// You can return %TRUE to accept @tls_certificate despite
/// @tls_errors.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tls_peer_certificate">
/// the peer&apos;s #GTlsCertificate
/// </param>
/// <param name="tls_peer_errors">
/// the tls errors of @tls_certificate
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to accept the TLS certificate and stop other
///   handlers from being invoked, or %FALSE to propagate the
///   event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle tls_peer_certificate, MentorLake.Gio.GTlsCertificateFlags tls_peer_errors, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the @msg&apos;s socket is connected and the TLS handshake completed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void connected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the @msg&apos;s socket is disconnected.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void disconnected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when all HTTP processing is finished for a message.
/// (After [signal@ServerMessage::wrote-body]).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving the complete request body.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving a chunk of a message body.
/// </para>
/// <para>
/// Note that &quot;chunk&quot; in this context means any subpiece of the body, not
/// necessarily the specific HTTP 1.1 chunks sent by the other side.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="chunk">
/// the just-read chunk
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_chunk([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle chunk, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving the Request-Line and request headers.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing the complete response body for a
/// message.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing a portion of the message
/// body to the network.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="chunk_size">
/// the number of bytes written
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_body_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, uint chunk_size, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing a body chunk for a message.
/// </para>
/// <para>
/// Note that this signal is not parallel to
/// [signal@ServerMessage::got-chunk]; it is emitted only when a complete
/// chunk (added with [method@MessageBody.append] or
/// [method@MessageBody.append_bytes] has been written. To get
/// more useful continuous progress information, use
/// [signal@ServerMessage::wrote-body-data].
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_chunk([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing the response headers for a
/// message.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing a 1xx (Informational) response.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_informational([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle self, IntPtr user_data);

}


public static class SoupServerMessageHandleExtensions
{
/// <summary>
/// <para>
/// Get the HTTP version of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #SoupHTTPVersion.
/// </return>

	public static MentorLake.Soup.SoupHTTPVersion GetHttpVersion(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_http_version(msg);
	}

/// <summary>
/// <para>
/// Retrieves the [class@Gio.SocketAddress] associated with the local end
/// of a connection.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the #GSocketAddress
///   associated with the local end of a connection, it may be
///   %NULL if you used [method@Server.accept_iostream].
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetLocalAddress(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_local_address(msg);
	}

/// <summary>
/// <para>
/// Get the HTTP method of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the HTTP method.
/// </return>

	public static string GetMethod(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_method(msg);
	}

/// <summary>
/// <para>
/// Get the HTTP reason phrase of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage:
/// </param>
/// <return>
/// the reason phrase.
/// </return>

	public static string GetReasonPhrase(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_reason_phrase(msg);
	}

/// <summary>
/// <para>
/// Retrieves the [class@Gio.SocketAddress] associated with the remote end
/// of a connection.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the #GSocketAddress
///   associated with the remote end of a connection, it may be
///   %NULL if you used [method@Server.accept_iostream].
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_remote_address(msg);
	}

/// <summary>
/// <para>
/// Retrieves the IP address associated with the remote end of a
/// connection.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the IP address associated with the remote
///   end of a connection, it may be %NULL if you used
///   [method@Server.accept_iostream].
/// </return>

	public static string GetRemoteHost(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_remote_host(msg);
	}

/// <summary>
/// <para>
/// Get the request body of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #SoupMessageBody.
/// </return>

	public static MentorLake.Soup.SoupMessageBodyHandle GetRequestBody(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_request_body(msg);
	}

/// <summary>
/// <para>
/// Get the request headers of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #SoupMessageHeaders with the request headers.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetRequestHeaders(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_request_headers(msg);
	}

/// <summary>
/// <para>
/// Get the response body of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #SoupMessageBody.
/// </return>

	public static MentorLake.Soup.SoupMessageBodyHandle GetResponseBody(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_response_body(msg);
	}

/// <summary>
/// <para>
/// Get the response headers of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #SoupMessageHeaders with the response headers.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetResponseHeaders(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_response_headers(msg);
	}

/// <summary>
/// <para>
/// Retrieves the [class@Gio.Socket] that @msg is associated with.
/// </para>
/// <para>
/// If you are using this method to observe when multiple requests are
/// made on the same persistent HTTP connection (eg, as the ntlm-test
/// test program does), you will need to pay attention to socket
/// destruction as well (eg, by using weak references), so that you do
/// not get fooled when the allocator reuses the memory address of a
/// previously-destroyed socket to represent a new socket.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the #GSocket that @msg is
///   associated with, %NULL if you used [method@Server.accept_iostream].
/// </return>

	public static MentorLake.Gio.GSocketHandle GetSocket(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_socket(msg);
	}

/// <summary>
/// <para>
/// Get the HTTP status code of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the HTTP status code.
/// </return>

	public static uint GetStatus(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_status(msg);
	}

/// <summary>
/// <para>
/// Gets the peer&apos;s #GTlsCertificate associated with @msg&apos;s connection.
/// Note that this is not set yet during the emission of
/// SoupServerMessage::accept-certificate signal.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// @msg&apos;s TLS peer certificate,
///    or %NULL if @msg&apos;s connection is not SSL.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetTlsPeerCertificate(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_tls_peer_certificate(msg);
	}

/// <summary>
/// <para>
/// Gets the errors associated with validating @msg&apos;s TLS peer certificate.
/// Note that this is not set yet during the emission of
/// SoupServerMessage::accept-certificate signal.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// a #GTlsCertificateFlags with @msg&apos;s TLS peer certificate errors.
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetTlsPeerCertificateErrors(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_tls_peer_certificate_errors(msg);
	}

/// <summary>
/// <para>
/// Get @msg&apos;s URI.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// a #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle GetUri(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_get_uri(msg);
	}

/// <summary>
/// <para>
/// Gets if @msg represents an OPTIONS message with the path `*`.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// %TRUE if is an OPTIONS ping
/// </return>

	public static bool IsOptionsPing(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_is_options_ping(msg);
	}

/// <summary>
/// <para>
/// Pauses I/O on @msg.
/// </para>
/// <para>
/// This can be used when you need to return from the server handler without
/// having the full response ready yet. Use [method@ServerMessage.unpause] to
/// resume I/O.
/// </para>
/// </summary>

/// <param name="msg">
/// a SoupServerMessage
/// </param>

	public static T Pause<T>(this T msg) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_pause(msg);
		return msg;
	}

/// <summary>
/// <para>
/// Set the HTTP version of @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <param name="version">
/// a #SoupHTTPVersion
/// </param>

	public static T SetHttpVersion<T>(this T msg, MentorLake.Soup.SoupHTTPVersion version) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_set_http_version(msg, version);
		return msg;
	}

/// <summary>
/// <para>
/// Sets @msg&apos;s status_code to @status_code and adds a Location header
/// pointing to @redirect_uri. Use this from a [class@Server] when you
/// want to redirect the client to another URI.
/// </para>
/// <para>
/// @redirect_uri can be a relative URI, in which case it is
/// interpreted relative to @msg&apos;s current URI. In particular, if
/// @redirect_uri is just a path, it will replace the path
/// *and query* of @msg&apos;s URI.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <param name="status_code">
/// a 3xx status code
/// </param>
/// <param name="redirect_uri">
/// the URI to redirect @msg to
/// </param>

	public static T SetRedirect<T>(this T msg, uint status_code, string redirect_uri) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_set_redirect(msg, status_code, redirect_uri);
		return msg;
	}

/// <summary>
/// <para>
/// Convenience function to set the response body of a [class@ServerMessage]. If
/// @content_type is %NULL, the response body must be empty as well.
/// </para>
/// </summary>

/// <param name="msg">
/// the message
/// </param>
/// <param name="content_type">
/// MIME Content-Type of the body
/// </param>
/// <param name="resp_use">
/// a #SoupMemoryUse describing how to handle @resp_body
/// </param>
/// <param name="resp_body">
/// 
///   a data buffer containing the body of the message response.
/// </param>
/// <param name="resp_length">
/// the byte length of @resp_body.
/// </param>

	public static T SetResponse<T>(this T msg, string content_type, MentorLake.Soup.SoupMemoryUse resp_use, byte[] resp_body, UIntPtr resp_length) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_set_response(msg, content_type, resp_use, resp_body, resp_length);
		return msg;
	}

/// <summary>
/// <para>
/// Sets @msg&apos;s status code to @status_code.
/// </para>
/// <para>
/// If @status_code is a known value and @reason_phrase is %NULL, the
/// reason_phrase will be set automatically.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <param name="status_code">
/// an HTTP status code
/// </param>
/// <param name="reason_phrase">
/// a reason phrase
/// </param>

	public static T SetStatus<T>(this T msg, uint status_code, string reason_phrase) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_set_status(msg, status_code, reason_phrase);
		return msg;
	}

/// <summary>
/// <para>
/// &quot;Steals&quot; the HTTP connection associated with @msg from its [class@Server]. This
/// happens immediately, regardless of the current state of the connection; if
/// the response to @msg has not yet finished being sent, then it will be
/// discarded; you can steal the connection from a
/// [signal@ServerMessage::wrote-informational] or
/// [signal@ServerMessage::wrote-body] signal handler if you need to wait for
/// part or all of the response to be sent.
/// </para>
/// <para>
/// Note that when calling this function from C, @msg will most
/// likely be freed as a side effect.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupServerMessage
/// </param>
/// <return>
/// the #GIOStream formerly associated
///   with @msg (or %NULL if @msg was no longer associated with a
///   connection). No guarantees are made about what kind of #GIOStream
///   is returned.
/// </return>

	public static MentorLake.Gio.GIOStreamHandle StealConnection(this MentorLake.Soup.SoupServerMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		return SoupServerMessageHandleExterns.soup_server_message_steal_connection(msg);
	}

/// <summary>
/// <para>
/// Resumes I/O on @msg.
/// </para>
/// <para>
/// Use this to resume after calling [method@ServerMessage.pause], or after
/// adding a new chunk to a chunked response. I/O won&apos;t actually resume until you
/// return to the main loop.
/// </para>
/// </summary>

/// <param name="msg">
/// a SoupServerMessage
/// </param>

	public static T Unpause<T>(this T msg) where T : SoupServerMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupServerMessageHandle)");
		SoupServerMessageHandleExterns.soup_server_message_unpause(msg);
		return msg;
	}

}

internal class SoupServerMessageHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupHTTPVersion soup_server_message_get_http_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle soup_server_message_get_local_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_server_message_get_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_server_message_get_reason_phrase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle soup_server_message_get_remote_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_server_message_get_remote_host([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))]
	internal static extern MentorLake.Soup.SoupMessageBodyHandle soup_server_message_get_request_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_server_message_get_request_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageBodyHandle>))]
	internal static extern MentorLake.Soup.SoupMessageBodyHandle soup_server_message_get_response_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_server_message_get_response_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketHandle>))]
	internal static extern MentorLake.Gio.GSocketHandle soup_server_message_get_socket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_server_message_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle soup_server_message_get_tls_peer_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags soup_server_message_get_tls_peer_certificate_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_server_message_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_server_message_is_options_ping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_pause([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_set_http_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, MentorLake.Soup.SoupHTTPVersion version);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_set_redirect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, uint status_code, string redirect_uri);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_set_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string content_type, MentorLake.Soup.SoupMemoryUse resp_use, byte[] resp_body, UIntPtr resp_length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_set_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, uint status_code, string reason_phrase);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle soup_server_message_steal_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_server_message_unpause([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg);

}

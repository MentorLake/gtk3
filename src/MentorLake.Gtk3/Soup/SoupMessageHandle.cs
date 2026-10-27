namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Represents an HTTP message being sent or received.
/// </para>
/// <para>
/// A [class@Message] represents an HTTP message that is being sent or
/// received.
/// </para>
/// <para>
/// You would create a [class@Message] with [ctor@Message.new] or
/// [ctor@Message.new_from_uri], set up its fields appropriately, and send it.
/// </para>
/// <para>
/// [property@Message:status-code] will normally be a [enum@Status] value, eg,
/// %SOUP_STATUS_OK, though of course it might actually be an unknown status
/// code. [property@Message:reason-phrase] is the actual text returned from the
/// server, which may or may not correspond to the &quot;standard&quot; description of
/// @status_code. At any rate, it is almost certainly not localized, and not very
/// descriptive even if it is in the user&apos;s language; you should not use
/// [property@Message:reason-phrase] in user-visible messages. Rather, you should
/// look at [property@Message:status-code], and determine an end-user-appropriate
/// message based on that and on what you were trying to do.
/// </para>
/// <para>
/// Note that libsoup&apos;s terminology here does not quite match the HTTP
/// specification: in RFC 2616, an &quot;HTTP-message&quot; is *either* a Request, *or* a
/// Response. In libsoup, a [class@Message] combines both the request and the
/// response.
/// </para>
/// </summary>

public class SoupMessageHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new empty [class@Message], which will connect to @uri.
/// </para>
/// </summary>

/// <param name="method">
/// the HTTP method for the created request
/// </param>
/// <param name="uri_string">
/// the destination endpoint (as a string)
/// </param>
/// <return>
/// the new #SoupMessage (or %NULL if @uri
///   could not be parsed).
/// </return>

	public static MentorLake.Soup.SoupMessageHandle New(string method, string uri_string)
	{
		return SoupMessageHandleExterns.soup_message_new(method, uri_string);
	}

/// <summary>
/// <para>
/// Creates a new [class@Message] and sets it up to send the given @encoded_form
/// to @uri via @method. If @method is &quot;GET&quot;, it will include the form data
/// into @uri&apos;s query field, and if @method is &quot;POST&quot; or &quot;PUT&quot;, it will be set as
/// request body.
/// </para>
/// <para>
/// This function takes the ownership of @encoded_form, that will be released
/// with [func@GLib.free] when no longer in use. See also [func@form_encode],
/// [func@form_encode_hash] and [func@form_encode_datalist].
/// </para>
/// </summary>

/// <param name="method">
/// the HTTP method for the created request (GET, POST or PUT)
/// </param>
/// <param name="uri_string">
/// the destination endpoint (as a string)
/// </param>
/// <param name="encoded_form">
/// a encoded form
/// </param>
/// <return>
/// the new #SoupMessage, or %NULL if
///   @uri_string could not be parsed or @method is not &quot;GET, &quot;POST&quot; or &quot;PUT&quot;
/// </return>

	public static MentorLake.Soup.SoupMessageHandle NewFromEncodedForm(string method, string uri_string, string encoded_form)
	{
		return SoupMessageHandleExterns.soup_message_new_from_encoded_form(method, uri_string, encoded_form);
	}

/// <summary>
/// <para>
/// Creates a new [class@Message] and sets it up to send @multipart to
/// @uri_string via POST.
/// </para>
/// </summary>

/// <param name="uri_string">
/// the destination endpoint
/// </param>
/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <return>
/// the new #SoupMessage, or %NULL if @uri_string
///   could not be parsed
/// </return>

	public static MentorLake.Soup.SoupMessageHandle NewFromMultipart(string uri_string, MentorLake.Soup.SoupMultipartHandle multipart)
	{
		return SoupMessageHandleExterns.soup_message_new_from_multipart(uri_string, multipart);
	}

/// <summary>
/// <para>
/// Creates a new empty [class@Message], which will connect to @uri.
/// </para>
/// </summary>

/// <param name="method">
/// the HTTP method for the created request
/// </param>
/// <param name="uri">
/// the destination endpoint
/// </param>
/// <return>
/// the new #SoupMessage
/// </return>

	public static MentorLake.Soup.SoupMessageHandle NewFromUri(string method, MentorLake.GLib.GUriHandle uri)
	{
		return SoupMessageHandleExterns.soup_message_new_from_uri(method, uri);
	}

/// <summary>
/// <para>
/// Creates a new [class@Message] to send `OPTIONS *` to a server. The path of
/// @base_uri will be ignored.
/// </para>
/// </summary>

/// <param name="base_uri">
/// the destination endpoint
/// </param>
/// <return>
/// the new #SoupMessage
/// </return>

	public static MentorLake.Soup.SoupMessageHandle NewOptionsPing(MentorLake.GLib.GUriHandle base_uri)
	{
		return SoupMessageHandleExterns.soup_message_new_options_ping(base_uri);
	}

}
public static class SoupMessageHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake
/// after an unacceptable TLS certificate has been received.
/// </para>
/// <para>
/// You can return %TRUE to accept @tls_certificate despite
/// @tls_errors.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.AcceptCertificateSignal> Signal_AcceptCertificate(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.AcceptCertificateSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.accept_certificate handler = ( MentorLake.Soup.SoupMessageHandle self,  MentorLake.Gio.GTlsCertificateHandle tls_peer_certificate,  MentorLake.Gio.GTlsCertificateFlags tls_peer_errors,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.AcceptCertificateSignal()
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
/// Emitted when the message requires authentication.
/// </para>
/// <para>
/// If credentials are available call [method@Auth.authenticate] on
/// @auth. If these credentials fail, the signal will be emitted again,
/// with @retrying set to %TRUE, which will continue until you return
/// without calling [method@Auth.authenticate] on @auth.
/// </para>
/// <para>
/// Note that this may be emitted before @msg&apos;s body has been
/// fully read.
/// </para>
/// <para>
/// You can authenticate @auth asynchronously by calling
/// [method@GObject.Object.ref] on @auth and returning %TRUE. The operation will
/// complete once either [method@Auth.authenticate] or
/// [method@Auth.cancel] are called.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.AuthenticateSignal> Signal_Authenticate(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.AuthenticateSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.authenticate handler = ( MentorLake.Soup.SoupMessageHandle self,  MentorLake.Soup.SoupAuthHandle auth,  bool retrying,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.AuthenticateSignal()
				{
					Self = self, Auth = auth, Retrying = retrying, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "authenticate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted after [signal@Message::got-headers].
/// </para>
/// <para>
/// If content sniffing is disabled, or no content sniffing will be
/// performed, due to the sniffer deciding to trust the
/// Content-Type sent by the server, this signal is emitted
/// immediately after [signal@Message::got-headers], and @type is
/// %NULL.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.ContentSniffedSignal> Signal_ContentSniffed(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.ContentSniffedSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.content_sniffed handler = ( MentorLake.Soup.SoupMessageHandle self,  string type,  MentorLake.GLib.GHashTableHandle @params,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.ContentSniffedSignal()
				{
					Self = self, Type = type, Params = @params, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "content-sniffed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// </para>
/// <para>
/// (After [signal@Message::got_body]).
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.FinishedSignal> Signal_Finished(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.FinishedSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.finished handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.FinishedSignal()
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
/// Emitted after receiving the complete message response body.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.GotBodySignal> Signal_GotBody(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.GotBodySignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.got_body handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.GotBodySignal()
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
/// Emitted after reading a portion of the message
/// body from the network.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.GotBodyDataSignal> Signal_GotBodyData(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.GotBodyDataSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.got_body_data handler = ( MentorLake.Soup.SoupMessageHandle self,  uint chunk_size,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.GotBodyDataSignal()
				{
					Self = self, ChunkSize = chunk_size, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-body-data", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after receiving the Status-Line and response headers.
/// </para>
/// <para>
/// See also [method@Message.add_header_handler] and
/// [method@Message.add_status_code_handler], which can be used to
/// connect to a subset of emissions of this signal.
/// </para>
/// <para>
/// If you cancel or requeue @msg while processing this signal,
/// then the current HTTP I/O will be stopped after this signal
/// emission finished, and @msg&apos;s connection will be closed.
/// (If you need to requeue a message--eg, after handling
/// authentication or redirection--it is usually better to
/// requeue it from a [signal@Message::got-body] handler rather
/// than a [signal@Message::got_headers] handler, so that the
/// existing HTTP connection can be reused.)
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.GotHeadersSignal> Signal_GotHeaders(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.GotHeadersSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.got_headers handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.GotHeadersSignal()
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
/// Emitted after receiving a 1xx (Informational) response for
/// a (client-side) message.
/// </para>
/// <para>
/// The response_headers will be filled in with the headers associated
/// with the informational response; however, those header values will be
/// erased after this signal is done.
/// </para>
/// <para>
/// If you cancel or requeue @msg while processing this signal,
/// then the current HTTP I/O will be stopped after this signal
/// emission finished, and @msg&apos;s connection will be closed.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.GotInformationalSignal> Signal_GotInformational(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.GotInformationalSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.got_informational handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.GotInformationalSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-informational", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when [class@HSTSEnforcer] has upgraded the protocol
/// for @msg to HTTPS as a result of matching its domain with
/// a HSTS policy.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.HstsEnforcedSignal> Signal_HstsEnforced(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.HstsEnforcedSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.hsts_enforced handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.HstsEnforcedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "hsts-enforced", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted to indicate that some network-related event
/// related to @msg has occurred.
/// </para>
/// <para>
/// This essentially proxies the [signal@Gio.SocketClient::event] signal,
/// but only for events that occur while @msg &quot;owns&quot; the connection; if
/// @msg is sent on an existing persistent connection, then this signal
/// will not be emitted. (If you want to force the message to be sent on
/// a new connection, set the %SOUP_MESSAGE_NEW_CONNECTION flag on it.)
/// </para>
/// <para>
/// See [signal@Gio.SocketClient::event] for more information on what
/// the different values of @event correspond to, and what
/// @connection will be in each case.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.NetworkEventSignal> Signal_NetworkEvent(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.NetworkEventSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.network_event handler = ( MentorLake.Soup.SoupMessageHandle self,  MentorLake.Gio.GSocketClientEvent @event,  MentorLake.Gio.GIOStreamHandle connection,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.NetworkEventSignal()
				{
					Self = self, Event = @event, Connection = connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "network-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted during the @msg&apos;s connection TLS handshake when
/// @tls_connection requests a certificate from the client.
/// </para>
/// <para>
/// You can set the client certificate by calling
/// [method@Message.set_tls_client_certificate] and returning %TRUE. It&apos;s
/// possible to handle the request asynchornously by returning %TRUE and
/// call [method@Message.set_tls_client_certificate] later once the
/// certificate is available. Note that this signal is not emitted if
/// [property@Session:tls-interaction] was set, or if
/// [method@Message.set_tls_client_certificate] was called before the
/// connection TLS handshake started.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.RequestCertificateSignal> Signal_RequestCertificate(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.RequestCertificateSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.request_certificate handler = ( MentorLake.Soup.SoupMessageHandle self,  MentorLake.Gio.GTlsClientConnectionHandle tls_connection,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.RequestCertificateSignal()
				{
					Self = self, TlsConnection = tls_connection, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-certificate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted during the @msg&apos;s connection TLS handshake when
/// @tls_connection requests a certificate password from the client.
/// </para>
/// <para>
/// You can set the certificate password on @password, then call
/// [method@Message.tls_client_certificate_password_request_complete] and
/// return %TRUE to handle the signal synchronously. It&apos;s possible to
/// handle the request asynchornously by calling
/// [method@GObject.Object.ref] on @password, then returning %TRUE and
/// call
/// [method@Message.tls_client_certificate_password_request_complete]
/// later after setting the password on @password. Note that this signal
/// is not emitted if [property@Session:tls-interaction] was set.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.RequestCertificatePasswordSignal> Signal_RequestCertificatePassword(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.RequestCertificatePasswordSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.request_certificate_password handler = ( MentorLake.Soup.SoupMessageHandle self,  MentorLake.Gio.GTlsPasswordHandle tls_password,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.RequestCertificatePasswordSignal()
				{
					Self = self, TlsPassword = tls_password, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-certificate-password", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when a request that was already sent once is now
/// being sent again.
/// </para>
/// <para>
/// e.g. because the first attempt received a
/// redirection response, or because we needed to use
/// authentication.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.RestartedSignal> Signal_Restarted(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.RestartedSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.restarted handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.RestartedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "restarted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted just before a message is sent.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.StartingSignal> Signal_Starting(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.StartingSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.starting handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.StartingSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "starting", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted immediately after writing the complete body for a
/// message.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.WroteBodySignal> Signal_WroteBody(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.WroteBodySignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.wrote_body handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.WroteBodySignal()
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

	public static IObservable<SoupMessageHandleSignalStructs.WroteBodyDataSignal> Signal_WroteBodyData(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.WroteBodyDataSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.wrote_body_data handler = ( MentorLake.Soup.SoupMessageHandle self,  uint chunk_size,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.WroteBodyDataSignal()
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
/// Emitted immediately after writing the request headers for a
/// message.
/// </para>
/// </summary>

	public static IObservable<SoupMessageHandleSignalStructs.WroteHeadersSignal> Signal_WroteHeaders(this SoupMessageHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupMessageHandleSignalStructs.WroteHeadersSignal> obs) =>
		{
			SoupMessageHandleSignalDelegates.wrote_headers handler = ( MentorLake.Soup.SoupMessageHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupMessageHandleSignalStructs.WroteHeadersSignal()
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
}

public static class SoupMessageHandleSignalStructs
{

public class AcceptCertificateSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
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

public class AuthenticateSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the #SoupAuth to authenticate
/// </para>
/// </summary>

	public MentorLake.Soup.SoupAuthHandle Auth;
/// <summary>
/// <para>
/// %TRUE if this is the second (or later) attempt
/// </para>
/// </summary>

	public bool Retrying;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked
///   or %FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ContentSniffedSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the content type that we got from sniffing
/// </para>
/// </summary>

	public string Type;
/// <summary>
/// <para>
/// a #GHashTable with the parameters
/// </para>
/// </summary>

	public MentorLake.GLib.GHashTableHandle Params;

	public IntPtr UserData;
}

public class FinishedSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class GotBodySignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class GotBodyDataSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the number of bytes read
/// </para>
/// </summary>

	public uint ChunkSize;

	public IntPtr UserData;
}

public class GotHeadersSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class GotInformationalSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class HstsEnforcedSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class NetworkEventSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the network event
/// </para>
/// </summary>

	public MentorLake.Gio.GSocketClientEvent Event;
/// <summary>
/// <para>
/// the current state of the network connection
/// </para>
/// </summary>

	public MentorLake.Gio.GIOStreamHandle Connection;

	public IntPtr UserData;
}

public class RequestCertificateSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the #GTlsClientConnection
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsClientConnectionHandle TlsConnection;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to handle the request, or %FALSE to make the connection
///   fail with %G_TLS_ERROR_CERTIFICATE_REQUIRED.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RequestCertificatePasswordSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the #GTlsPassword
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsPasswordHandle TlsPassword;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to handle the request, or %FALSE to make the connection
///   fail with %G_TLS_ERROR_CERTIFICATE_REQUIRED.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RestartedSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class StartingSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class WroteBodySignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}

public class WroteBodyDataSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;
/// <summary>
/// <para>
/// the number of bytes written
/// </para>
/// </summary>

	public uint ChunkSize;

	public IntPtr UserData;
}

public class WroteHeadersSignal
{

	public MentorLake.Soup.SoupMessageHandle Self;

	public IntPtr UserData;
}
}

public static class SoupMessageHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake
/// after an unacceptable TLS certificate has been received.
/// </para>
/// <para>
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
public delegate bool accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle tls_peer_certificate, MentorLake.Gio.GTlsCertificateFlags tls_peer_errors, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the message requires authentication.
/// </para>
/// <para>
/// If credentials are available call [method@Auth.authenticate] on
/// @auth. If these credentials fail, the signal will be emitted again,
/// with @retrying set to %TRUE, which will continue until you return
/// without calling [method@Auth.authenticate] on @auth.
/// </para>
/// <para>
/// Note that this may be emitted before @msg&apos;s body has been
/// fully read.
/// </para>
/// <para>
/// You can authenticate @auth asynchronously by calling
/// [method@GObject.Object.ref] on @auth and returning %TRUE. The operation will
/// complete once either [method@Auth.authenticate] or
/// [method@Auth.cancel] are called.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="auth">
/// the #SoupAuth to authenticate
/// </param>
/// <param name="retrying">
/// %TRUE if this is the second (or later) attempt
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked
///   or %FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool authenticate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupAuthHandle>))] MentorLake.Soup.SoupAuthHandle auth, bool retrying, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted after [signal@Message::got-headers].
/// </para>
/// <para>
/// If content sniffing is disabled, or no content sniffing will be
/// performed, due to the sniffer deciding to trust the
/// Content-Type sent by the server, this signal is emitted
/// immediately after [signal@Message::got-headers], and @type is
/// %NULL.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="type">
/// the content type that we got from sniffing
/// </param>
/// <param name="@params">
/// a #GHashTable with the parameters
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void content_sniffed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle @params, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when all HTTP processing is finished for a message.
/// </para>
/// <para>
/// (After [signal@Message::got_body]).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving the complete message response body.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after reading a portion of the message
/// body from the network.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="chunk_size">
/// the number of bytes read
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_body_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, uint chunk_size, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving the Status-Line and response headers.
/// </para>
/// <para>
/// See also [method@Message.add_header_handler] and
/// [method@Message.add_status_code_handler], which can be used to
/// connect to a subset of emissions of this signal.
/// </para>
/// <para>
/// If you cancel or requeue @msg while processing this signal,
/// then the current HTTP I/O will be stopped after this signal
/// emission finished, and @msg&apos;s connection will be closed.
/// (If you need to requeue a message--eg, after handling
/// authentication or redirection--it is usually better to
/// requeue it from a [signal@Message::got-body] handler rather
/// than a [signal@Message::got_headers] handler, so that the
/// existing HTTP connection can be reused.)
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after receiving a 1xx (Informational) response for
/// a (client-side) message.
/// </para>
/// <para>
/// The response_headers will be filled in with the headers associated
/// with the informational response; however, those header values will be
/// erased after this signal is done.
/// </para>
/// <para>
/// If you cancel or requeue @msg while processing this signal,
/// then the current HTTP I/O will be stopped after this signal
/// emission finished, and @msg&apos;s connection will be closed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_informational([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when [class@HSTSEnforcer] has upgraded the protocol
/// for @msg to HTTPS as a result of matching its domain with
/// a HSTS policy.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hsts_enforced([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted to indicate that some network-related event
/// related to @msg has occurred.
/// </para>
/// <para>
/// This essentially proxies the [signal@Gio.SocketClient::event] signal,
/// but only for events that occur while @msg &quot;owns&quot; the connection; if
/// @msg is sent on an existing persistent connection, then this signal
/// will not be emitted. (If you want to force the message to be sent on
/// a new connection, set the %SOUP_MESSAGE_NEW_CONNECTION flag on it.)
/// </para>
/// <para>
/// See [signal@Gio.SocketClient::event] for more information on what
/// the different values of @event correspond to, and what
/// @connection will be in each case.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="@event">
/// the network event
/// </param>
/// <param name="connection">
/// the current state of the network connection
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void network_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, MentorLake.Gio.GSocketClientEvent @event, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle connection, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake when
/// @tls_connection requests a certificate from the client.
/// </para>
/// <para>
/// You can set the client certificate by calling
/// [method@Message.set_tls_client_certificate] and returning %TRUE. It&apos;s
/// possible to handle the request asynchornously by returning %TRUE and
/// call [method@Message.set_tls_client_certificate] later once the
/// certificate is available. Note that this signal is not emitted if
/// [property@Session:tls-interaction] was set, or if
/// [method@Message.set_tls_client_certificate] was called before the
/// connection TLS handshake started.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tls_connection">
/// the #GTlsClientConnection
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to handle the request, or %FALSE to make the connection
///   fail with %G_TLS_ERROR_CERTIFICATE_REQUIRED.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool request_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle tls_connection, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted during the @msg&apos;s connection TLS handshake when
/// @tls_connection requests a certificate password from the client.
/// </para>
/// <para>
/// You can set the certificate password on @password, then call
/// [method@Message.tls_client_certificate_password_request_complete] and
/// return %TRUE to handle the signal synchronously. It&apos;s possible to
/// handle the request asynchornously by calling
/// [method@GObject.Object.ref] on @password, then returning %TRUE and
/// call
/// [method@Message.tls_client_certificate_password_request_complete]
/// later after setting the password on @password. Note that this signal
/// is not emitted if [property@Session:tls-interaction] was set.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="tls_password">
/// the #GTlsPassword
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to handle the request, or %FALSE to make the connection
///   fail with %G_TLS_ERROR_CERTIFICATE_REQUIRED.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool request_certificate_password([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsPasswordHandle>))] MentorLake.Gio.GTlsPasswordHandle tls_password, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a request that was already sent once is now
/// being sent again.
/// </para>
/// <para>
/// e.g. because the first attempt received a
/// redirection response, or because we needed to use
/// authentication.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void restarted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted just before a message is sent.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void starting([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing the complete body for a
/// message.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);


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
public delegate void wrote_body_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, uint chunk_size, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted immediately after writing the request headers for a
/// message.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrote_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle self, IntPtr user_data);

}


public static class SoupMessageHandleExtensions
{
/// <summary>
/// <para>
/// Adds @flags to the set of @msg&apos;s flags.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="flags">
/// a set of #SoupMessageFlags values
/// </param>

	public static T AddFlags<T>(this T msg, MentorLake.Soup.SoupMessageFlags flags) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_add_flags(msg, flags);
		return msg;
	}

/// <summary>
/// <para>
/// Adds a signal handler to @msg for @signal.
/// </para>
/// <para>
/// Similar to [func@GObject.signal_connect], but the @callback will only be run
/// if @msg&apos;s incoming messages headers (that is, the `request_headers`) contain
/// a header named @header.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="signal">
/// signal to connect the handler to.
/// </param>
/// <param name="header">
/// HTTP response header to match against
/// </param>
/// <param name="callback">
/// the header handler
/// </param>
/// <param name="user_data">
/// data to pass to @handler_cb
/// </param>
/// <return>
/// the handler ID from [func@GObject.signal_connect]
/// </return>

	public static uint AddHeaderHandler(this MentorLake.Soup.SoupMessageHandle msg, string signal, string header, MentorLake.GObject.GCallback callback, IntPtr user_data)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_add_header_handler(msg, signal, header, callback, user_data);
	}

/// <summary>
/// <para>
/// Adds a signal handler to @msg for @signal.
/// </para>
/// <para>
/// Similar to [func@GObject.signal_connect], but the @callback will only be run
/// if @msg has the status @status_code.
/// </para>
/// <para>
/// @signal must be a signal that will be emitted after @msg&apos;s status
/// is set (this means it can&apos;t be a &quot;wrote&quot; signal).
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="signal">
/// signal to connect the handler to.
/// </param>
/// <param name="status_code">
/// status code to match against
/// </param>
/// <param name="callback">
/// the header handler
/// </param>
/// <param name="user_data">
/// data to pass to @handler_cb
/// </param>
/// <return>
/// the handler ID from [func@GObject.signal_connect]
/// </return>

	public static uint AddStatusCodeHandler(this MentorLake.Soup.SoupMessageHandle msg, string signal, uint status_code, MentorLake.GObject.GCallback callback, IntPtr user_data)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_add_status_code_handler(msg, signal, status_code, callback, user_data);
	}

/// <summary>
/// <para>
/// Disables the actions of [iface@SessionFeature]s with the
/// given @feature_type (or a subclass of that type) on @msg.
/// </para>
/// <para>
/// @msg is processed as though the feature(s) hadn&apos;t been added to the
/// session. Eg, passing #SOUP_TYPE_CONTENT_SNIFFER for @feature_type
/// will disable Content-Type sniffing on the message.
/// </para>
/// <para>
/// You must call this before queueing @msg on a session; calling it on
/// a message that has already been queued is undefined. In particular,
/// you cannot call this on a message that is being requeued after a
/// redirect or authentication.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="feature_type">
/// the #GType of a [iface@SessionFeature]
/// </param>

	public static T DisableFeature<T>(this T msg, MentorLake.GObject.GType feature_type) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_disable_feature(msg, feature_type);
		return msg;
	}

/// <summary>
/// <para>
/// Returns the unique idenfier for the last connection used.
/// </para>
/// <para>
/// This may be 0 if it was a cached resource or it has not gotten
/// a connection yet.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// An id or 0 if no connection.
/// </return>

	public static ulong GetConnectionId(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_connection_id(msg);
	}

/// <summary>
/// <para>
/// Gets @msg&apos;s first-party [struct@GLib.Uri].
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the @msg&apos;s first party #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle GetFirstParty(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_first_party(msg);
	}

/// <summary>
/// <para>
/// Gets the flags on @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the flags
/// </return>

	public static MentorLake.Soup.SoupMessageFlags GetFlags(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_flags(msg);
	}

/// <summary>
/// <para>
/// Returns whether HTTP/1 version is currently demanded for the @msg send.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// %TRUE, when HTTP/1 is demanded, %FALSE otherwise.
/// </return>

	public static bool GetForceHttp1(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_force_http1(msg);
	}

/// <summary>
/// <para>
/// Gets the HTTP version of @msg.
/// </para>
/// <para>
/// This is the minimum of the version from the request and the version from the
/// response.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the HTTP version
/// </return>

	public static MentorLake.Soup.SoupHTTPVersion GetHttpVersion(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_http_version(msg);
	}

/// <summary>
/// <para>
/// Gets whether @msg is intended to be used to send `OPTIONS *` to a server.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// %TRUE if the message is options ping, or %FALSE otherwise
/// </return>

	public static bool GetIsOptionsPing(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_is_options_ping(msg);
	}

/// <summary>
/// <para>
/// Returns if this message is set as a top level navigation.
/// </para>
/// <para>
/// Used for same-site policy checks.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// Whether the current request is a top-level navitation
/// </return>

	public static bool GetIsTopLevelNavigation(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_is_top_level_navigation(msg);
	}

/// <summary>
/// <para>
/// Returns the method of this message.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// A method such as %SOUP_METHOD_GET
/// </return>

	public static string GetMethod(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_method(msg);
	}

/// <summary>
/// <para>
/// Get the [struct@MessageMetrics] of @msg.
/// </para>
/// <para>
/// If the flag %SOUP_MESSAGE_COLLECT_METRICS is not enabled for @msg this will
/// return %NULL.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// a #SoupMessageMetrics
/// </return>

	public static MentorLake.Soup.SoupMessageMetricsHandle GetMetrics(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_metrics(msg);
	}

/// <summary>
/// <para>
/// Retrieves the [enum@MessagePriority].
/// </para>
/// <para>
/// If not set this value defaults to #SOUP_MESSAGE_PRIORITY_NORMAL.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the priority of the message.
/// </return>

	public static MentorLake.Soup.SoupMessagePriority GetPriority(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_priority(msg);
	}

/// <summary>
/// <para>
/// Returns the reason phrase for the status of this message.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// the phrase
/// </return>

	public static string GetReasonPhrase(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_reason_phrase(msg);
	}

/// <summary>
/// <para>
/// Get the remote [class@Gio.SocketAddress] of the connection associated with
/// the message.
/// </para>
/// <para>
/// The returned address can be %NULL if the connection hasn&apos;t been established
/// yet, or the resource was loaded from the disk cache. In case of proxy
/// connections, the remote address returned is a [class@Gio.ProxyAddress]. If
/// [property@Session:remote-connectable] is set the returned address id for the
/// connection to the session&apos;s remote connectable.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// a #GSocketAddress or %NULL if the connection
///     hasn&apos;t been established
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle GetRemoteAddress(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_remote_address(msg);
	}

/// <summary>
/// <para>
/// Returns the headers sent with the request.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// The [struct@MessageHeaders]
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetRequestHeaders(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_request_headers(msg);
	}

/// <summary>
/// <para>
/// Returns the headers recieved with the response.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// The [struct@MessageHeaders]
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle GetResponseHeaders(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_response_headers(msg);
	}

/// <summary>
/// <para>
/// Gets @msg&apos;s site for cookies #GUri.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the @msg&apos;s site for cookies #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle GetSiteForCookies(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_site_for_cookies(msg);
	}

/// <summary>
/// <para>
/// Returns the set status of this message.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <return>
/// The #SoupStatus
/// </return>

	public static MentorLake.Soup.SoupStatus GetStatus(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_status(msg);
	}

/// <summary>
/// <para>
/// Gets the name of the TLS ciphersuite negotiated for @msg&apos;s connection.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the name of the TLS ciphersuite,
///   or %NULL if @msg&apos;s connection is not SSL.
/// </return>

	public static string GetTlsCiphersuiteName(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_tls_ciphersuite_name(msg);
	}

/// <summary>
/// <para>
/// Gets the peer&apos;s [class@Gio.TlsCertificate] associated with @msg&apos;s connection.
/// </para>
/// <para>
/// Note that this is not set yet during the emission of
/// [signal@Message::accept-certificate] signal.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// @msg&apos;s TLS peer certificate,
///   or %NULL if @msg&apos;s connection is not SSL.
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetTlsPeerCertificate(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_tls_peer_certificate(msg);
	}

/// <summary>
/// <para>
/// Gets the errors associated with validating @msg&apos;s TLS peer certificate.
/// Note that this is not set yet during the emission of
/// [signal@Message::accept-certificate] signal.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// a #GTlsCertificateFlags with @msg&apos;s TLS peer certificate errors.
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetTlsPeerCertificateErrors(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_tls_peer_certificate_errors(msg);
	}

/// <summary>
/// <para>
/// Gets the TLS protocol version negotiated for @msg&apos;s connection.
/// </para>
/// <para>
/// If the message connection is not SSL, %G_TLS_PROTOCOL_VERSION_UNKNOWN is returned.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// a #GTlsProtocolVersion
/// </return>

	public static MentorLake.Gio.GTlsProtocolVersion GetTlsProtocolVersion(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_tls_protocol_version(msg);
	}

/// <summary>
/// <para>
/// Gets @msg&apos;s URI.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// the URI @msg is targeted for.
/// </return>

	public static MentorLake.GLib.GUriHandle GetUri(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_get_uri(msg);
	}

/// <summary>
/// <para>
/// Get whether [iface@SessionFeature]s of the given @feature_type
/// (or a subclass of that type) are disabled on @msg.
/// </para>
/// <para>
/// See [method@Message.disable_feature].
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="feature_type">
/// the #GType of a [iface@SessionFeature]
/// </param>
/// <return>
/// %TRUE if feature is disabled, or %FALSE otherwise.
/// </return>

	public static bool IsFeatureDisabled(this MentorLake.Soup.SoupMessageHandle msg, MentorLake.GObject.GType feature_type)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_is_feature_disabled(msg, feature_type);
	}

/// <summary>
/// <para>
/// Determines whether or not @msg&apos;s connection can be kept alive for
/// further requests after processing @msg.
/// </para>
/// <para>
/// The result is based on the HTTP version, Connection header, etc.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <return>
/// %TRUE or %FALSE.
/// </return>

	public static bool IsKeepalive(this MentorLake.Soup.SoupMessageHandle msg)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_is_keepalive(msg);
	}

/// <summary>
/// <para>
/// Queries if @flags are present in the set of @msg&apos;s flags.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="flags">
/// a set of #SoupMessageFlags values
/// </param>
/// <return>
/// %TRUE if @flags are enabled in @msg
/// </return>

	public static bool QueryFlags(this MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessageFlags flags)
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		return SoupMessageHandleExterns.soup_message_query_flags(msg, flags);
	}

/// <summary>
/// <para>
/// Removes @flags from the set of @msg&apos;s flags.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="flags">
/// a set of #SoupMessageFlags values
/// </param>

	public static T RemoveFlags<T>(this T msg, MentorLake.Soup.SoupMessageFlags flags) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_remove_flags(msg, flags);
		return msg;
	}

/// <summary>
/// <para>
/// Sets @first_party as the main document #GUri for @msg.
/// </para>
/// <para>
/// For details of when and how this is used refer to the documentation for
/// [enum@CookieJarAcceptPolicy].
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="first_party">
/// the #GUri for the @msg&apos;s first party
/// </param>

	public static T SetFirstParty<T>(this T msg, MentorLake.GLib.GUriHandle first_party) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_first_party(msg, first_party);
		return msg;
	}

/// <summary>
/// <para>
/// Sets the specified flags on @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="flags">
/// a set of #SoupMessageFlags values
/// </param>

	public static T SetFlags<T>(this T msg, MentorLake.Soup.SoupMessageFlags flags) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_flags(msg, flags);
		return msg;
	}

/// <summary>
/// <para>
/// Sets whether HTTP/1 version should be used when sending this message.
/// Some connections can still override it, if needed.
/// </para>
/// <para>
/// Note the value is unset after the message send is finished.
/// </para>
/// </summary>

/// <param name="msg">
/// The #SoupMessage
/// </param>
/// <param name="value">
/// value to set
/// </param>

	public static T SetForceHttp1<T>(this T msg, bool value) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_force_http1(msg, value);
		return msg;
	}

/// <summary>
/// <para>
/// Set whether @msg is intended to be used to send `OPTIONS *` to a server.
/// </para>
/// <para>
/// When set to %TRUE, the path of [property@Message:uri] will be ignored and
/// [property@Message:method] set to %SOUP_METHOD_OPTIONS.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="is_options_ping">
/// the value to set
/// </param>

	public static T SetIsOptionsPing<T>(this T msg, bool is_options_ping) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_is_options_ping(msg, is_options_ping);
		return msg;
	}

/// <summary>
/// <para>
/// Sets whether the current request is a top-level navitation.
/// </para>
/// <para>
/// See the [same-site spec](https://tools.ietf.org/html/draft-ietf-httpbis-cookie-same-site-00)
/// for more information.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="is_top_level_navigation">
/// if %TRUE indicate the current request is a top-level navigation
/// </param>

	public static T SetIsTopLevelNavigation<T>(this T msg, bool is_top_level_navigation) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_is_top_level_navigation(msg, is_top_level_navigation);
		return msg;
	}

/// <summary>
/// <para>
/// Set @msg&apos;s HTTP method to @method.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="method">
/// the value to set
/// </param>

	public static T SetMethod<T>(this T msg, string method) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_method(msg, method);
		return msg;
	}

/// <summary>
/// <para>
/// Sets the priority of a message.
/// </para>
/// <para>
/// Note that this won&apos;t have any effect unless used before the message is added
/// to the session&apos;s message processing queue.
/// </para>
/// <para>
/// The message will be placed just before any other previously added
/// message with lower priority (messages with the same priority are
/// processed on a FIFO basis).
/// </para>
/// <para>
/// Setting priorities does not currently work with synchronous messages
/// because in the synchronous/blocking case, priority ends up being determined
/// semi-randomly by thread scheduling.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="priority">
/// the #SoupMessagePriority
/// </param>

	public static T SetPriority<T>(this T msg, MentorLake.Soup.SoupMessagePriority priority) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_priority(msg, priority);
		return msg;
	}

/// <summary>
/// <para>
/// Set the request body of a [class@Message].
/// </para>
/// <para>
/// If @content_type is %NULL and @stream is not %NULL the Content-Type header will
/// not be changed if present.
/// The request body needs to be set again in case @msg is restarted
/// (in case of redirection or authentication).
/// </para>
/// </summary>

/// <param name="msg">
/// the message
/// </param>
/// <param name="content_type">
/// MIME Content-Type of the body, or %NULL if unknown
/// </param>
/// <param name="stream">
/// a #GInputStream to read the request body from
/// </param>
/// <param name="content_length">
/// the byte length of @stream or -1 if unknown
/// </param>

	public static T SetRequestBody<T>(this T msg, string content_type, MentorLake.Gio.GInputStreamHandle stream, UIntPtr content_length) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_request_body(msg, content_type, stream, content_length);
		return msg;
	}

/// <summary>
/// <para>
/// Set the request body of a [class@Message] from [struct@GLib.Bytes].
/// </para>
/// <para>
/// If @content_type is %NULL and @bytes is not %NULL the Content-Type header will
/// not be changed if present.
/// The request body needs to be set again in case @msg is restarted
/// (in case of redirection or authentication).
/// </para>
/// </summary>

/// <param name="msg">
/// the message
/// </param>
/// <param name="content_type">
/// MIME Content-Type of the body, or %NULL if unknown
/// </param>
/// <param name="bytes">
/// a #GBytes with the request body data
/// </param>

	public static T SetRequestBodyFromBytes<T>(this T msg, string content_type, MentorLake.GLib.GBytesHandle bytes) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_request_body_from_bytes(msg, content_type, bytes);
		return msg;
	}

/// <summary>
/// <para>
/// Sets @site_for_cookies as the policy URL for same-site cookies for @msg.
/// </para>
/// <para>
/// It is either the URL of the top-level document or %NULL depending on whether
/// the registrable domain of this document&apos;s URL matches the registrable domain
/// of its parent&apos;s/opener&apos;s URL. For the top-level document it is set to the
/// document&apos;s URL.
/// </para>
/// <para>
/// See the [same-site spec](https://tools.ietf.org/html/draft-ietf-httpbis-cookie-same-site-00)
/// for more information.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="site_for_cookies">
/// the #GUri for the @msg&apos;s site for cookies
/// </param>

	public static T SetSiteForCookies<T>(this T msg, MentorLake.GLib.GUriHandle site_for_cookies) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_site_for_cookies(msg, site_for_cookies);
		return msg;
	}

/// <summary>
/// <para>
/// Sets the @certificate to be used by @msg&apos;s connection when a
/// client certificate is requested during the TLS handshake.
/// </para>
/// <para>
/// You can call this as a response to [signal@Message::request-certificate]
/// signal, or before the connection is started. If @certificate is %NULL
/// the handshake will continue without providing a GTlsCertificate.
/// Note that the [class@Gio.TlsCertificate] set by this function will be ignored if
/// [property@Session:tls-interaction] is not %NULL.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="certificate">
/// the #GTlsCertificate to set, or %NULL
/// </param>

	public static T SetTlsClientCertificate<T>(this T msg, MentorLake.Gio.GTlsCertificateHandle certificate) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_tls_client_certificate(msg, certificate);
		return msg;
	}

/// <summary>
/// <para>
/// Sets @msg&apos;s URI to @uri.
/// </para>
/// <para>
/// If @msg has already been sent and you want to re-send it with the new URI,
/// you need to send it again.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="uri">
/// the new #GUri
/// </param>

	public static T SetUri<T>(this T msg, MentorLake.GLib.GUriHandle uri) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_set_uri(msg, uri);
		return msg;
	}

/// <summary>
/// <para>
/// Completes a certificate password request.
/// </para>
/// <para>
/// You must call this as a response to
/// [signal@Message::request-certificate-password] signal, to notify @msg that
/// the [class@Gio.TlsPassword] has already been updated.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>

	public static T TlsClientCertificatePasswordRequestComplete<T>(this T msg) where T : SoupMessageHandle
	{
		if (msg.IsInvalid) throw new Exception("Invalid handle (SoupMessageHandle)");
		SoupMessageHandleExterns.soup_message_tls_client_certificate_password_request_complete(msg);
		return msg;
	}

}

internal class SoupMessageHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_message_new(string method, string uri_string);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_message_new_from_encoded_form(string method, string uri_string, string encoded_form);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_message_new_from_multipart(string uri_string, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_message_new_from_uri(string method, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHandle soup_message_new_options_ping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle base_uri);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_add_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessageFlags flags);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_message_add_header_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string signal, string header, MentorLake.GObject.GCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_message_add_status_code_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string signal, uint status_code, MentorLake.GObject.GCallback callback, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_disable_feature([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern ulong soup_message_get_connection_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_message_get_first_party([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupMessageFlags soup_message_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_get_force_http1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupHTTPVersion soup_message_get_http_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_get_is_options_ping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_get_is_top_level_navigation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_get_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageMetricsHandle>))]
	internal static extern MentorLake.Soup.SoupMessageMetricsHandle soup_message_get_metrics([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupMessagePriority soup_message_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_get_reason_phrase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle soup_message_get_remote_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_message_get_request_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_message_get_response_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_message_get_site_for_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupStatus soup_message_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_get_tls_ciphersuite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle soup_message_get_tls_peer_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags soup_message_get_tls_peer_certificate_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsProtocolVersion soup_message_get_tls_protocol_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_message_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_is_feature_disabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.GObject.GType feature_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_is_keepalive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_query_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessageFlags flags);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_remove_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessageFlags flags);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_first_party([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle first_party);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessageFlags flags);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_force_http1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, bool value);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_is_options_ping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, bool is_options_ping);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_is_top_level_navigation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, bool is_top_level_navigation);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string method);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, MentorLake.Soup.SoupMessagePriority priority);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_request_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string content_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))] MentorLake.Gio.GInputStreamHandle stream, UIntPtr content_length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_request_body_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string content_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_site_for_cookies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle site_for_cookies);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_tls_client_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_set_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_tls_client_certificate_password_request_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

}

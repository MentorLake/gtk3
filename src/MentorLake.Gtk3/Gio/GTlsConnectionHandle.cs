namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsConnection` is the base TLS connection class type, which wraps
/// a [class@Gio.IOStream] and provides TLS encryption on top of it. Its
/// subclasses, [iface@Gio.TlsClientConnection] and
/// [iface@Gio.TlsServerConnection], implement client-side and server-side TLS,
/// respectively.
/// </para>
/// <para>
/// For DTLS (Datagram TLS) support, see [iface@Gio.DtlsConnection].
/// </para>
/// </summary>

public class GTlsConnectionHandle : GIOStreamHandle
{
}
public static class GTlsConnectionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted during the TLS handshake after the peer certificate has
/// been received. You can examine @peer_cert's certification path by
/// calling g_tls_certificate_get_issuer() on it.
/// </para>
/// <para>
/// For a client-side connection, @peer_cert is the server's
/// certificate, and the signal will only be emitted if the
/// certificate was not acceptable according to @conn's
/// #GTlsClientConnection:validation_flags. If you would like the
/// certificate to be accepted despite @errors, return %TRUE from the
/// signal handler. Otherwise, if no handler accepts the certificate,
/// the handshake will fail with %G_TLS_ERROR_BAD_CERTIFICATE.
/// </para>
/// <para>
/// GLib guarantees that if certificate verification fails, this signal
/// will be emitted with at least one error will be set in @errors, but
/// it does not guarantee that all possible errors will be set.
/// Accordingly, you may not safely decide to ignore any particular
/// type of error. For example, it would be incorrect to ignore
/// %G_TLS_CERTIFICATE_EXPIRED if you want to allow expired
/// certificates, because this could potentially be the only error flag
/// set even if other problems exist with the certificate.
/// </para>
/// <para>
/// For a server-side connection, @peer_cert is the certificate
/// presented by the client, if this was requested via the server's
/// #GTlsServerConnection:authentication_mode. On the server side,
/// the signal is always emitted when the client presents a
/// certificate, and the certificate will only be accepted if a
/// handler returns %TRUE.
/// </para>
/// <para>
/// Note that if this signal is emitted as part of asynchronous I/O
/// in the main thread, then you should not attempt to interact with
/// the user before returning from the signal handler. If you want to
/// let the user decide whether or not to accept the certificate, you
/// would have to return %FALSE from the signal handler on the first
/// attempt, and then after the connection attempt returns a
/// %G_TLS_ERROR_BAD_CERTIFICATE, you can interact with the user, and
/// if the user decides to accept the certificate, remember that fact,
/// create a new connection, and return %TRUE from the signal handler
/// the next time.
/// </para>
/// <para>
/// If you are doing I/O in another thread, you do not
/// need to worry about this, and can simply block in the signal
/// handler until the UI thread returns an answer.
/// </para>
/// </summary>

	public static IObservable<GTlsConnectionHandleSignalStructs.AcceptCertificateSignal> Signal_AcceptCertificate(this GTlsConnectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GTlsConnectionHandleSignalStructs.AcceptCertificateSignal> obs) =>
		{
			GTlsConnectionHandleSignalDelegates.accept_certificate handler = ( MentorLake.Gio.GTlsConnectionHandle self,  MentorLake.Gio.GTlsCertificateHandle peer_cert,  MentorLake.Gio.GTlsCertificateFlags errors,  IntPtr user_data) =>
			{
				

				var signalStruct = new GTlsConnectionHandleSignalStructs.AcceptCertificateSignal()
				{
					Self = self, PeerCert = peer_cert, Errors = errors, UserData = user_data
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
}

public static class GTlsConnectionHandleSignalStructs
{

public class AcceptCertificateSignal
{

	public MentorLake.Gio.GTlsConnectionHandle Self;
/// <summary>
/// <para>
/// the peer's #GTlsCertificate
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateHandle PeerCert;
/// <summary>
/// <para>
/// the problems with @peer_cert.
/// </para>
/// </summary>

	public MentorLake.Gio.GTlsCertificateFlags Errors;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to accept @peer_cert (which will also
/// immediately end the signal emission). %FALSE to allow the signal
/// emission to continue, which will cause the handshake to fail if
/// no one else overrides it.
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GTlsConnectionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted during the TLS handshake after the peer certificate has
/// been received. You can examine @peer_cert's certification path by
/// calling g_tls_certificate_get_issuer() on it.
/// </para>
/// <para>
/// For a client-side connection, @peer_cert is the server's
/// certificate, and the signal will only be emitted if the
/// certificate was not acceptable according to @conn's
/// #GTlsClientConnection:validation_flags. If you would like the
/// certificate to be accepted despite @errors, return %TRUE from the
/// signal handler. Otherwise, if no handler accepts the certificate,
/// the handshake will fail with %G_TLS_ERROR_BAD_CERTIFICATE.
/// </para>
/// <para>
/// GLib guarantees that if certificate verification fails, this signal
/// will be emitted with at least one error will be set in @errors, but
/// it does not guarantee that all possible errors will be set.
/// Accordingly, you may not safely decide to ignore any particular
/// type of error. For example, it would be incorrect to ignore
/// %G_TLS_CERTIFICATE_EXPIRED if you want to allow expired
/// certificates, because this could potentially be the only error flag
/// set even if other problems exist with the certificate.
/// </para>
/// <para>
/// For a server-side connection, @peer_cert is the certificate
/// presented by the client, if this was requested via the server's
/// #GTlsServerConnection:authentication_mode. On the server side,
/// the signal is always emitted when the client presents a
/// certificate, and the certificate will only be accepted if a
/// handler returns %TRUE.
/// </para>
/// <para>
/// Note that if this signal is emitted as part of asynchronous I/O
/// in the main thread, then you should not attempt to interact with
/// the user before returning from the signal handler. If you want to
/// let the user decide whether or not to accept the certificate, you
/// would have to return %FALSE from the signal handler on the first
/// attempt, and then after the connection attempt returns a
/// %G_TLS_ERROR_BAD_CERTIFICATE, you can interact with the user, and
/// if the user decides to accept the certificate, remember that fact,
/// create a new connection, and return %TRUE from the signal handler
/// the next time.
/// </para>
/// <para>
/// If you are doing I/O in another thread, you do not
/// need to worry about this, and can simply block in the signal
/// handler until the UI thread returns an answer.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="peer_cert">
/// the peer's #GTlsCertificate
/// </param>
/// <param name="errors">
/// the problems with @peer_cert.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to accept @peer_cert (which will also
/// immediately end the signal emission). %FALSE to allow the signal
/// emission to continue, which will cause the handshake to fail if
/// no one else overrides it.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors, IntPtr user_data);

}


public static class GTlsConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Used by #GTlsConnection implementations to emit the
/// #GTlsConnection::accept-certificate signal.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="peer_cert">
/// the peer's #GTlsCertificate
/// </param>
/// <param name="errors">
/// the problems with @peer_cert
/// </param>
/// <return>
/// %TRUE if one of the signal handlers has returned
///     %TRUE to accept @peer_cert
/// </return>

	public static bool EmitAcceptCertificate(this MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_emit_accept_certificate(conn, peer_cert, errors);
	}

/// <summary>
/// <para>
/// Gets @conn's certificate, as set by
/// g_tls_connection_set_certificate().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// @conn's certificate, or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetCertificate(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_certificate(conn);
	}

/// <summary>
/// <para>
/// Query the TLS backend for TLS channel binding data of @type for @conn.
/// </para>
/// <para>
/// This call retrieves TLS channel binding data as specified in RFC
/// [5056](https://tools.ietf.org/html/rfc5056), RFC
/// [5929](https://tools.ietf.org/html/rfc5929), and related RFCs.  The
/// binding data is returned in @data.  The @data is resized by the callee
/// using #GByteArray buffer management and will be freed when the @data
/// is destroyed by g_byte_array_unref(). If @data is %NULL, it will only
/// check whether TLS backend is able to fetch the data (e.g. whether @type
/// is supported by the TLS backend). It does not guarantee that the data
/// will be available though.  That could happen if TLS connection does not
/// support @type or the binding data is not available yet due to additional
/// negotiation or input required.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="type">
/// #GTlsChannelBindingType type of data to fetch
/// </param>
/// <param name="data">
/// #GByteArray is
///        filled with the binding data, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise
/// </return>

	public static bool GetChannelBindingData(this MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		var externCallResult = GTlsConnectionHandleExterns.g_tls_connection_get_channel_binding_data(conn, type, out data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the name of the current TLS ciphersuite, or %NULL if the
/// connection has not handshaked or has been closed. Beware that the TLS
/// backend may use any of multiple different naming conventions, because
/// OpenSSL and GnuTLS have their own ciphersuite naming conventions that
/// are different from each other and different from the standard, IANA-
/// registered ciphersuite names. The ciphersuite name is intended to be
/// displayed to the user for informative purposes only, and parsing it
/// is not recommended.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// The name of the current TLS ciphersuite, or %NULL
/// </return>

	public static string GetCiphersuiteName(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_ciphersuite_name(conn);
	}

/// <summary>
/// <para>
/// Gets the certificate database that @conn uses to verify
/// peer certificates. See g_tls_connection_set_database().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// the certificate database that @conn uses or %NULL
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle GetDatabase(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_database(conn);
	}

/// <summary>
/// <para>
/// Get the object that will be used to interact with the user. It will be used
/// for things like prompting the user for passwords. If %NULL is returned, then
/// no user interaction will occur for this connection.
/// </para>
/// </summary>

/// <param name="conn">
/// a connection
/// </param>
/// <return>
/// The interaction object.
/// </return>

	public static MentorLake.Gio.GTlsInteractionHandle GetInteraction(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_interaction(conn);
	}

/// <summary>
/// <para>
/// Gets the name of the application-layer protocol negotiated during
/// the handshake.
/// </para>
/// <para>
/// If the peer did not use the ALPN extension, or did not advertise a
/// protocol that matched one of @conn's protocols, or the TLS backend
/// does not support ALPN, then this will be %NULL. See
/// g_tls_connection_set_advertised_protocols().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// the negotiated protocol, or %NULL
/// </return>

	public static string GetNegotiatedProtocol(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_negotiated_protocol(conn);
	}

/// <summary>
/// <para>
/// Gets @conn's peer's certificate after the handshake has completed
/// or failed. (It is not set during the emission of
/// #GTlsConnection::accept-certificate.)
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// @conn's peer's certificate, or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetPeerCertificate(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_peer_certificate(conn);
	}

/// <summary>
/// <para>
/// Gets the errors associated with validating @conn's peer's
/// certificate, after the handshake has completed or failed. (It is
/// not set during the emission of #GTlsConnection::accept-certificate.)
/// </para>
/// <para>
/// See #GTlsConnection:peer-certificate-errors for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// @conn's peer's certificate errors
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetPeerCertificateErrors(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_peer_certificate_errors(conn);
	}

/// <summary>
/// <para>
/// Returns the current TLS protocol version, which may be
/// %G_TLS_PROTOCOL_VERSION_UNKNOWN if the connection has not handshaked, or
/// has been closed, or if the TLS backend has implemented a protocol version
/// that is not a recognized #GTlsProtocolVersion.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// The current TLS protocol version
/// </return>

	public static MentorLake.Gio.GTlsProtocolVersion GetProtocolVersion(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_protocol_version(conn);
	}

/// <summary>
/// <para>
/// Gets @conn rehandshaking mode. See
/// g_tls_connection_set_rehandshake_mode() for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// %G_TLS_REHANDSHAKE_SAFELY
/// </return>

	public static MentorLake.Gio.GTlsRehandshakeMode GetRehandshakeMode(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_rehandshake_mode(conn);
	}

/// <summary>
/// <para>
/// Tests whether or not @conn expects a proper TLS close notification
/// when the connection is closed. See
/// g_tls_connection_set_require_close_notify() for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// %TRUE if @conn requires a proper TLS close
/// notification.
/// </return>

	public static bool GetRequireCloseNotify(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_require_close_notify(conn);
	}

/// <summary>
/// <para>
/// Gets whether @conn uses the system certificate database to verify
/// peer certificates. See g_tls_connection_set_use_system_certdb().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <return>
/// whether @conn uses the system certificate database
/// </return>

	public static bool GetUseSystemCertdb(this MentorLake.Gio.GTlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		return GTlsConnectionHandleExterns.g_tls_connection_get_use_system_certdb(conn);
	}

/// <summary>
/// <para>
/// Attempts a TLS handshake on @conn.
/// </para>
/// <para>
/// On the client side, it is never necessary to call this method;
/// although the connection needs to perform a handshake after
/// connecting (or after sending a "STARTTLS"-type command),
/// #GTlsConnection will handle this for you automatically when you try
/// to send or receive data on the connection. You can call
/// g_tls_connection_handshake() manually if you want to know whether
/// the initial handshake succeeded or failed (as opposed to just
/// immediately trying to use @conn to read or write, in which case,
/// if it fails, it may not be possible to tell if it failed before or
/// after completing the handshake), but beware that servers may reject
/// client authentication after the handshake has completed, so a
/// successful handshake does not indicate the connection will be usable.
/// </para>
/// <para>
/// Likewise, on the server side, although a handshake is necessary at
/// the beginning of the communication, you do not need to call this
/// function explicitly unless you want clearer error reporting.
/// </para>
/// <para>
/// Previously, calling g_tls_connection_handshake() after the initial
/// handshake would trigger a rehandshake; however, this usage was
/// deprecated in GLib 2.60 because rehandshaking was removed from the
/// TLS protocol in TLS 1.3. Since GLib 2.64, calling this function after
/// the initial handshake will no longer do anything.
/// </para>
/// <para>
/// When using a #GTlsConnection created by #GSocketClient, the
/// #GSocketClient performs the initial handshake, so calling this
/// function manually is not recommended.
/// </para>
/// <para>
/// #GTlsConnection::accept_certificate may be emitted during the
/// handshake.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// success or failure
/// </return>

	public static bool Handshake(this MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		var externCallResult = GTlsConnectionHandleExterns.g_tls_connection_handshake(conn, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously performs a TLS handshake on @conn. See
/// g_tls_connection_handshake() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the handshake is complete
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T HandshakeAsync<T>(this T conn, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_handshake_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

/// <summary>
/// <para>
/// Finish an asynchronous TLS handshake operation. See
/// g_tls_connection_handshake() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure, in which
/// case @error will be set.
/// </return>

	public static bool HandshakeFinish(this MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		var externCallResult = GTlsConnectionHandleExterns.g_tls_connection_handshake_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the list of application-layer protocols to advertise that the
/// caller is willing to speak on this connection. The
/// Application-Layer Protocol Negotiation (ALPN) extension will be
/// used to negotiate a compatible protocol with the peer; use
/// g_tls_connection_get_negotiated_protocol() to find the negotiated
/// protocol after the handshake.  Specifying %NULL for the the value
/// of @protocols will disable ALPN negotiation.
/// </para>
/// <para>
/// See [IANA TLS ALPN Protocol IDs](https://www.iana.org/assignments/tls-extensiontype-values/tls-extensiontype-values.xhtml#alpn-protocol-ids)
/// for a list of registered protocol IDs.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="protocols">
/// a %NULL-terminated
///   array of ALPN protocol names (eg, "http/1.1", "h2"), or %NULL
/// </param>

	public static T SetAdvertisedProtocols<T>(this T conn, string[] protocols) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_advertised_protocols(conn, protocols);
		return conn;
	}

/// <summary>
/// <para>
/// This sets the certificate that @conn will present to its peer
/// during the TLS handshake. For a #GTlsServerConnection, it is
/// mandatory to set this, and that will normally be done at construct
/// time.
/// </para>
/// <para>
/// For a #GTlsClientConnection, this is optional. If a handshake fails
/// with %G_TLS_ERROR_CERTIFICATE_REQUIRED, that means that the server
/// requires a certificate, and if you try connecting again, you should
/// call this method first. You can call
/// g_tls_client_connection_get_accepted_cas() on the failed connection
/// to get a list of Certificate Authorities that the server will
/// accept certificates from.
/// </para>
/// <para>
/// (It is also possible that a server will allow the connection with
/// or without a certificate; in that case, if you don't provide a
/// certificate, you can tell that the server requested one by the fact
/// that g_tls_client_connection_get_accepted_cas() will return
/// non-%NULL.)
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="certificate">
/// the certificate to use for @conn
/// </param>

	public static T SetCertificate<T>(this T conn, MentorLake.Gio.GTlsCertificateHandle certificate) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_certificate(conn, certificate);
		return conn;
	}

/// <summary>
/// <para>
/// Sets the certificate database that is used to verify peer certificates.
/// This is set to the default database by default. See
/// g_tls_backend_get_default_database(). If set to %NULL, then
/// peer certificate validation will always set the
/// %G_TLS_CERTIFICATE_UNKNOWN_CA error (meaning
/// #GTlsConnection::accept-certificate will always be emitted on
/// client-side connections, unless that bit is not set in
/// #GTlsClientConnection:validation-flags).
/// </para>
/// <para>
/// There are nonintuitive security implications when using a non-default
/// database. See #GTlsConnection:database for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="database">
/// a #GTlsDatabase
/// </param>

	public static T SetDatabase<T>(this T conn, MentorLake.Gio.GTlsDatabaseHandle database) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_database(conn, database);
		return conn;
	}

/// <summary>
/// <para>
/// Set the object that will be used to interact with the user. It will be used
/// for things like prompting the user for passwords.
/// </para>
/// <para>
/// The @interaction argument will normally be a derived subclass of
/// #GTlsInteraction. %NULL can also be provided if no user interaction
/// should occur for this connection.
/// </para>
/// </summary>

/// <param name="conn">
/// a connection
/// </param>
/// <param name="interaction">
/// an interaction object, or %NULL
/// </param>

	public static T SetInteraction<T>(this T conn, MentorLake.Gio.GTlsInteractionHandle interaction) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_interaction(conn, interaction);
		return conn;
	}

/// <summary>
/// <para>
/// Since GLib 2.64, changing the rehandshake mode is no longer supported
/// and will have no effect. With TLS 1.3, rehandshaking has been removed from
/// the TLS protocol, replaced by separate post-handshake authentication and
/// rekey operations.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="mode">
/// the rehandshaking mode
/// </param>

	public static T SetRehandshakeMode<T>(this T conn, MentorLake.Gio.GTlsRehandshakeMode mode) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_rehandshake_mode(conn, mode);
		return conn;
	}

/// <summary>
/// <para>
/// Sets whether or not @conn expects a proper TLS close notification
/// before the connection is closed. If this is %TRUE (the default),
/// then @conn will expect to receive a TLS close notification from its
/// peer before the connection is closed, and will return a
/// %G_TLS_ERROR_EOF error if the connection is closed without proper
/// notification (since this may indicate a network error, or
/// man-in-the-middle attack).
/// </para>
/// <para>
/// In some protocols, the application will know whether or not the
/// connection was closed cleanly based on application-level data
/// (because the application-level data includes a length field, or is
/// somehow self-delimiting); in this case, the close notify is
/// redundant and sometimes omitted. (TLS 1.1 explicitly allows this;
/// in TLS 1.0 it is technically an error, but often done anyway.) You
/// can use g_tls_connection_set_require_close_notify() to tell @conn
/// to allow an "unannounced" connection close, in which case the close
/// will show up as a 0-length read, as in a non-TLS
/// #GSocketConnection, and it is up to the application to check that
/// the data has been fully received.
/// </para>
/// <para>
/// Note that this only affects the behavior when the peer closes the
/// connection; when the application calls g_io_stream_close() itself
/// on @conn, this will send a close notification regardless of the
/// setting of this property. If you explicitly want to do an unclean
/// close, you can close @conn's #GTlsConnection:base-io-stream rather
/// than closing @conn itself, but note that this may only be done when no other
/// operations are pending on @conn or the base I/O stream.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="require_close_notify">
/// whether or not to require close notification
/// </param>

	public static T SetRequireCloseNotify<T>(this T conn, bool require_close_notify) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_require_close_notify(conn, require_close_notify);
		return conn;
	}

/// <summary>
/// <para>
/// Sets whether @conn uses the system certificate database to verify
/// peer certificates. This is %TRUE by default. If set to %FALSE, then
/// peer certificate validation will always set the
/// %G_TLS_CERTIFICATE_UNKNOWN_CA error (meaning
/// #GTlsConnection::accept-certificate will always be emitted on
/// client-side connections, unless that bit is not set in
/// #GTlsClientConnection:validation-flags).
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsConnection
/// </param>
/// <param name="use_system_certdb">
/// whether to use the system certificate database
/// </param>

	public static T SetUseSystemCertdb<T>(this T conn, bool use_system_certdb) where T : GTlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsConnectionHandle)");
		GTlsConnectionHandleExterns.g_tls_connection_set_use_system_certdb(conn, use_system_certdb);
		return conn;
	}

}

internal class GTlsConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_emit_accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_connection_get_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_get_channel_binding_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_connection_get_ciphersuite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_connection_get_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))]
	internal static extern MentorLake.Gio.GTlsInteractionHandle g_tls_connection_get_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_tls_connection_get_negotiated_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_tls_connection_get_peer_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_connection_get_peer_certificate_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsProtocolVersion g_tls_connection_get_protocol_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsRehandshakeMode g_tls_connection_get_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_get_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_get_use_system_certdb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_handshake_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_connection_handshake_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_advertised_protocols([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, string[] protocols);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle database);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, MentorLake.Gio.GTlsRehandshakeMode mode);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, bool require_close_notify);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_connection_set_use_system_certdb([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsConnectionHandle>))] MentorLake.Gio.GTlsConnectionHandle conn, bool use_system_certdb);

}

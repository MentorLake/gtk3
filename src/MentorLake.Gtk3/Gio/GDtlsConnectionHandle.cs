namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDtlsConnection` is the base DTLS connection class type, which wraps
/// a [iface@Gio.DatagramBased] and provides DTLS encryption on top of it. Its
/// subclasses, [iface@Gio.DtlsClientConnection] and
/// [iface@Gio.DtlsServerConnection], implement client-side and server-side DTLS,
/// respectively.
/// </para>
/// <para>
/// For TLS support, see [class@Gio.TlsConnection].
/// </para>
/// <para>
/// As DTLS is datagram based, `GDtlsConnection` implements
/// [iface@Gio.DatagramBased], presenting a datagram-socket-like API for the
/// encrypted connection. This operates over a base datagram connection, which is
/// also a `GDatagramBased` ([property@Gio.DtlsConnection:base-socket]).
/// </para>
/// <para>
/// To close a DTLS connection, use [method@Gio.DtlsConnection.close].
/// </para>
/// <para>
/// Neither [iface@Gio.DtlsServerConnection] or [iface@Gio.DtlsClientConnection]
/// set the peer address on their base [iface@Gio.DatagramBased] if it is a
/// [class@Gio.Socket] — it is up to the caller to do that if they wish. If they
/// do not, and [method@Gio.Socket.close] is called on the base socket, the
/// `GDtlsConnection` will not raise a `G_IO_ERROR_NOT_CONNECTED` error on
/// further I/O.
/// </para>
/// </summary>

public interface GDtlsConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDtlsConnectionHandleImpl : BaseSafeHandle, GDtlsConnectionHandle
{
}

public static class GDtlsConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Close the DTLS connection. This is equivalent to calling
/// g_dtls_connection_shutdown() to shut down both sides of the connection.
/// </para>
/// <para>
/// Closing a #GDtlsConnection waits for all buffered but untransmitted data to
/// be sent before it completes. It then sends a `close_notify` DTLS alert to the
/// peer and may wait for a `close_notify` to be received from the peer. It does
/// not close the underlying #GDtlsConnection:base-socket; that must be closed
/// separately.
/// </para>
/// <para>
/// Once @conn is closed, all other operations will return %G_IO_ERROR_CLOSED.
/// Closing a #GDtlsConnection multiple times will not return an error.
/// </para>
/// <para>
/// #GDtlsConnections will be automatically closed when the last reference is
/// dropped, but you might want to call this function to make sure resources are
/// released as early as possible.
/// </para>
/// <para>
/// If @cancellable is cancelled, the #GDtlsConnection may be left
/// partially-closed and any pending untransmitted data may be lost. Call
/// g_dtls_connection_close() again to complete closing the #GDtlsConnection.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise
/// </return>

	public static bool Close(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_close(conn, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously close the DTLS connection. See g_dtls_connection_close() for
/// more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the close operation is complete
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T CloseAsync<T>(this T conn, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_close_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

/// <summary>
/// <para>
/// Finish an asynchronous TLS close operation. See g_dtls_connection_close()
/// for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure, in which
/// case @error will be set
/// </return>

	public static bool CloseFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_close_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Used by #GDtlsConnection implementations to emit the
/// #GDtlsConnection::accept-certificate signal.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="peer_cert">
/// the peer&apos;s #GTlsCertificate
/// </param>
/// <param name="errors">
/// the problems with @peer_cert
/// </param>
/// <return>
/// %TRUE if one of the signal handlers has returned
///     %TRUE to accept @peer_cert
/// </return>

	public static bool EmitAcceptCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_emit_accept_certificate(conn, peer_cert, errors);
	}

/// <summary>
/// <para>
/// Gets @conn&apos;s certificate, as set by
/// g_dtls_connection_set_certificate().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// @conn&apos;s certificate, or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_certificate(conn);
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
/// a #GDtlsConnection
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

	public static bool GetChannelBindingData(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_get_channel_binding_data(conn, type, out data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the name of the current DTLS ciphersuite, or %NULL if the
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
/// a #GDTlsConnection
/// </param>
/// <return>
/// The name of the current DTLS ciphersuite, or %NULL
/// </return>

	public static string GetCiphersuiteName(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_ciphersuite_name(conn);
	}

/// <summary>
/// <para>
/// Gets the certificate database that @conn uses to verify
/// peer certificates. See g_dtls_connection_set_database().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// the certificate database that @conn uses or %NULL
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle GetDatabase(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_database(conn);
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

	public static MentorLake.Gio.GTlsInteractionHandle GetInteraction(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_interaction(conn);
	}

/// <summary>
/// <para>
/// Gets the name of the application-layer protocol negotiated during
/// the handshake.
/// </para>
/// <para>
/// If the peer did not use the ALPN extension, or did not advertise a
/// protocol that matched one of @conn&apos;s protocols, or the TLS backend
/// does not support ALPN, then this will be %NULL. See
/// g_dtls_connection_set_advertised_protocols().
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// the negotiated protocol, or %NULL
/// </return>

	public static string GetNegotiatedProtocol(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_negotiated_protocol(conn);
	}

/// <summary>
/// <para>
/// Gets @conn&apos;s peer&apos;s certificate after the handshake has completed
/// or failed. (It is not set during the emission of
/// #GDtlsConnection::accept-certificate.)
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// @conn&apos;s peer&apos;s certificate, or %NULL
/// </return>

	public static MentorLake.Gio.GTlsCertificateHandle GetPeerCertificate(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_peer_certificate(conn);
	}

/// <summary>
/// <para>
/// Gets the errors associated with validating @conn&apos;s peer&apos;s
/// certificate, after the handshake has completed or failed. (It is
/// not set during the emission of #GDtlsConnection::accept-certificate.)
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// @conn&apos;s peer&apos;s certificate errors
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetPeerCertificateErrors(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_peer_certificate_errors(conn);
	}

/// <summary>
/// <para>
/// Returns the current DTLS protocol version, which may be
/// %G_TLS_PROTOCOL_VERSION_UNKNOWN if the connection has not handshaked, or
/// has been closed, or if the TLS backend has implemented a protocol version
/// that is not a recognized #GTlsProtocolVersion.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDTlsConnection
/// </param>
/// <return>
/// The current DTLS protocol version
/// </return>

	public static MentorLake.Gio.GTlsProtocolVersion GetProtocolVersion(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_protocol_version(conn);
	}

/// <summary>
/// <para>
/// Gets @conn rehandshaking mode. See
/// g_dtls_connection_set_rehandshake_mode() for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// %G_TLS_REHANDSHAKE_SAFELY
/// </return>

	public static MentorLake.Gio.GTlsRehandshakeMode GetRehandshakeMode(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_rehandshake_mode(conn);
	}

/// <summary>
/// <para>
/// Tests whether or not @conn expects a proper TLS close notification
/// when the connection is closed. See
/// g_dtls_connection_set_require_close_notify() for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <return>
/// %TRUE if @conn requires a proper TLS close notification.
/// </return>

	public static bool GetRequireCloseNotify(this MentorLake.Gio.GDtlsConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		return GDtlsConnectionHandleExterns.g_dtls_connection_get_require_close_notify(conn);
	}

/// <summary>
/// <para>
/// Attempts a TLS handshake on @conn.
/// </para>
/// <para>
/// On the client side, it is never necessary to call this method;
/// although the connection needs to perform a handshake after
/// connecting, #GDtlsConnection will handle this for you automatically
/// when you try to send or receive data on the connection. You can call
/// g_dtls_connection_handshake() manually if you want to know whether
/// the initial handshake succeeded or failed (as opposed to just
/// immediately trying to use @conn to read or write, in which case,
/// if it fails, it may not be possible to tell if it failed before
/// or after completing the handshake), but beware that servers may reject
/// client authentication after the handshake has completed, so a
/// successful handshake does not indicate the connection will be usable.
/// </para>
/// <para>
/// Likewise, on the server side, although a handshake is necessary at
/// the beginning of the communication, you do not need to call this
/// function explicitly unless you want clearer error reporting.
/// </para>
/// <para>
/// Previously, calling g_dtls_connection_handshake() after the initial
/// handshake would trigger a rehandshake; however, this usage was
/// deprecated in GLib 2.60 because rehandshaking was removed from the
/// TLS protocol in TLS 1.3. Since GLib 2.64, calling this function after
/// the initial handshake will no longer do anything.
/// </para>
/// <para>
/// #GDtlsConnection::accept_certificate may be emitted during the
/// handshake.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// success or failure
/// </return>

	public static bool Handshake(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_handshake(conn, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously performs a TLS handshake on @conn. See
/// g_dtls_connection_handshake() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
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

	public static T HandshakeAsync<T>(this T conn, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_handshake_async(conn, io_priority, cancellable, callback, user_data);
		return conn;
	}

/// <summary>
/// <para>
/// Finish an asynchronous TLS handshake operation. See
/// g_dtls_connection_handshake() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="result">
/// a #GAsyncResult.
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure, in which
/// case @error will be set.
/// </return>

	public static bool HandshakeFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_handshake_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the list of application-layer protocols to advertise that the
/// caller is willing to speak on this connection. The
/// Application-Layer Protocol Negotiation (ALPN) extension will be
/// used to negotiate a compatible protocol with the peer; use
/// g_dtls_connection_get_negotiated_protocol() to find the negotiated
/// protocol after the handshake.  Specifying %NULL for the the value
/// of @protocols will disable ALPN negotiation.
/// </para>
/// <para>
/// See [IANA TLS ALPN Protocol IDs](https://www.iana.org/assignments/tls-extensiontype-values/tls-extensiontype-values.xhtml#alpn-protocol-ids)
/// for a list of registered protocol IDs.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="protocols">
/// a %NULL-terminated
///   array of ALPN protocol names (eg, &quot;http/1.1&quot;, &quot;h2&quot;), or %NULL
/// </param>

	public static T SetAdvertisedProtocols<T>(this T conn, string[] protocols) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_advertised_protocols(conn, protocols);
		return conn;
	}

/// <summary>
/// <para>
/// This sets the certificate that @conn will present to its peer
/// during the TLS handshake. For a #GDtlsServerConnection, it is
/// mandatory to set this, and that will normally be done at construct
/// time.
/// </para>
/// <para>
/// For a #GDtlsClientConnection, this is optional. If a handshake fails
/// with %G_TLS_ERROR_CERTIFICATE_REQUIRED, that means that the server
/// requires a certificate, and if you try connecting again, you should
/// call this method first. You can call
/// g_dtls_client_connection_get_accepted_cas() on the failed connection
/// to get a list of Certificate Authorities that the server will
/// accept certificates from.
/// </para>
/// <para>
/// (It is also possible that a server will allow the connection with
/// or without a certificate; in that case, if you don&apos;t provide a
/// certificate, you can tell that the server requested one by the fact
/// that g_dtls_client_connection_get_accepted_cas() will return
/// non-%NULL.)
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="certificate">
/// the certificate to use for @conn
/// </param>

	public static T SetCertificate<T>(this T conn, MentorLake.Gio.GTlsCertificateHandle certificate) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_certificate(conn, certificate);
		return conn;
	}

/// <summary>
/// <para>
/// Sets the certificate database that is used to verify peer certificates.
/// This is set to the default database by default. See
/// g_tls_backend_get_default_database(). If set to %NULL, then
/// peer certificate validation will always set the
/// %G_TLS_CERTIFICATE_UNKNOWN_CA error (meaning
/// #GDtlsConnection::accept-certificate will always be emitted on
/// client-side connections, unless that bit is not set in
/// #GDtlsClientConnection:validation-flags).
/// </para>
/// <para>
/// There are nonintuitive security implications when using a non-default
/// database. See #GDtlsConnection:database for details.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="database">
/// a #GTlsDatabase
/// </param>

	public static T SetDatabase<T>(this T conn, MentorLake.Gio.GTlsDatabaseHandle database) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_database(conn, database);
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

	public static T SetInteraction<T>(this T conn, MentorLake.Gio.GTlsInteractionHandle interaction) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_interaction(conn, interaction);
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
/// a #GDtlsConnection
/// </param>
/// <param name="mode">
/// the rehandshaking mode
/// </param>

	public static T SetRehandshakeMode<T>(this T conn, MentorLake.Gio.GTlsRehandshakeMode mode) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_rehandshake_mode(conn, mode);
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
/// redundant and may be omitted. You
/// can use g_dtls_connection_set_require_close_notify() to tell @conn
/// to allow an &quot;unannounced&quot; connection close, in which case the close
/// will show up as a 0-length read, as in a non-TLS
/// #GDatagramBased, and it is up to the application to check that
/// the data has been fully received.
/// </para>
/// <para>
/// Note that this only affects the behavior when the peer closes the
/// connection; when the application calls g_dtls_connection_close_async() on
/// @conn itself, this will send a close notification regardless of the
/// setting of this property. If you explicitly want to do an unclean
/// close, you can close @conn&apos;s #GDtlsConnection:base-socket rather
/// than closing @conn itself.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="require_close_notify">
/// whether or not to require close notification
/// </param>

	public static T SetRequireCloseNotify<T>(this T conn, bool require_close_notify) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_set_require_close_notify(conn, require_close_notify);
		return conn;
	}

/// <summary>
/// <para>
/// Shut down part or all of a DTLS connection.
/// </para>
/// <para>
/// If @shutdown_read is %TRUE then the receiving side of the connection is shut
/// down, and further reading is disallowed. Subsequent calls to
/// g_datagram_based_receive_messages() will return %G_IO_ERROR_CLOSED.
/// </para>
/// <para>
/// If @shutdown_write is %TRUE then the sending side of the connection is shut
/// down, and further writing is disallowed. Subsequent calls to
/// g_datagram_based_send_messages() will return %G_IO_ERROR_CLOSED.
/// </para>
/// <para>
/// It is allowed for both @shutdown_read and @shutdown_write to be TRUE — this
/// is equivalent to calling g_dtls_connection_close().
/// </para>
/// <para>
/// If @cancellable is cancelled, the #GDtlsConnection may be left
/// partially-closed and any pending untransmitted data may be lost. Call
/// g_dtls_connection_shutdown() again to complete closing the #GDtlsConnection.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="shutdown_read">
/// %TRUE to stop reception of incoming datagrams
/// </param>
/// <param name="shutdown_write">
/// %TRUE to stop sending outgoing datagrams
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE otherwise
/// </return>

	public static bool Shutdown(this MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_shutdown(conn, shutdown_read, shutdown_write, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously shut down part or all of the DTLS connection. See
/// g_dtls_connection_shutdown() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="shutdown_read">
/// %TRUE to stop reception of incoming datagrams
/// </param>
/// <param name="shutdown_write">
/// %TRUE to stop sending outgoing datagrams
/// </param>
/// <param name="io_priority">
/// the [I/O priority](iface.AsyncResult.html#io-priority) of the request
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call when the shutdown operation is complete
/// </param>
/// <param name="user_data">
/// the data to pass to the callback function
/// </param>

	public static T ShutdownAsync<T>(this T conn, bool shutdown_read, bool shutdown_write, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GDtlsConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		GDtlsConnectionHandleExterns.g_dtls_connection_shutdown_async(conn, shutdown_read, shutdown_write, io_priority, cancellable, callback, user_data);
		return conn;
	}

/// <summary>
/// <para>
/// Finish an asynchronous TLS shutdown operation. See
/// g_dtls_connection_shutdown() for more information.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GDtlsConnection
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// %TRUE on success, %FALSE on failure, in which
/// case @error will be set
/// </return>

	public static bool ShutdownFinish(this MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsConnectionHandle)");
		var externCallResult = GDtlsConnectionHandleExterns.g_dtls_connection_shutdown_finish(conn, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDtlsConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_close_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_close_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_emit_accept_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle peer_cert, MentorLake.Gio.GTlsCertificateFlags errors);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_dtls_connection_get_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_get_channel_binding_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsChannelBindingType type, out MentorLake.GLib.GByteArray data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dtls_connection_get_ciphersuite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_dtls_connection_get_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))]
	internal static extern MentorLake.Gio.GTlsInteractionHandle g_dtls_connection_get_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dtls_connection_get_negotiated_protocol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))]
	internal static extern MentorLake.Gio.GTlsCertificateHandle g_dtls_connection_get_peer_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_dtls_connection_get_peer_certificate_errors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsProtocolVersion g_dtls_connection_get_protocol_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsRehandshakeMode g_dtls_connection_get_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_get_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_handshake_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_handshake_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_advertised_protocols([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, string[] protocols);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_certificate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsCertificateHandle>))] MentorLake.Gio.GTlsCertificateHandle certificate);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle database);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_interaction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsInteractionHandle>))] MentorLake.Gio.GTlsInteractionHandle interaction);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_rehandshake_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, MentorLake.Gio.GTlsRehandshakeMode mode);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_set_require_close_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool require_close_notify);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_connection_shutdown_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, bool shutdown_read, bool shutdown_write, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dtls_connection_shutdown_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsConnectionHandleImpl>))] MentorLake.Gio.GDtlsConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}

namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GTlsClientConnection` is the client-side subclass of
/// [class@Gio.TlsConnection], representing a client-side TLS connection.
/// </para>
/// </summary>

public interface GTlsClientConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTlsClientConnectionHandleImpl : BaseSafeHandle, GTlsClientConnectionHandle
{
}

public static class GTlsClientConnectionHandleExtensions
{
/// <summary>
/// <para>
/// Possibly copies session state from one connection to another, for use
/// in TLS session resumption. This is not normally needed, but may be
/// used when the same session needs to be used between different
/// endpoints, as is required by some protocols, such as FTP over TLS.
/// @source should have already completed a handshake and, since TLS 1.3,
/// it should have been used to read data at least once. @conn should not
/// have completed a handshake.
/// </para>
/// <para>
/// It is not possible to know whether a call to this function will
/// actually do anything. Because session resumption is normally used
/// only for performance benefit, the TLS backend might not implement
/// this function. Even if implemented, it may not actually succeed in
/// allowing @conn to resume @source&apos;s TLS session, because the server
/// may not have sent a session resumption token to @source, or it may
/// refuse to accept the token from @conn. There is no way to know
/// whether a call to this function is actually successful.
/// </para>
/// <para>
/// Using this function is not required to benefit from session
/// resumption. If the TLS backend supports session resumption, the
/// session will be resumed automatically if it is possible to do so
/// without weakening the privacy guarantees normally provided by TLS,
/// without need to call this function. For example, with TLS 1.3,
/// a session ticket will be automatically copied from any
/// #GTlsClientConnection that has previously received session tickets
/// from the server, provided a ticket is available that has not
/// previously been used for session resumption, since session ticket
/// reuse would be a privacy weakness. Using this function causes the
/// ticket to be copied without regard for privacy considerations.
/// </para>
/// </summary>

/// <param name="conn">
/// a #GTlsClientConnection
/// </param>
/// <param name="source">
/// a #GTlsClientConnection
/// </param>

	public static T CopySessionState<T>(this T conn, MentorLake.Gio.GTlsClientConnectionHandle source) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_copy_session_state(conn, source);
		return conn;
	}

/// <summary>
/// <para>
/// Gets the list of distinguished names of the Certificate Authorities
/// that the server will accept certificates from. This will be set
/// during the TLS handshake if the server requests a certificate.
/// Otherwise, it will be %NULL.
/// </para>
/// <para>
/// Each item in the list is a #GByteArray which contains the complete
/// subject DN of the certificate authority.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <return>
/// the list of
/// CA DNs. You should unref each element with g_byte_array_unref() and then
/// the free the list with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle GetAcceptedCas(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_accepted_cas(conn);
	}

/// <summary>
/// <para>
/// Gets @conn&apos;s expected server identity
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <return>
/// a #GSocketConnectable describing the
/// expected server identity, or %NULL if the expected identity is not
/// known.
/// </return>

	public static MentorLake.Gio.GSocketConnectableHandle GetServerIdentity(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_server_identity(conn);
	}

/// <summary>
/// <para>
/// SSL 3.0 is no longer supported. See
/// g_tls_client_connection_set_use_ssl3() for details.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <return>
/// %FALSE
/// </return>

	public static bool GetUseSsl3(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_use_ssl3(conn);
	}

/// <summary>
/// <para>
/// Gets @conn&apos;s validation flags
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GTlsClientConnection:validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <return>
/// the validation flags
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetValidationFlags(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_validation_flags(conn);
	}

/// <summary>
/// <para>
/// Sets @conn&apos;s expected server identity, which is used both to tell
/// servers on virtual hosts which certificate to present, and also
/// to let @conn know what name to look for in the certificate when
/// performing %G_TLS_CERTIFICATE_BAD_IDENTITY validation, if enabled.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <param name="identity">
/// a #GSocketConnectable describing the expected server identity
/// </param>

	public static T SetServerIdentity<T>(this T conn, MentorLake.Gio.GSocketConnectableHandle identity) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

/// <summary>
/// <para>
/// Since GLib 2.42.1, SSL 3.0 is no longer supported.
/// </para>
/// <para>
/// From GLib 2.42.1 through GLib 2.62, this function could be used to
/// force use of TLS 1.0, the lowest-supported TLS protocol version at
/// the time. In the past, this was needed to connect to broken TLS
/// servers that exhibited protocol version intolerance. Such servers
/// are no longer common, and using TLS 1.0 is no longer considered
/// acceptable.
/// </para>
/// <para>
/// Since GLib 2.64, this function does nothing.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <param name="use_ssl3">
/// a #gboolean, ignored
/// </param>

	public static T SetUseSsl3<T>(this T conn, bool use_ssl3) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_use_ssl3(conn, use_ssl3);
		return conn;
	}

/// <summary>
/// <para>
/// Sets @conn&apos;s validation flags, to override the default set of
/// checks performed when validating a server certificate. By default,
/// %G_TLS_CERTIFICATE_VALIDATE_ALL is used.
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GTlsClientConnection:validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GTlsClientConnection
/// </param>
/// <param name="flags">
/// the #GTlsCertificateFlags to use
/// </param>

	public static T SetValidationFlags<T>(this T conn, MentorLake.Gio.GTlsCertificateFlags flags) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

/// <summary>
/// <para>
/// Creates a new #GTlsClientConnection wrapping @base_io_stream (which
/// must have pollable input and output streams) which is assumed to
/// communicate with the server identified by @server_identity.
/// </para>
/// <para>
/// See the documentation for #GTlsConnection:base-io-stream for restrictions
/// on when application code can run operations on the @base_io_stream after
/// this function has returned.
/// </para>
/// </summary>

/// <param name="base_io_stream">
/// the #GIOStream to wrap
/// </param>
/// <param name="server_identity">
/// the expected identity of the server
/// </param>
/// <return>
/// the new
/// #GTlsClientConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GIOStreamHandle New(MentorLake.Gio.GIOStreamHandle base_io_stream, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GTlsClientConnectionHandleExterns.g_tls_client_connection_new(base_io_stream, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GTlsClientConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_client_connection_copy_session_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle source);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_tls_client_connection_get_accepted_cas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_tls_client_connection_get_server_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_client_connection_get_use_ssl3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_tls_client_connection_get_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_client_connection_set_server_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_client_connection_set_use_ssl3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn, bool use_ssl3);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_client_connection_set_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsClientConnectionHandleImpl>))] MentorLake.Gio.GTlsClientConnectionHandle conn, MentorLake.Gio.GTlsCertificateFlags flags);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))]
	internal static extern MentorLake.Gio.GIOStreamHandle g_tls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOStreamHandle>))] MentorLake.Gio.GIOStreamHandle base_io_stream, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

}

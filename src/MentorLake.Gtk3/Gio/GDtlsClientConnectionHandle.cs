namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDtlsClientConnection` is the client-side subclass of
/// [iface@Gio.DtlsConnection], representing a client-side DTLS connection.
/// </para>
/// </summary>

public interface GDtlsClientConnectionHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GDtlsClientConnectionHandleImpl : BaseSafeHandle, GDtlsClientConnectionHandle
{
}

public static class GDtlsClientConnectionHandleExtensions
{
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
/// the #GDtlsClientConnection
/// </param>
/// <return>
/// the list of
/// CA DNs. You should unref each element with g_byte_array_unref() and then
/// the free the list with g_list_free().
/// </return>

	public static MentorLake.GLib.GListHandle GetAcceptedCas(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_accepted_cas(conn);
	}

/// <summary>
/// <para>
/// Gets @conn's expected server identity
/// </para>
/// </summary>

/// <param name="conn">
/// the #GDtlsClientConnection
/// </param>
/// <return>
/// a #GSocketConnectable describing the
/// expected server identity, or %NULL if the expected identity is not
/// known.
/// </return>

	public static MentorLake.Gio.GSocketConnectableHandle GetServerIdentity(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_server_identity(conn);
	}

/// <summary>
/// <para>
/// Gets @conn's validation flags
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GDtlsClientConnection:validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GDtlsClientConnection
/// </param>
/// <return>
/// the validation flags
/// </return>

	public static MentorLake.Gio.GTlsCertificateFlags GetValidationFlags(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_validation_flags(conn);
	}

/// <summary>
/// <para>
/// Sets @conn's expected server identity, which is used both to tell
/// servers on virtual hosts which certificate to present, and also
/// to let @conn know what name to look for in the certificate when
/// performing %G_TLS_CERTIFICATE_BAD_IDENTITY validation, if enabled.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GDtlsClientConnection
/// </param>
/// <param name="identity">
/// a #GSocketConnectable describing the expected server identity
/// </param>

	public static T SetServerIdentity<T>(this T conn, MentorLake.Gio.GSocketConnectableHandle identity) where T : GDtlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		GDtlsClientConnectionHandleExterns.g_dtls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

/// <summary>
/// <para>
/// Sets @conn's validation flags, to override the default set of
/// checks performed when validating a server certificate. By default,
/// %G_TLS_CERTIFICATE_VALIDATE_ALL is used.
/// </para>
/// <para>
/// This function does not work as originally designed and is impossible
/// to use correctly. See #GDtlsClientConnection:validation-flags for more
/// information.
/// </para>
/// </summary>

/// <param name="conn">
/// the #GDtlsClientConnection
/// </param>
/// <param name="flags">
/// the #GTlsCertificateFlags to use
/// </param>

	public static T SetValidationFlags<T>(this T conn, MentorLake.Gio.GTlsCertificateFlags flags) where T : GDtlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		GDtlsClientConnectionHandleExterns.g_dtls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

/// <summary>
/// <para>
/// Creates a new #GDtlsClientConnection wrapping @base_socket which is
/// assumed to communicate with the server identified by @server_identity.
/// </para>
/// </summary>

/// <param name="base_socket">
/// the #GDatagramBased to wrap
/// </param>
/// <param name="server_identity">
/// the expected identity of the server
/// </param>
/// <return>
/// the new
///   #GDtlsClientConnection, or %NULL on error
/// </return>

	public static MentorLake.Gio.GDatagramBasedHandle New(MentorLake.Gio.GDatagramBasedHandle base_socket, MentorLake.Gio.GSocketConnectableHandle server_identity)
	{
		var externCallResult = GDtlsClientConnectionHandleExterns.g_dtls_client_connection_new(base_socket, server_identity, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDtlsClientConnectionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_dtls_client_connection_get_accepted_cas([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsClientConnectionHandleImpl>))] MentorLake.Gio.GDtlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))]
	internal static extern MentorLake.Gio.GSocketConnectableHandle g_dtls_client_connection_get_server_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsClientConnectionHandleImpl>))] MentorLake.Gio.GDtlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsCertificateFlags g_dtls_client_connection_get_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsClientConnectionHandleImpl>))] MentorLake.Gio.GDtlsClientConnectionHandle conn);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_client_connection_set_server_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsClientConnectionHandleImpl>))] MentorLake.Gio.GDtlsClientConnectionHandle conn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle identity);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dtls_client_connection_set_validation_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDtlsClientConnectionHandleImpl>))] MentorLake.Gio.GDtlsClientConnectionHandle conn, MentorLake.Gio.GTlsCertificateFlags flags);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))]
	internal static extern MentorLake.Gio.GDatagramBasedHandle g_dtls_client_connection_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle base_socket, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketConnectableHandleImpl>))] MentorLake.Gio.GSocketConnectableHandle server_identity, out MentorLake.GLib.GErrorHandle error);

}

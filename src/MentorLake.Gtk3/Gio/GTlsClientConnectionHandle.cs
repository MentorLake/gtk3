namespace MentorLake.Gio;

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
	public static T CopySessionState<T>(this T conn, MentorLake.Gio.GTlsClientConnectionHandle source) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_copy_session_state(conn, source);
		return conn;
	}

	public static MentorLake.GLib.GListHandle GetAcceptedCas(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_accepted_cas(conn);
	}

	public static MentorLake.Gio.GSocketConnectableHandle GetServerIdentity(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_server_identity(conn);
	}

	public static bool GetUseSsl3(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_use_ssl3(conn);
	}

	public static MentorLake.Gio.GTlsCertificateFlags GetValidationFlags(this MentorLake.Gio.GTlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		return GTlsClientConnectionHandleExterns.g_tls_client_connection_get_validation_flags(conn);
	}

	public static T SetServerIdentity<T>(this T conn, MentorLake.Gio.GSocketConnectableHandle identity) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

	public static T SetUseSsl3<T>(this T conn, bool use_ssl3) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_use_ssl3(conn, use_ssl3);
		return conn;
	}

	public static T SetValidationFlags<T>(this T conn, MentorLake.Gio.GTlsCertificateFlags flags) where T : GTlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GTlsClientConnectionHandle)");
		GTlsClientConnectionHandleExterns.g_tls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

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

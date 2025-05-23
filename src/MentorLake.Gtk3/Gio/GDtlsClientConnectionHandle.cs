namespace MentorLake.Gio;

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
	public static MentorLake.GLib.GListHandle GetAcceptedCas(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_accepted_cas(conn);
	}

	public static MentorLake.Gio.GSocketConnectableHandle GetServerIdentity(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_server_identity(conn);
	}

	public static MentorLake.Gio.GTlsCertificateFlags GetValidationFlags(this MentorLake.Gio.GDtlsClientConnectionHandle conn)
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		return GDtlsClientConnectionHandleExterns.g_dtls_client_connection_get_validation_flags(conn);
	}

	public static T SetServerIdentity<T>(this T conn, MentorLake.Gio.GSocketConnectableHandle identity) where T : GDtlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		GDtlsClientConnectionHandleExterns.g_dtls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

	public static T SetValidationFlags<T>(this T conn, MentorLake.Gio.GTlsCertificateFlags flags) where T : GDtlsClientConnectionHandle
	{
		if (conn.IsInvalid) throw new Exception("Invalid handle (GDtlsClientConnectionHandle)");
		GDtlsClientConnectionHandleExterns.g_dtls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

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

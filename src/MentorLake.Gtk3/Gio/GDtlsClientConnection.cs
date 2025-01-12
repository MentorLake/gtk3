namespace MentorLake.Gtk3.Gio;

public interface GDtlsClientConnectionHandle
{
}

internal class GDtlsClientConnectionHandleImpl : BaseSafeHandle, GDtlsClientConnectionHandle
{
}

public static class GDtlsClientConnectionHandleExtensions
{
	public static GListHandle GetAcceptedCas(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_accepted_cas(conn);
	}

	public static GSocketConnectableHandle GetServerIdentity(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_server_identity(conn);
	}

	public static GTlsCertificateFlags GetValidationFlags(this GDtlsClientConnectionHandle conn)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_get_validation_flags(conn);
	}

	public static T SetServerIdentity<T>(this T conn, GSocketConnectableHandle identity) where T : GDtlsClientConnectionHandle
	{
		GDtlsClientConnectionExterns.g_dtls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

	public static T SetValidationFlags<T>(this T conn, GTlsCertificateFlags flags) where T : GDtlsClientConnectionHandle
	{
		GDtlsClientConnectionExterns.g_dtls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

	public static GDatagramBasedHandle New(GDatagramBasedHandle base_socket, GSocketConnectableHandle server_identity, out GErrorHandle error)
	{
		return GDtlsClientConnectionExterns.g_dtls_client_connection_new(base_socket, server_identity, out error);
	}

}

internal class GDtlsClientConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dtls_client_connection_get_accepted_cas(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectableHandle g_dtls_client_connection_get_server_identity(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_dtls_client_connection_get_validation_flags(GDtlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_client_connection_set_server_identity(GDtlsClientConnectionHandle conn, GSocketConnectableHandle identity);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dtls_client_connection_set_validation_flags(GDtlsClientConnectionHandle conn, GTlsCertificateFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern GDatagramBasedHandle g_dtls_client_connection_new(GDatagramBasedHandle base_socket, GSocketConnectableHandle server_identity, out GErrorHandle error);

}

namespace MentorLake.Gtk3.Gio;

public interface GTlsClientConnectionHandle
{
}

internal class GTlsClientConnectionHandleImpl : BaseSafeHandle, GTlsClientConnectionHandle
{
}

public static class GTlsClientConnectionHandleExtensions
{
	public static T CopySessionState<T>(this T conn, GTlsClientConnectionHandle source) where T : GTlsClientConnectionHandle
	{
		GTlsClientConnectionExterns.g_tls_client_connection_copy_session_state(conn, source);
		return conn;
	}

	public static GListHandle GetAcceptedCas(this GTlsClientConnectionHandle conn)
	{
		return GTlsClientConnectionExterns.g_tls_client_connection_get_accepted_cas(conn);
	}

	public static GSocketConnectableHandle GetServerIdentity(this GTlsClientConnectionHandle conn)
	{
		return GTlsClientConnectionExterns.g_tls_client_connection_get_server_identity(conn);
	}

	public static bool GetUseSsl3(this GTlsClientConnectionHandle conn)
	{
		return GTlsClientConnectionExterns.g_tls_client_connection_get_use_ssl3(conn);
	}

	public static GTlsCertificateFlags GetValidationFlags(this GTlsClientConnectionHandle conn)
	{
		return GTlsClientConnectionExterns.g_tls_client_connection_get_validation_flags(conn);
	}

	public static T SetServerIdentity<T>(this T conn, GSocketConnectableHandle identity) where T : GTlsClientConnectionHandle
	{
		GTlsClientConnectionExterns.g_tls_client_connection_set_server_identity(conn, identity);
		return conn;
	}

	public static T SetUseSsl3<T>(this T conn, bool use_ssl3) where T : GTlsClientConnectionHandle
	{
		GTlsClientConnectionExterns.g_tls_client_connection_set_use_ssl3(conn, use_ssl3);
		return conn;
	}

	public static T SetValidationFlags<T>(this T conn, GTlsCertificateFlags flags) where T : GTlsClientConnectionHandle
	{
		GTlsClientConnectionExterns.g_tls_client_connection_set_validation_flags(conn, flags);
		return conn;
	}

	public static GIOStreamHandle New(GIOStreamHandle base_io_stream, GSocketConnectableHandle server_identity, out GErrorHandle error)
	{
		return GTlsClientConnectionExterns.g_tls_client_connection_new(base_io_stream, server_identity, out error);
	}

}

internal class GTlsClientConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_client_connection_copy_session_state(GTlsClientConnectionHandle conn, GTlsClientConnectionHandle source);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_tls_client_connection_get_accepted_cas(GTlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketConnectableHandle g_tls_client_connection_get_server_identity(GTlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_client_connection_get_use_ssl3(GTlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsCertificateFlags g_tls_client_connection_get_validation_flags(GTlsClientConnectionHandle conn);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_client_connection_set_server_identity(GTlsClientConnectionHandle conn, GSocketConnectableHandle identity);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_client_connection_set_use_ssl3(GTlsClientConnectionHandle conn, bool use_ssl3);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_client_connection_set_validation_flags(GTlsClientConnectionHandle conn, GTlsCertificateFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_tls_client_connection_new(GIOStreamHandle base_io_stream, GSocketConnectableHandle server_identity, out GErrorHandle error);

}

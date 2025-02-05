namespace MentorLake.Gtk3.Gio;

public interface GTlsBackendHandle
{
}

internal class GTlsBackendHandleImpl : BaseSafeHandle, GTlsBackendHandle
{
}

public static class GTlsBackendHandleExtensions
{
	public static GType GetCertificateType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_certificate_type(backend);
	}

	public static GType GetClientConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_client_connection_type(backend);
	}

	public static GTlsDatabaseHandle GetDefaultDatabase(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_default_database(backend);
	}

	public static GType GetDtlsClientConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_dtls_client_connection_type(backend);
	}

	public static GType GetDtlsServerConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_dtls_server_connection_type(backend);
	}

	public static GType GetFileDatabaseType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_file_database_type(backend);
	}

	public static GType GetServerConnectionType(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_get_server_connection_type(backend);
	}

	public static T SetDefaultDatabase<T>(this T backend, GTlsDatabaseHandle database) where T : GTlsBackendHandle
	{
		GTlsBackendExterns.g_tls_backend_set_default_database(backend, database);
		return backend;
	}

	public static bool SupportsDtls(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_supports_dtls(backend);
	}

	public static bool SupportsTls(this GTlsBackendHandle backend)
	{
		return GTlsBackendExterns.g_tls_backend_supports_tls(backend);
	}

	public static GTlsBackendHandle GetDefault()
	{
		return GTlsBackendExterns.g_tls_backend_get_default();
	}

}

internal class GTlsBackendExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_certificate_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_client_connection_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsDatabaseHandle g_tls_backend_get_default_database(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_dtls_client_connection_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_dtls_server_connection_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_file_database_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_tls_backend_get_server_connection_type(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern void g_tls_backend_set_default_database(GTlsBackendHandle backend, GTlsDatabaseHandle database);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_backend_supports_dtls(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_tls_backend_supports_tls(GTlsBackendHandle backend);

	[DllImport(Libraries.Gio)]
	internal static extern GTlsBackendHandle g_tls_backend_get_default();

}

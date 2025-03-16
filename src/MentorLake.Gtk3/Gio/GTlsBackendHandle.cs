namespace MentorLake.Gio;

public interface GTlsBackendHandle
{
}

internal class GTlsBackendHandleImpl : BaseSafeHandle, GTlsBackendHandle
{
}

public static class GTlsBackendHandleExtensions
{
	public static MentorLake.GObject.GType GetCertificateType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_certificate_type(backend);
	}

	public static MentorLake.GObject.GType GetClientConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_client_connection_type(backend);
	}

	public static MentorLake.Gio.GTlsDatabaseHandle GetDefaultDatabase(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_default_database(backend);
	}

	public static MentorLake.GObject.GType GetDtlsClientConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_dtls_client_connection_type(backend);
	}

	public static MentorLake.GObject.GType GetDtlsServerConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_dtls_server_connection_type(backend);
	}

	public static MentorLake.GObject.GType GetFileDatabaseType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_file_database_type(backend);
	}

	public static MentorLake.GObject.GType GetServerConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_server_connection_type(backend);
	}

	public static T SetDefaultDatabase<T>(this T backend, MentorLake.Gio.GTlsDatabaseHandle database) where T : GTlsBackendHandle
	{
		GTlsBackendHandleExterns.g_tls_backend_set_default_database(backend, database);
		return backend;
	}

	public static bool SupportsDtls(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_supports_dtls(backend);
	}

	public static bool SupportsTls(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		return GTlsBackendHandleExterns.g_tls_backend_supports_tls(backend);
	}

	public static MentorLake.Gio.GTlsBackendHandle GetDefault()
	{
		return GTlsBackendHandleExterns.g_tls_backend_get_default();
	}

}

internal class GTlsBackendHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_certificate_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_client_connection_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsDatabaseHandle g_tls_backend_get_default_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_dtls_client_connection_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_dtls_server_connection_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_file_database_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_tls_backend_get_server_connection_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_tls_backend_set_default_database([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))] MentorLake.Gio.GTlsDatabaseHandle database);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_backend_supports_dtls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_tls_backend_supports_tls([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))] MentorLake.Gio.GTlsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTlsBackendHandle g_tls_backend_get_default();

}

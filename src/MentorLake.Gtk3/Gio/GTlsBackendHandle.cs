namespace MentorLake.Gio;

/// <summary>
/// <para>
/// TLS (Transport Layer Security, aka SSL) and DTLS backend. This is an
/// internal type used to coordinate the different classes implemented
/// by a TLS backend.
/// </para>
/// </summary>

public interface GTlsBackendHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTlsBackendHandleImpl : BaseSafeHandle, GTlsBackendHandle
{
}

public static class GTlsBackendHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GType of @backend's #GTlsCertificate implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of @backend's #GTlsCertificate
///   implementation.
/// </return>

	public static MentorLake.GObject.GType GetCertificateType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_certificate_type(backend);
	}

/// <summary>
/// <para>
/// Gets the #GType of @backend's #GTlsClientConnection implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of @backend's #GTlsClientConnection
///   implementation.
/// </return>

	public static MentorLake.GObject.GType GetClientConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_client_connection_type(backend);
	}

/// <summary>
/// <para>
/// Gets the default #GTlsDatabase used to verify TLS connections.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the default database, which should be
///               unreffed when done.
/// </return>

	public static MentorLake.Gio.GTlsDatabaseHandle GetDefaultDatabase(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_default_database(backend);
	}

/// <summary>
/// <para>
/// Gets the #GType of @backend’s #GDtlsClientConnection implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of @backend’s #GDtlsClientConnection
///   implementation, or %G_TYPE_INVALID if this backend doesn’t support DTLS.
/// </return>

	public static MentorLake.GObject.GType GetDtlsClientConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_dtls_client_connection_type(backend);
	}

/// <summary>
/// <para>
/// Gets the #GType of @backend’s #GDtlsServerConnection implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of @backend’s #GDtlsServerConnection
///   implementation, or %G_TYPE_INVALID if this backend doesn’t support DTLS.
/// </return>

	public static MentorLake.GObject.GType GetDtlsServerConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_dtls_server_connection_type(backend);
	}

/// <summary>
/// <para>
/// Gets the #GType of @backend's #GTlsFileDatabase implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of backend's #GTlsFileDatabase implementation.
/// </return>

	public static MentorLake.GObject.GType GetFileDatabaseType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_file_database_type(backend);
	}

/// <summary>
/// <para>
/// Gets the #GType of @backend's #GTlsServerConnection implementation.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// the #GType of @backend's #GTlsServerConnection
///   implementation.
/// </return>

	public static MentorLake.GObject.GType GetServerConnectionType(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_get_server_connection_type(backend);
	}

/// <summary>
/// <para>
/// Set the default #GTlsDatabase used to verify TLS connections
/// </para>
/// <para>
/// Any subsequent call to g_tls_backend_get_default_database() will return
/// the database set in this call.  Existing databases and connections are not
/// modified.
/// </para>
/// <para>
/// Setting a %NULL default database will reset to using the system default
/// database as if g_tls_backend_set_default_database() had never been called.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <param name="database">
/// the #GTlsDatabase
/// </param>

	public static T SetDefaultDatabase<T>(this T backend, MentorLake.Gio.GTlsDatabaseHandle database) where T : GTlsBackendHandle
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		GTlsBackendHandleExterns.g_tls_backend_set_default_database(backend, database);
		return backend;
	}

/// <summary>
/// <para>
/// Checks if DTLS is supported. DTLS support may not be available even if TLS
/// support is available, and vice-versa.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// whether DTLS is supported
/// </return>

	public static bool SupportsDtls(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_supports_dtls(backend);
	}

/// <summary>
/// <para>
/// Checks if TLS is supported; if this returns %FALSE for the default
/// #GTlsBackend, it means no "real" TLS backend is available.
/// </para>
/// </summary>

/// <param name="backend">
/// the #GTlsBackend
/// </param>
/// <return>
/// whether or not TLS is supported
/// </return>

	public static bool SupportsTls(this MentorLake.Gio.GTlsBackendHandle backend)
	{
		if (backend.IsInvalid) throw new Exception("Invalid handle (GTlsBackendHandle)");
		return GTlsBackendHandleExterns.g_tls_backend_supports_tls(backend);
	}

/// <summary>
/// <para>
/// Gets the default #GTlsBackend for the system.
/// </para>
/// </summary>

/// <return>
/// a #GTlsBackend, which will be a
///     dummy object if no TLS backend is available
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsDatabaseHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTlsBackendHandleImpl>))]
	internal static extern MentorLake.Gio.GTlsBackendHandle g_tls_backend_get_default();

}

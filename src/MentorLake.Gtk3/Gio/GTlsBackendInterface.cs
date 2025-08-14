namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for describing TLS-related types.
/// </para>
/// </summary>

public class GTlsBackendInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsBackendInterfaceExtensions
{

	public static GTlsBackendInterface Dereference(this GTlsBackendInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsBackendInterface>(x.DangerousGetHandle());
}
internal class GTlsBackendInterfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for describing TLS-related types.
/// </para>
/// </summary>

public struct GTlsBackendInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// returns whether the backend supports TLS.
/// </para>
/// </summary>

public IntPtr supports_tls;
	/// <summary>
/// <para>
/// returns the #GTlsCertificate implementation type
/// </para>
/// </summary>

public IntPtr get_certificate_type;
	/// <summary>
/// <para>
/// returns the #GTlsClientConnection implementation type
/// </para>
/// </summary>

public IntPtr get_client_connection_type;
	/// <summary>
/// <para>
/// returns the #GTlsServerConnection implementation type
/// </para>
/// </summary>

public IntPtr get_server_connection_type;
	/// <summary>
/// <para>
/// returns the #GTlsFileDatabase implementation type.
/// </para>
/// </summary>

public IntPtr get_file_database_type;
	/// <summary>
/// <para>
/// returns a default #GTlsDatabase instance.
/// </para>
/// </summary>

public IntPtr get_default_database;
	/// <summary>
/// <para>
/// returns whether the backend supports DTLS
/// </para>
/// </summary>

public IntPtr supports_dtls;
	/// <summary>
/// <para>
/// returns the #GDtlsClientConnection implementation type
/// </para>
/// </summary>

public IntPtr get_dtls_client_connection_type;
	/// <summary>
/// <para>
/// returns the #GDtlsServerConnection implementation type
/// </para>
/// </summary>

public IntPtr get_dtls_server_connection_type;
}

namespace MentorLake.Gio;

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

public struct GTlsBackendInterface
{
	public GTypeInterface g_iface;
	public IntPtr supports_tls;
	public IntPtr get_certificate_type;
	public IntPtr get_client_connection_type;
	public IntPtr get_server_connection_type;
	public IntPtr get_file_database_type;
	public IntPtr get_default_database;
	public IntPtr supports_dtls;
	public IntPtr get_dtls_client_connection_type;
	public IntPtr get_dtls_server_connection_type;
}

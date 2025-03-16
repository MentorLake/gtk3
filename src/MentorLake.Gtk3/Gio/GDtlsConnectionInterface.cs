namespace MentorLake.Gio;

public class GDtlsConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GDtlsConnectionInterfaceExtensions
{

	public static GDtlsConnectionInterface Dereference(this GDtlsConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDtlsConnectionInterface>(x.DangerousGetHandle());
}
internal class GDtlsConnectionInterfaceExterns
{
}

public struct GDtlsConnectionInterface
{
	public GTypeInterface g_iface;
	public IntPtr accept_certificate;
	public IntPtr handshake;
	public IntPtr handshake_async;
	public IntPtr handshake_finish;
	public IntPtr shutdown;
	public IntPtr shutdown_async;
	public IntPtr shutdown_finish;
	public IntPtr set_advertised_protocols;
	public IntPtr get_negotiated_protocol;
	public IntPtr get_binding_data;
}

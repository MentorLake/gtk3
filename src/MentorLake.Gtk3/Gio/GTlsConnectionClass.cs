namespace MentorLake.Gio;

public class GTlsConnectionClassHandle : BaseSafeHandle
{
}


public static class GTlsConnectionClassExtensions
{

	public static GTlsConnectionClass Dereference(this GTlsConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsConnectionClass>(x.DangerousGetHandle());
}
internal class GTlsConnectionClassExterns
{
}

public struct GTlsConnectionClass
{
	public GIOStreamClass parent_class;
	public IntPtr accept_certificate;
	public IntPtr handshake;
	public IntPtr handshake_async;
	public IntPtr handshake_finish;
	public IntPtr get_binding_data;
	public IntPtr get_negotiated_protocol;
}

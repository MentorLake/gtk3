namespace MentorLake.Gio;

public class GTlsClientConnectionInterfaceHandle : BaseSafeHandle
{
}


public static class GTlsClientConnectionInterfaceExtensions
{

	public static GTlsClientConnectionInterface Dereference(this GTlsClientConnectionInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTlsClientConnectionInterface>(x.DangerousGetHandle());
}
internal class GTlsClientConnectionInterfaceExterns
{
}

public struct GTlsClientConnectionInterface
{
	public GTypeInterface g_iface;
	public IntPtr copy_session_state;
}

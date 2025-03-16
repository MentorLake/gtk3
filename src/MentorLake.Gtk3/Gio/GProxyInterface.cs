namespace MentorLake.Gio;

public class GProxyInterfaceHandle : BaseSafeHandle
{
}


public static class GProxyInterfaceExtensions
{

	public static GProxyInterface Dereference(this GProxyInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyInterface>(x.DangerousGetHandle());
}
internal class GProxyInterfaceExterns
{
}

public struct GProxyInterface
{
	public GTypeInterface g_iface;
	public IntPtr connect;
	public IntPtr connect_async;
	public IntPtr connect_finish;
	public IntPtr supports_hostname;
}

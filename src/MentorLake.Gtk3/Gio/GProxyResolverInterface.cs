namespace MentorLake.Gio;

public class GProxyResolverInterfaceHandle : BaseSafeHandle
{
}


public static class GProxyResolverInterfaceExtensions
{

	public static GProxyResolverInterface Dereference(this GProxyResolverInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyResolverInterface>(x.DangerousGetHandle());
}
internal class GProxyResolverInterfaceExterns
{
}

public struct GProxyResolverInterface
{
	public GTypeInterface g_iface;
	public IntPtr is_supported;
	public IntPtr lookup;
	public IntPtr lookup_async;
	public IntPtr lookup_finish;
}

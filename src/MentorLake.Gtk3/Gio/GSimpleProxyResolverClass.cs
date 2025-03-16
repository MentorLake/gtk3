namespace MentorLake.Gio;

public class GSimpleProxyResolverClassHandle : BaseSafeHandle
{
}


public static class GSimpleProxyResolverClassExtensions
{

	public static GSimpleProxyResolverClass Dereference(this GSimpleProxyResolverClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSimpleProxyResolverClass>(x.DangerousGetHandle());
}
internal class GSimpleProxyResolverClassExterns
{
}

public struct GSimpleProxyResolverClass
{
	public GObjectClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

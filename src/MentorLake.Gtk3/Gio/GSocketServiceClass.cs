namespace MentorLake.Gio;

public class GSocketServiceClassHandle : BaseSafeHandle
{
}


public static class GSocketServiceClassExtensions
{

	public static GSocketServiceClass Dereference(this GSocketServiceClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketServiceClass>(x.DangerousGetHandle());
}
internal class GSocketServiceClassExterns
{
}

public struct GSocketServiceClass
{
	public GSocketListenerClass parent_class;
	public IntPtr incoming;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

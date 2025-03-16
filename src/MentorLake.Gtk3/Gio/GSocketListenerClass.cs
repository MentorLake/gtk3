namespace MentorLake.Gio;

public class GSocketListenerClassHandle : BaseSafeHandle
{
}


public static class GSocketListenerClassExtensions
{

	public static GSocketListenerClass Dereference(this GSocketListenerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketListenerClass>(x.DangerousGetHandle());
}
internal class GSocketListenerClassExterns
{
}

public struct GSocketListenerClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr @event;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

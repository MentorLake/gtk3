namespace MentorLake.Gio;

public class GSocketClientClassHandle : BaseSafeHandle
{
}


public static class GSocketClientClassExtensions
{

	public static GSocketClientClass Dereference(this GSocketClientClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketClientClass>(x.DangerousGetHandle());
}
internal class GSocketClientClassExterns
{
}

public struct GSocketClientClass
{
	public GObjectClass parent_class;
	public IntPtr @event;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
}

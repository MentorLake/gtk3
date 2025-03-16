namespace MentorLake.Gio;

public class GCancellableClassHandle : BaseSafeHandle
{
}


public static class GCancellableClassExtensions
{

	public static GCancellableClass Dereference(this GCancellableClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GCancellableClass>(x.DangerousGetHandle());
}
internal class GCancellableClassExterns
{
}

public struct GCancellableClass
{
	public GObjectClass parent_class;
	public IntPtr cancelled;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

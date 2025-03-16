namespace MentorLake.Gio;

public class GDebugControllerDBusClassHandle : BaseSafeHandle
{
}


public static class GDebugControllerDBusClassExtensions
{

	public static GDebugControllerDBusClass Dereference(this GDebugControllerDBusClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDebugControllerDBusClass>(x.DangerousGetHandle());
}
internal class GDebugControllerDBusClassExterns
{
}

public struct GDebugControllerDBusClass
{
	public GObjectClass parent_class;
	public IntPtr authorize;
	public IntPtr padding;
}

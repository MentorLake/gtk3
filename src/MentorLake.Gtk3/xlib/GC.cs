namespace MentorLake.xlib;


public struct GC
{
	public IntPtr Value;
}

public class GCHandle : BaseSafeHandle
{
}

public static class GCHandleExtensions
{
	public static GC Dereference(this GCHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GC>(x.DangerousGetHandle());
	public static IntPtr DereferenceValue(this GCHandle x) => x.Dereference().Value;
}

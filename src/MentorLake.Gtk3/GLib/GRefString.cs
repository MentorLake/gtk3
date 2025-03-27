namespace MentorLake.GLib;

public struct GRefString
{
	public char Value;
}

public class GRefStringHandle : BaseSafeHandle
{
}

public static class GRefStringHandleExtensions
{
	public static GRefString Dereference(this GRefStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRefString>(x.DangerousGetHandle());
	public static char DereferenceValue(this GRefStringHandle x) => x.Dereference().Value;
}

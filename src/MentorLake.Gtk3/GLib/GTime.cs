namespace MentorLake.GLib;

public struct GTime
{
	public int Value;
}

public class GTimeHandle : BaseSafeHandle
{
}

public static class GTimeHandleExtensions
{
	public static GTime Dereference(this GTimeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTime>(x.DangerousGetHandle());
	public static int DereferenceValue(this GTimeHandle x) => x.Dereference().Value;
}

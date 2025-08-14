namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A value representing an interval of time, in microseconds.
/// </para>
/// </summary>

public struct GTimeSpan
{
	public long Value;
}

public class GTimeSpanHandle : BaseSafeHandle
{
}

public static class GTimeSpanHandleExtensions
{
	public static GTimeSpan Dereference(this GTimeSpanHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTimeSpan>(x.DangerousGetHandle());
	public static long DereferenceValue(this GTimeSpanHandle x) => x.Dereference().Value;
}

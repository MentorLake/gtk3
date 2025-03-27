namespace MentorLake.GLib;

public struct GDateYear
{
	public ushort Value;
}

public class GDateYearHandle : BaseSafeHandle
{
}

public static class GDateYearHandleExtensions
{
	public static GDateYear Dereference(this GDateYearHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDateYear>(x.DangerousGetHandle());
	public static ushort DereferenceValue(this GDateYearHandle x) => x.Dereference().Value;
}

namespace MentorLake.GLib;

public struct GDateDay
{
	public byte Value;
}

public class GDateDayHandle : BaseSafeHandle
{
}

public static class GDateDayHandleExtensions
{
	public static GDateDay Dereference(this GDateDayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDateDay>(x.DangerousGetHandle());
	public static byte DereferenceValue(this GDateDayHandle x) => x.Dereference().Value;
}

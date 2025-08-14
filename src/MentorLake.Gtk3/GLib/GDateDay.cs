namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Integer representing a day of the month; between 1 and 31.
/// </para>
/// <para>
/// The %G_DATE_BAD_DAY value represents an invalid day of the month.
/// </para>
/// </summary>

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

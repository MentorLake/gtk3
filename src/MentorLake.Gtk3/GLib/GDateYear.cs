namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Integer type representing a year.
/// </para>
/// <para>
/// The %G_DATE_BAD_YEAR value is the invalid value. The year
/// must be 1 or higher; negative ([BCE](https://en.wikipedia.org/wiki/Common_Era))
/// years are not allowed.
/// </para>
/// <para>
/// The year is represented with four digits.
/// </para>
/// </summary>

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

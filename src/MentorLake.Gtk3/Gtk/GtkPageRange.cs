namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also gtk_print_settings_set_page_ranges().
/// </para>
/// </summary>

public class GtkPageRangeHandle : BaseSafeHandle
{
}


public static class GtkPageRangeExtensions
{

	public static GtkPageRange Dereference(this GtkPageRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPageRange>(x.DangerousGetHandle());
}
internal class GtkPageRangeExterns
{
}

/// <summary>
/// <para>
/// See also gtk_print_settings_set_page_ranges().
/// </para>
/// </summary>

public struct GtkPageRange
{
	/// <summary>
/// <para>
/// start of page range.
/// </para>
/// </summary>

public int start;
	/// <summary>
/// <para>
/// end of page range.
/// </para>
/// </summary>

public int end;
}

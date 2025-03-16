namespace MentorLake.Gtk;

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

public struct GtkPageRange
{
	public int start;
	public int end;
}

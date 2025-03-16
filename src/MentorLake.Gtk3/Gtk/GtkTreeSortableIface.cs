namespace MentorLake.Gtk;

public class GtkTreeSortableIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeSortableIfaceExtensions
{

	public static GtkTreeSortableIface Dereference(this GtkTreeSortableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeSortableIface>(x.DangerousGetHandle());
}
internal class GtkTreeSortableIfaceExterns
{
}

public struct GtkTreeSortableIface
{
	public IntPtr sort_column_changed;
	public IntPtr get_sort_column_id;
	public IntPtr set_sort_column_id;
	public IntPtr set_sort_func;
	public IntPtr set_default_sort_func;
	public IntPtr has_default_sort_func;
}

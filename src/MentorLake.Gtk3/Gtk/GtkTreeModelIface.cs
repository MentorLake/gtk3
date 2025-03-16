namespace MentorLake.Gtk;

public class GtkTreeModelIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeModelIfaceExtensions
{

	public static GtkTreeModelIface Dereference(this GtkTreeModelIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeModelIface>(x.DangerousGetHandle());
}
internal class GtkTreeModelIfaceExterns
{
}

public struct GtkTreeModelIface
{
	public IntPtr row_changed;
	public IntPtr row_inserted;
	public IntPtr row_has_child_toggled;
	public IntPtr row_deleted;
	public IntPtr rows_reordered;
	public IntPtr get_flags;
	public IntPtr get_n_columns;
	public IntPtr get_column_type;
	public IntPtr get_iter;
	public IntPtr get_path;
	public IntPtr get_value;
	public IntPtr iter_next;
	public IntPtr iter_previous;
	public IntPtr iter_children;
	public IntPtr iter_has_child;
	public IntPtr iter_n_children;
	public IntPtr iter_nth_child;
	public IntPtr iter_parent;
	public IntPtr ref_node;
	public IntPtr unref_node;
}

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
	/// <summary>
/// <para>
/// Signal emitted when the sort column or sort
///    order of sortable is changed.
/// </para>
/// </summary>

public IntPtr sort_column_changed;
	/// <summary>
/// <para>
/// Fills in sort_column_id and order with the
///    current sort column and the order.
/// </para>
/// </summary>

public IntPtr get_sort_column_id;
	/// <summary>
/// <para>
/// Sets the current sort column to be
///    sort_column_id.
/// </para>
/// </summary>

public IntPtr set_sort_column_id;
	/// <summary>
/// <para>
/// Sets the comparison function used when sorting to
///    be sort_func.
/// </para>
/// </summary>

public IntPtr set_sort_func;
	/// <summary>
/// <para>
/// Sets the default comparison function used
///    when sorting to be sort_func.
/// </para>
/// </summary>

public IntPtr set_default_sort_func;
	/// <summary>
/// <para>
/// %TRUE if the model has a default sort
/// function.
/// </para>
/// </summary>

public IntPtr has_default_sort_func;
}

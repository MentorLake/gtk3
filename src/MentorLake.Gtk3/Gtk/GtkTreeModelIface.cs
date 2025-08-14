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
	/// <summary>
/// <para>
/// Signal emitted when a row in the model has changed.
/// </para>
/// </summary>

public IntPtr row_changed;
	/// <summary>
/// <para>
/// Signal emitted when a new row has been inserted in
///    the model.
/// </para>
/// </summary>

public IntPtr row_inserted;
	/// <summary>
/// <para>
/// Signal emitted when a row has gotten the
///    first child row or lost its last child row.
/// </para>
/// </summary>

public IntPtr row_has_child_toggled;
	/// <summary>
/// <para>
/// Signal emitted when a row has been deleted.
/// </para>
/// </summary>

public IntPtr row_deleted;
	/// <summary>
/// <para>
/// Signal emitted when the children of a node in the
///    GtkTreeModel have been reordered.
/// </para>
/// </summary>

public IntPtr rows_reordered;
	/// <summary>
/// <para>
/// Get #GtkTreeModelFlags supported by this interface.
/// </para>
/// </summary>

public IntPtr get_flags;
	/// <summary>
/// <para>
/// Get the number of columns supported by the model.
/// </para>
/// </summary>

public IntPtr get_n_columns;
	/// <summary>
/// <para>
/// Get the type of the column.
/// </para>
/// </summary>

public IntPtr get_column_type;
	/// <summary>
/// <para>
/// Sets iter to a valid iterator pointing to path.
/// </para>
/// </summary>

public IntPtr get_iter;
	/// <summary>
/// <para>
/// Gets a newly-created #GtkTreePath referenced by iter.
/// </para>
/// </summary>

public IntPtr get_path;
	/// <summary>
/// <para>
/// Initializes and sets value to that at column.
/// </para>
/// </summary>

public IntPtr get_value;
	/// <summary>
/// <para>
/// Sets iter to point to the node following it at the
///    current level.
/// </para>
/// </summary>

public IntPtr iter_next;
	/// <summary>
/// <para>
/// Sets iter to point to the previous node at the
///    current level.
/// </para>
/// </summary>

public IntPtr iter_previous;
	/// <summary>
/// <para>
/// Sets iter to point to the first child of parent.
/// </para>
/// </summary>

public IntPtr iter_children;
	/// <summary>
/// <para>
/// %TRUE if iter has children, %FALSE otherwise.
/// </para>
/// </summary>

public IntPtr iter_has_child;
	/// <summary>
/// <para>
/// Gets the number of children that iter has.
/// </para>
/// </summary>

public IntPtr iter_n_children;
	/// <summary>
/// <para>
/// Sets iter to be the child of parent, using the
///    given index.
/// </para>
/// </summary>

public IntPtr iter_nth_child;
	/// <summary>
/// <para>
/// Sets iter to be the parent of child.
/// </para>
/// </summary>

public IntPtr iter_parent;
	/// <summary>
/// <para>
/// Lets the tree ref the node.
/// </para>
/// </summary>

public IntPtr ref_node;
	/// <summary>
/// <para>
/// Lets the tree unref the node.
/// </para>
/// </summary>

public IntPtr unref_node;
}

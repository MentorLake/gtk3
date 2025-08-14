namespace MentorLake.Gtk;


public class GtkTreeDragSourceIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeDragSourceIfaceExtensions
{

	public static GtkTreeDragSourceIface Dereference(this GtkTreeDragSourceIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeDragSourceIface>(x.DangerousGetHandle());
}
internal class GtkTreeDragSourceIfaceExterns
{
}


public struct GtkTreeDragSourceIface
{
	/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource whether a particular
///    row can be used as the source of a DND operation.
/// </para>
/// </summary>

public IntPtr row_draggable;
	/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource to fill in
///    selection_data with a representation of the row at path.
/// </para>
/// </summary>

public IntPtr drag_data_get;
	/// <summary>
/// <para>
/// Asks the #GtkTreeDragSource to delete the row at
///    path, because it was moved somewhere else via drag-and-drop.
/// </para>
/// </summary>

public IntPtr drag_data_delete;
}

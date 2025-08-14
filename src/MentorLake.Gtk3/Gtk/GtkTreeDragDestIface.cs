namespace MentorLake.Gtk;


public class GtkTreeDragDestIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeDragDestIfaceExtensions
{

	public static GtkTreeDragDestIface Dereference(this GtkTreeDragDestIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeDragDestIface>(x.DangerousGetHandle());
}
internal class GtkTreeDragDestIfaceExterns
{
}


public struct GtkTreeDragDestIface
{
	/// <summary>
/// <para>
/// Asks the #GtkTreeDragDest to insert a row
///    before the path dest, deriving the contents of the row from
///    selection_data.
/// </para>
/// </summary>

public IntPtr drag_data_received;
	/// <summary>
/// <para>
/// Determines whether a drop is possible before
///    the given dest_path, at the same depth as dest_path.
/// </para>
/// </summary>

public IntPtr row_drop_possible;
}

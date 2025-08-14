namespace MentorLake.Gtk;


public class GtkCellEditableIfaceHandle : BaseSafeHandle
{
}


public static class GtkCellEditableIfaceExtensions
{

	public static GtkCellEditableIface Dereference(this GtkCellEditableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellEditableIface>(x.DangerousGetHandle());
}
internal class GtkCellEditableIfaceExterns
{
}


public struct GtkCellEditableIface
{
	/// <summary>
/// <para>
/// Signal is a sign for the cell renderer to update its
///    value from the cell_editable.
/// </para>
/// </summary>

public IntPtr editing_done;
	/// <summary>
/// <para>
/// Signal is meant to indicate that the cell is
///    finished editing, and the widget may now be destroyed.
/// </para>
/// </summary>

public IntPtr remove_widget;
	/// <summary>
/// <para>
/// Begins editing on a cell_editable.
/// </para>
/// </summary>

public IntPtr start_editing;
}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Identifies how the user can interact with a particular cell.
/// </para>
/// </summary>

[Flags]
public enum GtkCellRendererMode
{
/// <summary>
/// <para>
/// The cell is just for display
///  and cannot be interacted with.  Note that this doesn’t mean that eg. the
///  row being drawn can’t be selected -- just that a particular element of
///  it cannot be individually modified.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_MODE_INERT = 0,
/// <summary>
/// <para>
/// The cell can be clicked.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_MODE_ACTIVATABLE = 1,
/// <summary>
/// <para>
/// The cell can be edited or otherwise modified.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_MODE_EDITABLE = 2
}

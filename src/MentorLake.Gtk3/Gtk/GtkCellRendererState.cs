namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Tells how a cell is to be rendered.
/// </para>
/// </summary>

[Flags]
public enum GtkCellRendererState : uint
{
/// <summary>
/// <para>
/// The cell is currently selected, and
///  probably has a selection colored background to render to.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_SELECTED = 1,
/// <summary>
/// <para>
/// The mouse is hovering over the cell.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_PRELIT = 2,
/// <summary>
/// <para>
/// The cell is drawn in an insensitive manner
/// </para>
/// </summary>

	GTK_CELL_RENDERER_INSENSITIVE = 4,
/// <summary>
/// <para>
/// The cell is in a sorted row
/// </para>
/// </summary>

	GTK_CELL_RENDERER_SORTED = 8,
/// <summary>
/// <para>
/// The cell is in the focus row.
/// </para>
/// </summary>

	GTK_CELL_RENDERER_FOCUSED = 16,
/// <summary>
/// <para>
/// The cell is in a row that can be expanded. Since 3.4
/// </para>
/// </summary>

	GTK_CELL_RENDERER_EXPANDABLE = 32,
/// <summary>
/// <para>
/// The cell is in a row that is expanded. Since 3.4
/// </para>
/// </summary>

	GTK_CELL_RENDERER_EXPANDED = 64
}

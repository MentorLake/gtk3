namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to indicate which grid lines to draw in a tree view.
/// </para>
/// </summary>

[Flags]
public enum GtkTreeViewGridLines
{
/// <summary>
/// <para>
/// No grid lines.
/// </para>
/// </summary>

	GTK_TREE_VIEW_GRID_LINES_NONE = 0,
/// <summary>
/// <para>
/// Horizontal grid lines.
/// </para>
/// </summary>

	GTK_TREE_VIEW_GRID_LINES_HORIZONTAL = 1,
/// <summary>
/// <para>
/// Vertical grid lines.
/// </para>
/// </summary>

	GTK_TREE_VIEW_GRID_LINES_VERTICAL = 2,
/// <summary>
/// <para>
/// Horizontal and vertical grid lines.
/// </para>
/// </summary>

	GTK_TREE_VIEW_GRID_LINES_BOTH = 3
}

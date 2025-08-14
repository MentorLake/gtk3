namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The sizing method the column uses to determine its width.  Please note
/// that @GTK_TREE_VIEW_COLUMN_AUTOSIZE are inefficient for large views, and
/// can make columns appear choppy.
/// </para>
/// </summary>

[Flags]
public enum GtkTreeViewColumnSizing
{
/// <summary>
/// <para>
/// Columns only get bigger in reaction to changes in the model
/// </para>
/// </summary>

	GTK_TREE_VIEW_COLUMN_GROW_ONLY = 0,
/// <summary>
/// <para>
/// Columns resize to be the optimal size everytime the model changes.
/// </para>
/// </summary>

	GTK_TREE_VIEW_COLUMN_AUTOSIZE = 1,
/// <summary>
/// <para>
/// Columns are a fixed numbers of pixels wide.
/// </para>
/// </summary>

	GTK_TREE_VIEW_COLUMN_FIXED = 2
}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// An enum for determining where a dropped row goes.
/// </para>
/// </summary>

[Flags]
public enum GtkTreeViewDropPosition
{
/// <summary>
/// <para>
/// dropped row is inserted before
/// </para>
/// </summary>

	GTK_TREE_VIEW_DROP_BEFORE = 0,
/// <summary>
/// <para>
/// dropped row is inserted after
/// </para>
/// </summary>

	GTK_TREE_VIEW_DROP_AFTER = 1,
/// <summary>
/// <para>
/// dropped row becomes a child or is inserted before
/// </para>
/// </summary>

	GTK_TREE_VIEW_DROP_INTO_OR_BEFORE = 2,
/// <summary>
/// <para>
/// dropped row becomes a child or is inserted after
/// </para>
/// </summary>

	GTK_TREE_VIEW_DROP_INTO_OR_AFTER = 3
}

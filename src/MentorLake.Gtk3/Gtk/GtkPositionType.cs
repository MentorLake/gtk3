namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes which edge of a widget a certain feature is positioned at, e.g. the
/// tabs of a #GtkNotebook, the handle of a #GtkHandleBox or the label of a
/// #GtkScale.
/// </para>
/// </summary>

[Flags]
public enum GtkPositionType
{
/// <summary>
/// <para>
/// The feature is at the left edge.
/// </para>
/// </summary>

	GTK_POS_LEFT = 0,
/// <summary>
/// <para>
/// The feature is at the right edge.
/// </para>
/// </summary>

	GTK_POS_RIGHT = 1,
/// <summary>
/// <para>
/// The feature is at the top edge.
/// </para>
/// </summary>

	GTK_POS_TOP = 2,
/// <summary>
/// <para>
/// The feature is at the bottom edge.
/// </para>
/// </summary>

	GTK_POS_BOTTOM = 3
}

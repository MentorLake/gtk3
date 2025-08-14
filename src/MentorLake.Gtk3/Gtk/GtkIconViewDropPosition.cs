namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// An enum for determining where a dropped item goes.
/// </para>
/// </summary>

[Flags]
public enum GtkIconViewDropPosition
{
/// <summary>
/// <para>
/// no drop possible
/// </para>
/// </summary>

	GTK_ICON_VIEW_NO_DROP = 0,
/// <summary>
/// <para>
/// dropped item replaces the item
/// </para>
/// </summary>

	GTK_ICON_VIEW_DROP_INTO = 1,
/// <summary>
/// <para>
/// droppped item is inserted to the left
/// </para>
/// </summary>

	GTK_ICON_VIEW_DROP_LEFT = 2,
/// <summary>
/// <para>
/// dropped item is inserted to the right
/// </para>
/// </summary>

	GTK_ICON_VIEW_DROP_RIGHT = 3,
/// <summary>
/// <para>
/// dropped item is inserted above
/// </para>
/// </summary>

	GTK_ICON_VIEW_DROP_ABOVE = 4,
/// <summary>
/// <para>
/// dropped item is inserted below
/// </para>
/// </summary>

	GTK_ICON_VIEW_DROP_BELOW = 5
}

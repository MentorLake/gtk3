namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to dictate the style that a #GtkButtonBox uses to layout the buttons it
/// contains.
/// </para>
/// </summary>

[Flags]
public enum GtkButtonBoxStyle
{
/// <summary>
/// <para>
/// Buttons are evenly spread across the box.
/// </para>
/// </summary>

	GTK_BUTTONBOX_SPREAD = 1,
/// <summary>
/// <para>
/// Buttons are placed at the edges of the box.
/// </para>
/// </summary>

	GTK_BUTTONBOX_EDGE = 2,
/// <summary>
/// <para>
/// Buttons are grouped towards the start of the box,
///   (on the left for a HBox, or the top for a VBox).
/// </para>
/// </summary>

	GTK_BUTTONBOX_START = 3,
/// <summary>
/// <para>
/// Buttons are grouped towards the end of the box,
///   (on the right for a HBox, or the bottom for a VBox).
/// </para>
/// </summary>

	GTK_BUTTONBOX_END = 4,
/// <summary>
/// <para>
/// Buttons are centered in the box. Since 2.12.
/// </para>
/// </summary>

	GTK_BUTTONBOX_CENTER = 5,
/// <summary>
/// <para>
/// Buttons expand to fill the box. This entails giving
///   buttons a &quot;linked&quot; appearance, making button sizes homogeneous, and
///   setting spacing to 0 (same as calling gtk_box_set_homogeneous() and
///   gtk_box_set_spacing() manually). Since 3.12.
/// </para>
/// </summary>

	GTK_BUTTONBOX_EXPAND = 6
}

namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Represents the orientation of widgets and other objects which can be switched
/// between horizontal and vertical orientation on the fly, like #GtkToolbar or
/// #GtkGesturePan.
/// </para>
/// </summary>

[Flags]
public enum GtkOrientation
{
/// <summary>
/// <para>
/// The element is in horizontal orientation.
/// </para>
/// </summary>

	GTK_ORIENTATION_HORIZONTAL = 0,
/// <summary>
/// <para>
/// The element is in vertical orientation.
/// </para>
/// </summary>

	GTK_ORIENTATION_VERTICAL = 1
}

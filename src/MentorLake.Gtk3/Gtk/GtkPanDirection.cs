namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes the panning direction of a #GtkGesturePan
/// </para>
/// </summary>

[Flags]
public enum GtkPanDirection
{
/// <summary>
/// <para>
/// panned towards the left
/// </para>
/// </summary>

	GTK_PAN_DIRECTION_LEFT = 0,
/// <summary>
/// <para>
/// panned towards the right
/// </para>
/// </summary>

	GTK_PAN_DIRECTION_RIGHT = 1,
/// <summary>
/// <para>
/// panned upwards
/// </para>
/// </summary>

	GTK_PAN_DIRECTION_UP = 2,
/// <summary>
/// <para>
/// panned downwards
/// </para>
/// </summary>

	GTK_PAN_DIRECTION_DOWN = 3
}

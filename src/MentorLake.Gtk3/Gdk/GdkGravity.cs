namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Defines the reference point of a window and the meaning of coordinates
/// passed to gtk_window_move(). See gtk_window_move() and the "implementation
/// notes" section of the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec)
/// specification for more details.
/// </para>
/// </summary>

[Flags]
public enum GdkGravity
{
/// <summary>
/// <para>
/// the reference point is at the top left corner.
/// </para>
/// </summary>

	GDK_GRAVITY_NORTH_WEST = 1,
/// <summary>
/// <para>
/// the reference point is in the middle of the top edge.
/// </para>
/// </summary>

	GDK_GRAVITY_NORTH = 2,
/// <summary>
/// <para>
/// the reference point is at the top right corner.
/// </para>
/// </summary>

	GDK_GRAVITY_NORTH_EAST = 3,
/// <summary>
/// <para>
/// the reference point is at the middle of the left edge.
/// </para>
/// </summary>

	GDK_GRAVITY_WEST = 4,
/// <summary>
/// <para>
/// the reference point is at the center of the window.
/// </para>
/// </summary>

	GDK_GRAVITY_CENTER = 5,
/// <summary>
/// <para>
/// the reference point is at the middle of the right edge.
/// </para>
/// </summary>

	GDK_GRAVITY_EAST = 6,
/// <summary>
/// <para>
/// the reference point is at the lower left corner.
/// </para>
/// </summary>

	GDK_GRAVITY_SOUTH_WEST = 7,
/// <summary>
/// <para>
/// the reference point is at the middle of the lower edge.
/// </para>
/// </summary>

	GDK_GRAVITY_SOUTH = 8,
/// <summary>
/// <para>
/// the reference point is at the lower right corner.
/// </para>
/// </summary>

	GDK_GRAVITY_SOUTH_EAST = 9,
/// <summary>
/// <para>
/// the reference point is at the top left corner of the
///  window itself, ignoring window manager decorations.
/// </para>
/// </summary>

	GDK_GRAVITY_STATIC = 10
}

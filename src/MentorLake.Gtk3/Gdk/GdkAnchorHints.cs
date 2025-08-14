namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Positioning hints for aligning a window relative to a rectangle.
/// </para>
/// <para>
/// These hints determine how the window should be positioned in the case that
/// the window would fall off-screen if placed in its ideal position.
/// </para>
/// <para>
/// For example, %GDK_ANCHOR_FLIP_X will replace %GDK_GRAVITY_NORTH_WEST with
/// %GDK_GRAVITY_NORTH_EAST and vice versa if the window extends beyond the left
/// or right edges of the monitor.
/// </para>
/// <para>
/// If %GDK_ANCHOR_SLIDE_X is set, the window can be shifted horizontally to fit
/// on-screen. If %GDK_ANCHOR_RESIZE_X is set, the window can be shrunken
/// horizontally to fit.
/// </para>
/// <para>
/// In general, when multiple flags are set, flipping should take precedence over
/// sliding, which should take precedence over resizing.
/// </para>
/// </summary>

[Flags]
public enum GdkAnchorHints : uint
{
/// <summary>
/// <para>
/// allow flipping anchors horizontally
/// </para>
/// </summary>

	GDK_ANCHOR_FLIP_X = 1,
/// <summary>
/// <para>
/// allow flipping anchors vertically
/// </para>
/// </summary>

	GDK_ANCHOR_FLIP_Y = 2,
/// <summary>
/// <para>
/// allow sliding window horizontally
/// </para>
/// </summary>

	GDK_ANCHOR_SLIDE_X = 4,
/// <summary>
/// <para>
/// allow sliding window vertically
/// </para>
/// </summary>

	GDK_ANCHOR_SLIDE_Y = 8,
/// <summary>
/// <para>
/// allow resizing window horizontally
/// </para>
/// </summary>

	GDK_ANCHOR_RESIZE_X = 16,
/// <summary>
/// <para>
/// allow resizing window vertically
/// </para>
/// </summary>

	GDK_ANCHOR_RESIZE_Y = 32,
/// <summary>
/// <para>
/// allow flipping anchors on both axes
/// </para>
/// </summary>

	GDK_ANCHOR_FLIP = 3,
/// <summary>
/// <para>
/// allow sliding window on both axes
/// </para>
/// </summary>

	GDK_ANCHOR_SLIDE = 12,
/// <summary>
/// <para>
/// allow resizing window on both axes
/// </para>
/// </summary>

	GDK_ANCHOR_RESIZE = 48
}

namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the direction for #GdkEventScroll.
/// </para>
/// </summary>

[Flags]
public enum GdkScrollDirection
{
/// <summary>
/// <para>
/// the window is scrolled up.
/// </para>
/// </summary>

	GDK_SCROLL_UP = 0,
/// <summary>
/// <para>
/// the window is scrolled down.
/// </para>
/// </summary>

	GDK_SCROLL_DOWN = 1,
/// <summary>
/// <para>
/// the window is scrolled to the left.
/// </para>
/// </summary>

	GDK_SCROLL_LEFT = 2,
/// <summary>
/// <para>
/// the window is scrolled to the right.
/// </para>
/// </summary>

	GDK_SCROLL_RIGHT = 3,
/// <summary>
/// <para>
/// the scrolling is determined by the delta values
///   in #GdkEventScroll. See gdk_event_get_scroll_deltas(). Since: 3.4
/// </para>
/// </summary>

	GDK_SCROLL_SMOOTH = 4
}

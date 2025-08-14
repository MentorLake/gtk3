namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Scrolling types.
/// </para>
/// </summary>

[Flags]
public enum GtkScrollType
{
/// <summary>
/// <para>
/// No scrolling.
/// </para>
/// </summary>

	GTK_SCROLL_NONE = 0,
/// <summary>
/// <para>
/// Jump to new location.
/// </para>
/// </summary>

	GTK_SCROLL_JUMP = 1,
/// <summary>
/// <para>
/// Step backward.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_BACKWARD = 2,
/// <summary>
/// <para>
/// Step forward.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_FORWARD = 3,
/// <summary>
/// <para>
/// Page backward.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_BACKWARD = 4,
/// <summary>
/// <para>
/// Page forward.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_FORWARD = 5,
/// <summary>
/// <para>
/// Step up.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_UP = 6,
/// <summary>
/// <para>
/// Step down.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_DOWN = 7,
/// <summary>
/// <para>
/// Page up.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_UP = 8,
/// <summary>
/// <para>
/// Page down.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_DOWN = 9,
/// <summary>
/// <para>
/// Step to the left.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_LEFT = 10,
/// <summary>
/// <para>
/// Step to the right.
/// </para>
/// </summary>

	GTK_SCROLL_STEP_RIGHT = 11,
/// <summary>
/// <para>
/// Page to the left.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_LEFT = 12,
/// <summary>
/// <para>
/// Page to the right.
/// </para>
/// </summary>

	GTK_SCROLL_PAGE_RIGHT = 13,
/// <summary>
/// <para>
/// Scroll to start.
/// </para>
/// </summary>

	GTK_SCROLL_START = 14,
/// <summary>
/// <para>
/// Scroll to end.
/// </para>
/// </summary>

	GTK_SCROLL_END = 15
}

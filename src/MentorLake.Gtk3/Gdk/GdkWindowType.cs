namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Describes the kind of window.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowType
{
/// <summary>
/// <para>
/// root window; this window has no parent, covers the entire
///  screen, and is created by the window system
/// </para>
/// </summary>

	GDK_WINDOW_ROOT = 0,
/// <summary>
/// <para>
/// toplevel window (used to implement #GtkWindow)
/// </para>
/// </summary>

	GDK_WINDOW_TOPLEVEL = 1,
/// <summary>
/// <para>
/// child window (used to implement e.g. #GtkEntry)
/// </para>
/// </summary>

	GDK_WINDOW_CHILD = 2,
/// <summary>
/// <para>
/// override redirect temporary window (used to implement
///  #GtkMenu)
/// </para>
/// </summary>

	GDK_WINDOW_TEMP = 3,
/// <summary>
/// <para>
/// foreign window (see gdk_window_foreign_new())
/// </para>
/// </summary>

	GDK_WINDOW_FOREIGN = 4,
/// <summary>
/// <para>
/// offscreen window (see
///  [Offscreen Windows][OFFSCREEN-WINDOWS]). Since 2.18
/// </para>
/// </summary>

	GDK_WINDOW_OFFSCREEN = 5,
/// <summary>
/// <para>
/// subsurface-based window; This window is visually
///  tied to a toplevel, and is moved/stacked with it. Currently this window
///  type is only implemented in Wayland. Since 3.14
/// </para>
/// </summary>

	GDK_WINDOW_SUBSURFACE = 6
}

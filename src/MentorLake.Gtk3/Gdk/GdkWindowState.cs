namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the state of a toplevel window.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowState : uint
{
/// <summary>
/// <para>
/// the window is not shown.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_WITHDRAWN = 1,
/// <summary>
/// <para>
/// the window is minimized.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_ICONIFIED = 2,
/// <summary>
/// <para>
/// the window is maximized.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_MAXIMIZED = 4,
/// <summary>
/// <para>
/// the window is sticky.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_STICKY = 8,
/// <summary>
/// <para>
/// the window is maximized without
///   decorations.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_FULLSCREEN = 16,
/// <summary>
/// <para>
/// the window is kept above other windows.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_ABOVE = 32,
/// <summary>
/// <para>
/// the window is kept below other windows.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_BELOW = 64,
/// <summary>
/// <para>
/// the window is presented as focused (with active decorations).
/// </para>
/// </summary>

	GDK_WINDOW_STATE_FOCUSED = 128,
/// <summary>
/// <para>
/// the window is in a tiled state, Since 3.10. Since 3.22.23, this
///                          is deprecated in favor of per-edge information.
/// </para>
/// </summary>

	GDK_WINDOW_STATE_TILED = 256,
/// <summary>
/// <para>
/// whether the top edge is tiled, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_TOP_TILED = 512,
/// <summary>
/// <para>
/// whether the top edge is resizable, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_TOP_RESIZABLE = 1024,
/// <summary>
/// <para>
/// whether the right edge is tiled, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_RIGHT_TILED = 2048,
/// <summary>
/// <para>
/// whether the right edge is resizable, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_RIGHT_RESIZABLE = 4096,
/// <summary>
/// <para>
/// whether the bottom edge is tiled, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_BOTTOM_TILED = 8192,
/// <summary>
/// <para>
/// whether the bottom edge is resizable, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_BOTTOM_RESIZABLE = 16384,
/// <summary>
/// <para>
/// whether the left edge is tiled, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_LEFT_TILED = 32768,
/// <summary>
/// <para>
/// whether the left edge is resizable, Since 3.22.23
/// </para>
/// </summary>

	GDK_WINDOW_STATE_LEFT_RESIZABLE = 65536
}

namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// These are hints for the window manager that indicate what type of function
/// the window has. The window manager can use this when determining decoration
/// and behaviour of the window. The hint must be set before mapping the window.
/// </para>
/// <para>
/// See the [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec)
/// specification for more details about window types.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowTypeHint
{
/// <summary>
/// <para>
/// Normal toplevel window.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_NORMAL = 0,
/// <summary>
/// <para>
/// Dialog window.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_DIALOG = 1,
/// <summary>
/// <para>
/// Window used to implement a menu; GTK+ uses
///  this hint only for torn-off menus, see #GtkTearoffMenuItem.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_MENU = 2,
/// <summary>
/// <para>
/// Window used to implement toolbars.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_TOOLBAR = 3,
/// <summary>
/// <para>
/// Window used to display a splash
///  screen during application startup.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_SPLASHSCREEN = 4,
/// <summary>
/// <para>
/// Utility windows which are not detached
///  toolbars or dialogs.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_UTILITY = 5,
/// <summary>
/// <para>
/// Used for creating dock or panel windows.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_DOCK = 6,
/// <summary>
/// <para>
/// Used for creating the desktop background
///  window.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_DESKTOP = 7,
/// <summary>
/// <para>
/// A menu that belongs to a menubar.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_DROPDOWN_MENU = 8,
/// <summary>
/// <para>
/// A menu that does not belong to a menubar,
///  e.g. a context menu.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_POPUP_MENU = 9,
/// <summary>
/// <para>
/// A tooltip.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_TOOLTIP = 10,
/// <summary>
/// <para>
/// A notification - typically a “bubble”
///  that belongs to a status icon.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_NOTIFICATION = 11,
/// <summary>
/// <para>
/// A popup from a combo box.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_COMBO = 12,
/// <summary>
/// <para>
/// A window that is used to implement a DND cursor.
/// </para>
/// </summary>

	GDK_WINDOW_TYPE_HINT_DND = 13
}

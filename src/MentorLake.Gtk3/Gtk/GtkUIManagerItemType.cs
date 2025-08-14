namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These enumeration values are used by gtk_ui_manager_add_ui() to determine
/// what UI element to create.
/// </para>
/// </summary>

[Flags]
public enum GtkUIManagerItemType : uint
{
/// <summary>
/// <para>
/// Pick the type of the UI element according to context.
/// </para>
/// </summary>

	GTK_UI_MANAGER_AUTO = 0,
/// <summary>
/// <para>
/// Create a menubar.
/// </para>
/// </summary>

	GTK_UI_MANAGER_MENUBAR = 1,
/// <summary>
/// <para>
/// Create a menu.
/// </para>
/// </summary>

	GTK_UI_MANAGER_MENU = 2,
/// <summary>
/// <para>
/// Create a toolbar.
/// </para>
/// </summary>

	GTK_UI_MANAGER_TOOLBAR = 4,
/// <summary>
/// <para>
/// Insert a placeholder.
/// </para>
/// </summary>

	GTK_UI_MANAGER_PLACEHOLDER = 8,
/// <summary>
/// <para>
/// Create a popup menu.
/// </para>
/// </summary>

	GTK_UI_MANAGER_POPUP = 16,
/// <summary>
/// <para>
/// Create a menuitem.
/// </para>
/// </summary>

	GTK_UI_MANAGER_MENUITEM = 32,
/// <summary>
/// <para>
/// Create a toolitem.
/// </para>
/// </summary>

	GTK_UI_MANAGER_TOOLITEM = 64,
/// <summary>
/// <para>
/// Create a separator.
/// </para>
/// </summary>

	GTK_UI_MANAGER_SEPARATOR = 128,
/// <summary>
/// <para>
/// Install an accelerator.
/// </para>
/// </summary>

	GTK_UI_MANAGER_ACCELERATOR = 256,
/// <summary>
/// <para>
/// Same as %GTK_UI_MANAGER_POPUP, but the
///   actions’ accelerators are shown.
/// </para>
/// </summary>

	GTK_UI_MANAGER_POPUP_WITH_ACCELS = 512
}

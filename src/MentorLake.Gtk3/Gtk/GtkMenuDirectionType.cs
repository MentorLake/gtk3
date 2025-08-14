namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// An enumeration representing directional movements within a menu.
/// </para>
/// </summary>

[Flags]
public enum GtkMenuDirectionType
{
/// <summary>
/// <para>
/// To the parent menu shell
/// </para>
/// </summary>

	GTK_MENU_DIR_PARENT = 0,
/// <summary>
/// <para>
/// To the submenu, if any, associated with the item
/// </para>
/// </summary>

	GTK_MENU_DIR_CHILD = 1,
/// <summary>
/// <para>
/// To the next menu item
/// </para>
/// </summary>

	GTK_MENU_DIR_NEXT = 2,
/// <summary>
/// <para>
/// To the previous menu item
/// </para>
/// </summary>

	GTK_MENU_DIR_PREV = 3
}

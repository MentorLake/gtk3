namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Built-in stock icon sizes.
/// </para>
/// </summary>

[Flags]
public enum GtkIconSize
{
/// <summary>
/// <para>
/// Invalid size.
/// </para>
/// </summary>

	GTK_ICON_SIZE_INVALID = 0,
/// <summary>
/// <para>
/// Size appropriate for menus (16px).
/// </para>
/// </summary>

	GTK_ICON_SIZE_MENU = 1,
/// <summary>
/// <para>
/// Size appropriate for small toolbars (16px).
/// </para>
/// </summary>

	GTK_ICON_SIZE_SMALL_TOOLBAR = 2,
/// <summary>
/// <para>
/// Size appropriate for large toolbars (24px)
/// </para>
/// </summary>

	GTK_ICON_SIZE_LARGE_TOOLBAR = 3,
/// <summary>
/// <para>
/// Size appropriate for buttons (16px)
/// </para>
/// </summary>

	GTK_ICON_SIZE_BUTTON = 4,
/// <summary>
/// <para>
/// Size appropriate for drag and drop (32px)
/// </para>
/// </summary>

	GTK_ICON_SIZE_DND = 5,
/// <summary>
/// <para>
/// Size appropriate for dialogs (48px)
/// </para>
/// </summary>

	GTK_ICON_SIZE_DIALOG = 6
}

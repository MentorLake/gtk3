namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Error codes for GtkIconTheme operations.
/// </para>
/// </summary>

[Flags]
public enum GtkIconThemeError
{
/// <summary>
/// <para>
/// The icon specified does not exist in the theme
/// </para>
/// </summary>

	GTK_ICON_THEME_NOT_FOUND = 0,
/// <summary>
/// <para>
/// An unspecified error occurred.
/// </para>
/// </summary>

	GTK_ICON_THEME_FAILED = 1
}

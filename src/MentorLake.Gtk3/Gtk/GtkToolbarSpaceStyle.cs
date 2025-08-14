namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Whether spacers are vertical lines or just blank.
/// </para>
/// </summary>

[Flags]
public enum GtkToolbarSpaceStyle
{
/// <summary>
/// <para>
/// Use blank spacers.
/// </para>
/// </summary>

	GTK_TOOLBAR_SPACE_EMPTY = 0,
/// <summary>
/// <para>
/// Use vertical lines for spacers.
/// </para>
/// </summary>

	GTK_TOOLBAR_SPACE_LINE = 1
}

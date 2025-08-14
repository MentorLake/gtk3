namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to reference the parts of #GtkTextView.
/// </para>
/// </summary>

[Flags]
public enum GtkTextWindowType
{
/// <summary>
/// <para>
/// Invalid value, used as a marker
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_PRIVATE = 0,
/// <summary>
/// <para>
/// Window that floats over scrolling areas.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_WIDGET = 1,
/// <summary>
/// <para>
/// Scrollable text window.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_TEXT = 2,
/// <summary>
/// <para>
/// Left side border window.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_LEFT = 3,
/// <summary>
/// <para>
/// Right side border window.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_RIGHT = 4,
/// <summary>
/// <para>
/// Top border window.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_TOP = 5,
/// <summary>
/// <para>
/// Bottom border window.
/// </para>
/// </summary>

	GTK_TEXT_WINDOW_BOTTOM = 6
}

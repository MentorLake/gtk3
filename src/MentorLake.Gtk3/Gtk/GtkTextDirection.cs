namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Reading directions for text.
/// </para>
/// </summary>

[Flags]
public enum GtkTextDirection
{
/// <summary>
/// <para>
/// No direction.
/// </para>
/// </summary>

	GTK_TEXT_DIR_NONE = 0,
/// <summary>
/// <para>
/// Left to right text direction.
/// </para>
/// </summary>

	GTK_TEXT_DIR_LTR = 1,
/// <summary>
/// <para>
/// Right to left text direction.
/// </para>
/// </summary>

	GTK_TEXT_DIR_RTL = 2
}

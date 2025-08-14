namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes a type of line wrapping.
/// </para>
/// </summary>

[Flags]
public enum GtkWrapMode
{
/// <summary>
/// <para>
/// do not wrap lines; just make the text area wider
/// </para>
/// </summary>

	GTK_WRAP_NONE = 0,
/// <summary>
/// <para>
/// wrap text, breaking lines anywhere the cursor can
///     appear (between characters, usually - if you want to be technical,
///     between graphemes, see pango_get_log_attrs())
/// </para>
/// </summary>

	GTK_WRAP_CHAR = 1,
/// <summary>
/// <para>
/// wrap text, breaking lines in between words
/// </para>
/// </summary>

	GTK_WRAP_WORD = 2,
/// <summary>
/// <para>
/// wrap text, breaking lines in between words, or if
///     that is not enough, also between graphemes
/// </para>
/// </summary>

	GTK_WRAP_WORD_CHAR = 3
}

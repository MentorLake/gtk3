namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// See also: #GtkEntry::delete-from-cursor.
/// </para>
/// </summary>

[Flags]
public enum GtkDeleteType
{
/// <summary>
/// <para>
/// Delete characters.
/// </para>
/// </summary>

	GTK_DELETE_CHARS = 0,
/// <summary>
/// <para>
/// Delete only the portion of the word to the
///   left/right of cursor if we’re in the middle of a word.
/// </para>
/// </summary>

	GTK_DELETE_WORD_ENDS = 1,
/// <summary>
/// <para>
/// Delete words.
/// </para>
/// </summary>

	GTK_DELETE_WORDS = 2,
/// <summary>
/// <para>
/// Delete display-lines. Display-lines
///   refers to the visible lines, with respect to to the current line
///   breaks. As opposed to paragraphs, which are defined by line
///   breaks in the input.
/// </para>
/// </summary>

	GTK_DELETE_DISPLAY_LINES = 3,
/// <summary>
/// <para>
/// Delete only the portion of the
///   display-line to the left/right of cursor.
/// </para>
/// </summary>

	GTK_DELETE_DISPLAY_LINE_ENDS = 4,
/// <summary>
/// <para>
/// Delete to the end of the
///   paragraph. Like C-k in Emacs (or its reverse).
/// </para>
/// </summary>

	GTK_DELETE_PARAGRAPH_ENDS = 5,
/// <summary>
/// <para>
/// Delete entire line. Like C-k in pico.
/// </para>
/// </summary>

	GTK_DELETE_PARAGRAPHS = 6,
/// <summary>
/// <para>
/// Delete only whitespace. Like M-\ in Emacs.
/// </para>
/// </summary>

	GTK_DELETE_WHITESPACE = 7
}
